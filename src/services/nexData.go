package main

import (
	"log"
	"github.com/knvtva/nex-go"
)

var Auth *nex.Server

func SetupAuth() {
	Auth = nex.NewServer()
	Auth.SetPrudpVersion(0)
	Auth.SetSignatureVersion(1)
    	Auth.SetKerberosKeySize(16)
    	Auth.SetAccessKey("dqN3rVe")
}