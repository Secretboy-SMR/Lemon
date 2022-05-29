using Lemonade.Net;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Google.Protobuf;

namespace Lemonade.Packet;

public class PacketHandlerFactory
{
    private static Dictionary<PacketOpcodes, Type> _handlers = new();

    public static void InitializeFactory()
    {
        var types = Assembly.GetExecutingAssembly().GetTypes()
            .Where(type =>
                type.Namespace == "Lemonade.Packet.Handlers");
        foreach (var h in types)
            //the handlers will be named _______Handler
            //i would do the name itself but its already taken by the proto classes
            if (Enum.TryParse(h.Name.Substring(0, h.Name.Length - 7), out PacketOpcodes typeEnum))
                _handlers.Add(typeEnum, h);
        Log.Debug($"Loaded {_handlers.Count} PacketHandlers");
    }

    public static IPacketHandler? NewInstance(PacketOpcodes msgType)
    {

        if (_handlers.TryGetValue(msgType, out var responseType))
        {
            var constructor = responseType.GetConstructor(new Type[] { });

            if (constructor != null) return (IPacketHandler)constructor.Invoke(new object[] { });
        }
        else
        {
            //Log.Warning("Packet {ada} not yet implemented", msgType);
            return null;
        }

        return null;
    }

    public interface IPacketHandler
    {
        Task HandleAsync(Packet packet, Session session);

    }
    
}

/*

using Lemonade.Net;
using Lemonade.Net.Protocol;
using Lemonade.Utils;
using System.Threading.Tasks;


namespace Lemonade.Packet.Handlers;

public class $NAME$ : PacketHandlerFactory.IPacketHandler
{
    public new async Task HandleAsync(Packet IncPacket, Session session)

    {

    }

}

*/