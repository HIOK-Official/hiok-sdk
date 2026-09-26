package hiok

import (
	"context"
	"crypto/rand"
	"crypto/sha256"
	"encoding/base64"
	"encoding/hex"
	"encoding/json"
	"fmt"
	"io"
	"os"
	"path/filepath"
	"strings"
	"sync"
)

// BlockSize is the largest single write; bigger content is staged as blocks of this size.
const BlockSize = 3 * 1024 * 1024

// Storage moves files in and out of storage accounts.
//
//	s := client.Storage()
//	s.UploadFile(ctx, accountID, "backups", "2026/db.dump", "/var/backups/db.dump")
//	s.DownloadFile(ctx, accountID, "backups", "2026/db.dump", "/tmp/db.dump")
//	s.UploadStream(ctx, accountID, "backups", "big.bin", anyReader, "")
//
// A write reaches the region in one message, which caps it at 3 MB, so larger content
// is staged as 3 MB blocks (several at once) and committed as one object; reads are
// ranged the same way, so memory stays flat.
type Storage struct{ c *Client }

// Storage returns the storage transfer helper.
func (c *Client) Storage() *Storage { return &Storage{c: c} }

// Object is the stored object as the API describes it.
type Object struct {
	Key         string `json:"key"`
	Name        string `json:"name"`
	SizeBytes   int64  `json:"sizeBytes"`
	ContentType string `json:"contentType"`
	ETag        string `json:"eTag"`
	ContentHash string `json:"contentHash"`
	IsDirectory bool   `json:"isDirectory"`
}

func data[T any](raw json.RawMessage, err error) (T, error) {
	var out struct {
		Data T `json:"data"`
	}
	if err != nil {
		return out.Data, err
	}
	return out.Data, json.Unmarshal(raw, &out)
}

// EnsureContainer returns the container, creating it if needed. kind: blob, block, fileshare, filesystem.
func (s *Storage) EnsureContainer(ctx context.Context, accountID, name, kind string) error {
	if _, err := s.c.API().StorageObject.GetContainer(ctx, accountID, name); err == nil {
		return nil
	} else if !IsNotFound(err) {
		return err
	}
	_, err := s.c.API().StorageObject.CreateContainer(ctx, accountID, map[string]string{"name": name, "kind": kind})
	return err
}

// List returns the objects in a container, optionally under a key prefix.
func (s *Storage) List(ctx context.Context, accountID, container, prefix string) ([]Object, error) {
	q := Query{"limit": 5000}
	if prefix != "" {
		q["prefix"] = prefix
	}
	return data[[]Object](s.c.API().StorageObject.ListObjects(ctx, accountID, container, q))
}

// Stat returns one object's description.
func (s *Storage) Stat(ctx context.Context, accountID, container, key string) (Object, error) {
	return data[Object](s.c.API().StorageObject.GetObject(ctx, accountID, container, key))
}

// Delete removes an object (a directory with everything beneath it).
func (s *Storage) Delete(ctx context.Context, accountID, container, key string) error {
	_, err := s.c.API().StorageObject.DeleteObject(ctx, accountID, container, key)
	return err
}

// UploadFile uploads a local file.
func (s *Storage) UploadFile(ctx context.Context, accountID, container, key, localPath string) (Object, error) {
	f, err := os.Open(localPath)
	if err != nil {
		return Object{}, err
	}
	defer f.Close()
	return s.UploadStream(ctx, accountID, container, key, f, "")
}

