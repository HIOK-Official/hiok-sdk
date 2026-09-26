package hiok

import (
	"bytes"
	"context"
	"encoding/json"
	"errors"
	"fmt"
	"io"
	"mime/multipart"
	"net/http"
	"net/url"
	"os"
	"strings"
	"time"
)

// NewFromEnvironment builds a client from HIOK_ENDPOINT, HIOK_TOKEN and HIOK_STORAGE_KEY.
func NewFromEnvironment() *Client {
	c := New(os.Getenv("HIOK_ENDPOINT"), os.Getenv("HIOK_TOKEN"))
	c.StorageKey = os.Getenv("HIOK_STORAGE_KEY")
	return c
}

// API returns every API operation, grouped as the API groups them:
// client.API().KeyVault.List(ctx).
func (c *Client) API() *Api {
	c.apiOnce.Do(func() { c.api = newAPI(c) })
	return c.api
}

// Query holds optional query parameters; nil values are left out.
type Query map[string]any

// FilePart is one file of a multipart request.
type FilePart struct {
	FileName string
	Content  []byte
}

// APIError is an error answer from the API.
type APIError struct {
	Method  string
	Path    string
	Status  int
	Message string
	Body    json.RawMessage
}

func (e *APIError) Error() string {
	return fmt.Sprintf("%s %s returned %d: %s", e.Method, e.Path, e.Status, e.Message)
}

// IsNotFound reports whether err is an API 404.
func IsNotFound(err error) bool {
	var apiErr *APIError
	return errors.As(err, &apiErr) && apiErr.Status == http.StatusNotFound
}

// segment encodes one path parameter; a key keeps its slashes ("dir/file.txt").
func segment(value string, slashed bool) string {
	if !slashed {
		return url.PathEscape(value)
	}
	parts := strings.Split(value, "/")
	for i, p := range parts {
		parts[i] = url.PathEscape(p)
	}
	return strings.Join(parts, "/")
}

func encodeQuery(q Query) string {
	if len(q) == 0 {
		return ""
	}
	values := url.Values{}
	for key, v := range q {
		switch t := v.(type) {
		case nil:
		case []string:
			for _, s := range t {
				values.Add(key, s)
			}
		case time.Time:
			values.Add(key, t.Format(time.RFC3339))
		case *string:
			if t != nil {
				values.Add(key, *t)
			}
		default:
			values.Add(key, fmt.Sprint(v))
		}
	}
	if len(values) == 0 {
		return ""
	}
	return "?" + values.Encode()
}

func (c *Client) authorize(req *http.Request) error {
	switch {
	case c.Token != "":
		req.Header.Set("Authorization", "Bearer "+c.Token)
	case c.StorageKey != "":
		req.Header.Set("x-hiok-storage-key", c.StorageKey)
	default:
		return errors.New("no credentials: set Token or StorageKey, or call Login")
	}
	return nil
}

// Call sends one JSON request and returns the raw JSON answer. Every generated
// operation uses it; call it directly for anything not covered.
func (c *Client) Call(ctx context.Context, method, path string, body any, query Query) (json.RawMessage, error) {
	var payload []byte
	if body != nil {
		var err error
		if b, ok := body.([]byte); ok {
			payload = b
		} else if payload, err = json.Marshal(body); err != nil {
			return nil, err
		}
	}
	headers := map[string]string{}
	if body != nil {
		if _, raw := body.([]byte); !raw {
			headers["Content-Type"] = "application/json"
		}
	}
	return c.CallRaw(ctx, method, path+encodeQuery(query), payload, headers)
}

// CallRaw sends a request with a prepared body and returns the response body.
func (c *Client) CallRaw(ctx context.Context, method, target string, payload []byte, headers map[string]string) ([]byte, error) {
	safe := method == http.MethodGet || method == http.MethodHead || method == http.MethodOptions
	attempts := 1
	if safe {
		attempts = c.Retries + 1
	}
	for attempt := 0; ; attempt++ {
		var reader io.Reader
		if payload != nil {
			reader = bytes.NewReader(payload)
		}
		req, err := http.NewRequestWithContext(ctx, method, c.Endpoint+target, reader)
		if err != nil {
			return nil, err
		}
		req.Header.Set("Accept", "application/json")
		req.Header.Set("User-Agent", "hiok-go-sdk/0.2")
		for k, v := range headers {
			req.Header.Set(k, v)
		}
		if err := c.authorize(req); err != nil {
			return nil, err
		}
		resp, err := c.HTTP.Do(req)
		if err != nil {
			if attempt+1 < attempts {
				backoff(ctx, attempt)
				continue
			}
			return nil, err
		}
		raw, readErr := io.ReadAll(resp.Body)
		resp.Body.Close()
		if readErr != nil {
			return nil, readErr
		}
		if resp.StatusCode < 300 {
			return raw, nil
		}
		switch resp.StatusCode {
		case 429, 502, 503, 504:
			if attempt+1 < attempts {
				backoff(ctx, attempt)
				continue
			}
		}
		return nil, newAPIError(method, strings.SplitN(target, "?", 2)[0], resp.StatusCode, raw)
	}
}

// CallMultipart sends multipart/form-data.
func (c *Client) CallMultipart(ctx context.Context, method, path string, form map[string]string, files map[string]FilePart, query Query) (json.RawMessage, error) {
	var buf bytes.Buffer
	w := multipart.NewWriter(&buf)
	for k, v := range form {
		if err := w.WriteField(k, v); err != nil {
			return nil, err
		}
	}
	for k, f := range files {
		part, err := w.CreateFormFile(k, f.FileName)
		if err != nil {
			return nil, err
		}
		if _, err := part.Write(f.Content); err != nil {
			return nil, err
		}
	}
	if err := w.Close(); err != nil {
		return nil, err
	}
	return c.CallRaw(ctx, method, path+encodeQuery(query), buf.Bytes(), map[string]string{"Content-Type": w.FormDataContentType()})
}

func newAPIError(method, path string, status int, raw []byte) *APIError {
	e := &APIError{Method: method, Path: path, Status: status, Message: strings.TrimSpace(string(raw))}
	var parsed map[string]any
	if json.Unmarshal(raw, &parsed) == nil {
		e.Body = raw
		for _, k := range []string{"message", "Message"} {
			if m, ok := parsed[k].(string); ok && m != "" {
				e.Message = m
				break
			}
		}
	}
	return e
}

func backoff(ctx context.Context, attempt int) {
	d := time.Duration(1<<attempt) * time.Second
	if d > 16*time.Second {
		d = 16 * time.Second
	}
	select {
	case <-ctx.Done():
	case <-time.After(d):
	}
}
