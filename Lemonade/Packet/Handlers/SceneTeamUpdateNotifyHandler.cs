using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lemonade.Net;
using Lemonade.Net.Protocol;

namespace Lemonade.Packet.Handlers
{
    public class SceneTeamUpdateNotifyHandler: PacketHandlerFactory.IPacketHandler
    {
        public async Task HandleAsync(Packet incPacket, Session session)
        {
            // session.world
            SceneTeamUpdateNotify appearNotify = SceneTeamUpdateNotify.Parser.ParseFrom(incPacket.Data);
            foreach (var sceneTeamAvatar in appearNotify.SceneTeamAvatarList)
            {
                
            }
        }
    }
}
