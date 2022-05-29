using Lemonade.Net;
using Lemonade.Net.Protocol;
using Lemonade.Utils;
using System.Threading.Tasks;
using Serilog;


namespace Lemonade.Packet.Handlers;

public class UnionCmdNotifyHandler : PacketHandlerFactory.IPacketHandler
{
    public async Task HandleAsync(Packet incPacket, Session session)
    {
        UnionCmdNotify unionCmdNotify = UnionCmdNotify.Parser.ParseFrom(incPacket.Data);

        foreach (UnionCmd unionCmd in unionCmdNotify.CmdList)
        {
            //we handle this serverside
            if (unionCmd.MessageId == (int)PacketOpcodes.CombatInvocationsNotify) break;

            var handler = PacketHandlerFactory.NewInstance((PacketOpcodes)unionCmd.MessageId);

            if (handler != null)
            {
                handler.HandleAsync(new Packet(unionCmd.Body), session).Wait();
            }
            else
            {
                Log.Warning("UnionCmd: {id}", (PacketOpcodes)unionCmd.MessageId);
            }

        }
    }

}