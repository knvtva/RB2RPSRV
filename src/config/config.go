package config

import (
	"log"
	"os"
	"gopkg.in/ini.v1"
)

var Config struct {
	AccessKey    string
	AuthPort     string
	SecurePort   string
	UserPassword string
	MongoDBURI   string
}

func ReadConfig() {
	cfg, err := ini.Load("config.ini")
	if err != nil {
		log.Fatalf("Fail to read file: %v", err)
		os.Exit(1)
	}

	Config.AccessKey = cfg.Section("Server").Key("AccessKey").String()
	Config.AuthPort = cfg.Section("Server").Key("AuthPort").String()
	Config.SecurePort = cfg.Section("Server").Key("SecurePort").String()
	Config.UserPassword = cfg.Section("Server").Key("UserPassword").String()
	
	Config.MongoDBURI = cfg.Section("Database").Key("URI").String()
}
