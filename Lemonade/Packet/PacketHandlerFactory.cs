using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Threading.Tasks;
using Serilog;

namespace Lemonade.Packet;

public class PacketHandlerFactory
{
    private static Dictionary<PacketOpcodes, Type> Handlers = new();
    
    public static void InitializeFactory()
    {
        var types = Assembly.GetExecutingAssembly().GetTypes()
            .Where(type =>
                type.Namespace == "Lemonade.Packet.Handlers");
        foreach (var h in types)
            //the handlers will be named _______Handler
            //i would do the name itself but its already taken by the proto classes
            if (Enum.TryParse(h.Name.Substring(0, h.Name.Length - 7), out PacketOpcodes typeEnum))
                Handlers.Add(typeEnum, h);
        Log.Debug($"Loaded {Handlers.Count} PacketHandlers");
    }
    
    public static IPacketHandler NewInstance(PacketOpcodes msgType)
    {

        if (Handlers.TryGetValue(msgType, out var responseType))
        {
            var constructor = responseType.GetConstructor(new Type[] { });

            if (constructor != null) return (IPacketHandler)constructor.Invoke(new object[] { });
        }
        else
        {
            Log.Warning("Packet {ada} not yet implemented", msgType);
            return null;
        }

        return null;
    }
    
    public interface IPacketHandler
    {
        Task HandleAsync(Packet packet);
        
    }
    

}