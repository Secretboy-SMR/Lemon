using Lemonade.Utils;
using Serilog;
using System;
using System.Threading;


namespace Lemonade;

public class LemonadeMain
{

    public static void Main()
    {

        Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.Console().CreateLogger();


        var sniffer = new Sniffer.Sniffer();


        sniffer.Start();



        var running = true;

        Console.CancelKeyPress += delegate (object sender, ConsoleCancelEventArgs args)
        {
            sniffer.Close();
            Log.CloseAndFlush();





            running = false;
            TimeCs.Close();
            args.Cancel = true;
            
            Console.WriteLine("Done! Closing...");

        };

        SpinWait.SpinUntil(() => !running);


    }

}