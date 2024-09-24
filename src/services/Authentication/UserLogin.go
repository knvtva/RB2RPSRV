package authentcation

import (
	"github.com/knvtva/nex-go"
)

func Login(err error, client *nex.Client, callerID uint32, username string) {
	stationURL := fmt.Sprintf("prudps:/address=192.168.1.27;port=30846;CID=1;PID=2;sid=1;stream=3;type=2")

	rmcResponseStream := nex.NewStream()
	rmcResponseStream.Grow(int64(23))

	rmcResponseStream.WriteU32LENext([]uint32{0x10001})
	rmcResponseStream.WriteU32LENext([]uint32{0x501})
	rmcResponseStream.WriteBuffer(append(encryptedTicket[:], calculatedHmac[:]...))

	// RVConnectionData
	rmcResponseStream.WriteBufferString(stationURL)
	rmcResponseStream.WriteU32LENext(([]uint32{0}))

	rmcResponseStream.WriteU32LENext([]uint32{0x1})
	rmcResponseStream.WriteU32LENext([]uint32{0x100})

	rmcResponseBody := rmcResponseStream.Bytes()

	rmcResponse := nex.NewRMCResponse(nexp.AuthenticationProtocolID, callerID)
	rmcResponse.SetSuccess(nexp.AuthenticationMethodLogin, rmcResponseBody)

	rmcResponseBytes := rmcResponse.Bytes()

	responsePacket, _ := nex.NewPacketV0(client, nil)

	responsePacket.SetVersion(0)
	responsePacket.SetSource(0x31)
	responsePacket.SetDestination(0x3F)
	responsePacket.SetType(nex.DataPacket)

	responsePacket.SetPayload(rmcResponseBytes)

	responsePacket.AddFlag(nex.FlagNeedsAck)
	responsePacket.AddFlag(nex.FlagReliable)

	NexData.Auth.Send(responsePacket)


}