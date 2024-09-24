package config

import (
	"log"
	"os"
	"gopkg.in/ini.v1"
)

func ReadConfig() {
	cfg, err := ini.Load("config.ini")
	if err != nil {
		log.Fatalf("Fail to read file: %v", err)
		os.Exit(1)
	}
	
	AccessKey := cfg.Section("Server").Key("AccessKey").String()
	AuthPort := cfg.Section("Server").Key("AuthPort")
	SecurePort := cfg.Section("Server").Key("SecurePort")
	UserPassword := cfg.Section("Server").Key("UserPassword").String()

	MongoDBURI := cfg.Section("Database").Key("URI").String()
}
