using Lemonade.Net;
using Lemonade.Net.Protocol;
using Lemonade.Utils;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Serilog;


namespace Lemonade.Packet.Handlers;

public class PlayerSetPauseReqHandler : PacketHandlerFactory.IPacketHandler
{
    public async Task HandleAsync(Packet incPacket, Session session)
    {
        PlayerSetPauseReq data = PlayerSetPauseReq.Parser.ParseFrom(incPacket.Data);

        session.World.CurrentEncounter?.SetEncounterTimerPauseState(data.IsPaused);
    }

}