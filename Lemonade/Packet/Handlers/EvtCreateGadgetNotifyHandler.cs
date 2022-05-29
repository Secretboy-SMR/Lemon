using Lemonade.Net;
using Lemonade.Net.Protocol;
using Lemonade.Utils;
using System.Threading.Tasks;


namespace Lemonade.Packet.Handlers;

public class EvtCreateGadgetNotifyHandler : PacketHandlerFactory.IPacketHandler
{
    public async Task HandleAsync(Packet incPacket, Session session)
    {
        EvtCreateGadgetNotify evtCreateGadgetNotify = EvtCreateGadgetNotify.Parser.ParseFrom(incPacket.Data);
        // use this to do ownership
        session.World.Scene.AssociateOwner(evtCreateGadgetNotify.OwnerEntityId, evtCreateGadgetNotify.EntityId);
        
    }

}