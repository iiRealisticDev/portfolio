package main

import (
	"errors"
	"fmt"
	"log"
	"net/http"
	"os"
	"strings"

	ctypes "./custom_types"
)

var apiPaths = map[string]map[string]interface{}{
	"v1": map[string]interface{}{
		"getuser": func(user string) string {
			return "h"
		},
	},
}

func main() {
	fmt.Println(ctypes.H()) // shuts up compiler
	http.HandleFunc("/", serveFiles)
	http.HandleFunc("/api/", apiHandler)
	http.Handle("/css/", http.StripPrefix("/css/", http.FileServer(http.Dir("css"))))
	http.Handle("/js/", http.StripPrefix("/js/", http.FileServer(http.Dir("js"))))
	log.Fatal(http.ListenAndServe(":8080", nil))
}

func serveFiles(w http.ResponseWriter, r *http.Request) {
	p := "./views" + r.URL.Path + ".html"
	if p == "./views/.html" {
		p = "./views/index.html"
	}
	if _, err := os.Stat(p); errors.Is(err, os.ErrNotExist) {
		http.ServeFile(w, r, "./views/404.html")
		return
	}
	fmt.Println(p)
	http.ServeFile(w, r, p)
}

func apiHandler(w http.ResponseWriter, r *http.Request) {
	p := strings.Split(r.URL.Path, "/")
	v := string(p[2])
	i := p[3]
	// unfinished - will show compiler errors
}
