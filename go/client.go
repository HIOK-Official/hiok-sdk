// Package hiok provides a small, dependency-free client for HIOK Cloud.
package hiok

import (
	"bytes"
	"context"
	"encoding/json"
	"fmt"
	"io"
	"net/http"
	"net/url"
	"strings"
	"time"
)

type Client struct {
	Endpoint string
	Token    string
	HTTP     *http.Client
}

func New(endpoint, token string) *Client {
	if endpoint == "" {
		endpoint = "https://hiokcloud.com"
	}
	return &Client{Endpoint: strings.TrimRight(endpoint, "/"), Token: token, HTTP: &http.Client{Timeout: 5 * time.Minute}}
}

func (c *Client) Login(ctx context.Context, email, password string) error {
	var response struct {
		Data struct {
			Token string `json:"token"`
		} `json:"data"`
		Message string `json:"message"`
	}
	if err := c.Do(ctx, http.MethodPost, "/api/OAuth/token", map[string]string{"email": email, "password": password}, &response, false); err != nil {
		return err
	}
	if response.Data.Token == "" {
		return fmt.Errorf("sign-in failed: %s", response.Message)
	}
	c.Token = response.Data.Token
	return nil
}

func (c *Client) Do(ctx context.Context, method, path string, in, out any, auth bool) error {
	var body io.Reader
	if in != nil {
		raw, err := json.Marshal(in)
		if err != nil {
			return err
		}
		body = bytes.NewReader(raw)
	}
	req, err := http.NewRequestWithContext(ctx, method, c.Endpoint+path, body)
	if err != nil {
		return err
	}
	req.Header.Set("Accept", "application/json")
	if in != nil {
		req.Header.Set("Content-Type", "application/json")
	}
	if auth {
		if c.Token == "" {
			return fmt.Errorf("no token configured")
		}
		req.Header.Set("Authorization", "Bearer "+c.Token)
	}
	resp, err := c.HTTP.Do(req)
	if err != nil {
		return err
	}
	defer resp.Body.Close()
	raw, _ := io.ReadAll(resp.Body)
	if resp.StatusCode < 200 || resp.StatusCode > 299 {
		return fmt.Errorf("%s %s returned %d: %s", method, path, resp.StatusCode, strings.TrimSpace(string(raw)))
	}
	if out != nil && len(raw) > 0 {
		return json.Unmarshal(raw, out)
	}
	return nil
}

func (c *Client) Regions(ctx context.Context) ([]map[string]any, error) {
	var r struct {
		Data []map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, "/api/storageaccount/regions", nil, &r, false)
	return r.Data, err
}
func (c *Client) VirtualMachines(ctx context.Context) ([]map[string]any, error) {
	var r struct {
		Data []map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, "/api/VirtualMachine/list-vms-info", nil, &r, true)
	return r.Data, err
}

func (c *Client) CreateVirtualMachine(ctx context.Context, name, region, image string, vcpus int, ramGB float64) error {
	if region == "" {
		region = "south-india"
	}
	if image == "" {
		image = "ubuntu-24.04"
	}
	if vcpus <= 0 {
		vcpus = 1
	}
	if ramGB <= 0 {
		ramGB = 1
	}
	return c.Do(ctx, http.MethodPost, "/api/VirtualMachine/create-vm", map[string]any{
		"vmName": name, "regions": []string{region}, "sourceFilePath": image,
		"vcpuCount": vcpus, "ramSize": ramGB,
	}, nil, true)
}
func (c *Client) Search(ctx context.Context, query string) (map[string]any, error) {
	var r struct {
		Data map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, "/api/search?q="+url.QueryEscape(query), nil, &r, true)
	return r.Data, err
}