// UploadStream uploads from any reader, of known or unknown length.
func (s *Storage) UploadStream(ctx context.Context, accountID, container, key string, src io.Reader, contentType string) (Object, error) {
	first, err := readBlock(src)
	if err != nil {
		return Object{}, err
	}
	if len(first) < BlockSize {
		body := map[string]any{"key": key, "content": base64.StdEncoding.EncodeToString(first), "isBase64": true}
		if contentType != "" {
			body["contentType"] = contentType
		}
		return data[Object](s.c.API().StorageObject.PutObject(ctx, accountID, container, body))
	}

	tag := make([]byte, 6)
	_, _ = rand.Read(tag)
	upload := hex.EncodeToString(tag)
	ctx, cancel := context.WithCancel(ctx)
	defer cancel()

	var (
		ids      []string
		wg       sync.WaitGroup
		mu       sync.Mutex
		firstErr error
		gate     = make(chan struct{}, 4)
	)
	for block := first; len(block) > 0; {
		id := fmt.Sprintf("sdk-%s-%06d", upload, len(ids))
		ids = append(ids, id)
		gate <- struct{}{}
		wg.Add(1)
		go func(id string, b []byte) {
			defer wg.Done()
			defer func() { <-gate }()
			_, err := s.c.API().StorageObject.StageBlock(ctx, accountID, container, map[string]any{
				"blobName": key, "blockId": id, "content": base64.StdEncoding.EncodeToString(b), "isBase64": true,
			})
			if err != nil {
				mu.Lock()
				if firstErr == nil {
					firstErr = err
					cancel()
				}
				mu.Unlock()
			}
		}(id, block)
		if block, err = readBlock(src); err != nil {
			wg.Wait()
			return Object{}, err
		}
	}
	wg.Wait()
	if firstErr != nil {
		return Object{}, firstErr
	}
	commit := map[string]any{"blobName": key, "blockIds": ids, "discardStagedBlocks": true}
	if contentType != "" {
		commit["contentType"] = contentType
	}
	return data[Object](s.c.API().StorageObject.CommitBlockList(ctx, accountID, container, commit))
}

// DownloadStream writes the object to w, fetched in 3 MB ranges.
func (s *Storage) DownloadStream(ctx context.Context, accountID, container, key string, w io.Writer) (int64, error) {
	obj, err := s.Stat(ctx, accountID, container, key)
	if err != nil {
		return 0, err
	}
	path := "/api/storageaccount/" + segment(accountID, false) + "/containers/" + segment(container, false) +
		"/content/" + segment(key, true)
	var done int64
	for done < obj.SizeBytes {
		end := done + BlockSize
		if end > obj.SizeBytes {
			end = obj.SizeBytes
		}
		chunk, err := s.c.CallRaw(ctx, "GET", path, nil, map[string]string{"Range": fmt.Sprintf("bytes=%d-%d", done, end-1)})
		if err != nil {
			return done, err
		}
		if len(chunk) == 0 {
			break
		}
		if _, err := w.Write(chunk); err != nil {
			return done, err
		}
		done += int64(len(chunk))
	}
	return done, nil
}

// DownloadFile downloads to a local file through a temporary name, checking the
// sha256 stored with the object when it has one.
func (s *Storage) DownloadFile(ctx context.Context, accountID, container, key, localPath string) (int64, error) {
	if err := os.MkdirAll(filepath.Dir(localPath), 0o755); err != nil {
		return 0, err
	}
	partial := localPath + ".partial"
	f, err := os.Create(partial)
	if err != nil {
		return 0, err
	}
	sum := sha256.New()
	n, err := s.DownloadStream(ctx, accountID, container, key, io.MultiWriter(f, sum))
	if cerr := f.Close(); err == nil {
		err = cerr
	}
	if err != nil {
		os.Remove(partial)
		return n, err
	}
	if obj, err := s.Stat(ctx, accountID, container, key); err == nil && len(obj.ContentHash) == 64 &&
		!strings.EqualFold(obj.ContentHash, hex.EncodeToString(sum.Sum(nil))) {
		os.Remove(partial)
		return n, fmt.Errorf("%s: downloaded content does not match the stored sha256", key)
	}
	return n, os.Rename(partial, localPath)
}

func readBlock(r io.Reader) ([]byte, error) {
	buf := make([]byte, BlockSize)
	n, err := io.ReadFull(r, buf)
	if err == io.EOF || err == io.ErrUnexpectedEOF {
		return buf[:n], nil
	}
	return buf[:n], err
}
