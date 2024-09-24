package services

import (
	"log"
	"rb2rpsrv/services/Authentication"
	"github.com/knvtva/nex-go"
	nexp "github.com/knvtva/nex-protocols-go"
)

var Auth *nex.Server

func SetupAuth() {
	Auth = nex.NewServer()
	Auth.SetPrudpVersion(0)
	Auth.SetSignatureVersion(1)
	Auth.SetKerberosKeySize(16)
	Auth.SetChecksumVersion(1)
	Auth.UsePacketCompression(false)
	Auth.SetFlagsVersion(0)
	// TODO: Get the access key from an ini file and set it.
	Auth.SetAccessKey("dqN3rVe")
	AuthServer.SetFragmentSize(750)

	authentcation := nexp.NewAuthenticationProtocol(Auth)

	authentcation.Login()
}