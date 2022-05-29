using Lemonade.Net;
using Lemonade.Net.Protocol;
using Lemonade.Utils;
using System.Threading.Tasks;


namespace Lemonade.Packet.Handlers;

public class AvatarFightPropUpdateNotifyHandler : PacketHandlerFactory.IPacketHandler
{
    public async Task HandleAsync(Packet incPacket, Session session)
    {
        return;
        
        // this is for upgrading characters
        // 
        AvatarFightPropUpdateNotify afpun = AvatarFightPropUpdateNotify.Parser.ParseFrom(incPacket.Data);

    }

}