using Lemonade.Net;
using Lemonade.Net.Protocol;
using Lemonade.Utils;
using System.Threading.Tasks;


namespace Lemonade.Packet.Handlers;

public class GetPlayerTokenRspHandler : PacketHandlerFactory.IPacketHandler
{
    public async Task HandleAsync(Packet incPacket, Session session)
    {
        GetPlayerTokenRsp tokenRsp = GetPlayerTokenRsp.Parser.ParseFrom(incPacket.data);

        
        if (tokenRsp != null)
        {
            var key = new MTKey(MiHoYoKeyGenerator.GenerateKey(tokenRsp.SecretKeySeed));
            session.handler.Client.Key = key;
            session.Key = key;
        }

        
    }

}

