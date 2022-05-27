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
            session.handler.Client.Key = new MTKey(tokenRsp.SecretKeySeed);
            session.Key = new MTKey(tokenRsp.SecretKeySeed);
        }

        
    }

}

