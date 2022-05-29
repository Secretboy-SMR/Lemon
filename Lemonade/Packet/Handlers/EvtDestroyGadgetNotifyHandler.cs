using Lemonade.Net;
using Lemonade.Net.Protocol;
using Lemonade.Utils;
using System.Threading.Tasks;


namespace Lemonade.Packet.Handlers;

public class EvtDestroyGadgetNotifyHandler : PacketHandlerFactory.IPacketHandler
{
    public async Task HandleAsync(Packet incPacket, Session session)
    {
        EvtDestroyGadgetNotify evtDestroyGadgetNotify = EvtDestroyGadgetNotify.Parser.ParseFrom(incPacket.Data);
        session.World.Scene.RemoveEntity(evtDestroyGadgetNotify.EntityId);
    }

}