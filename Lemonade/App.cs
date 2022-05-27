using Lemonade.Utils;
using Serilog;
using System;
using System.Threading;


namespace Lemonade;

public class App
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


            Console.WriteLine("Done! Press any key to close.");


            running = false;
            MonotonicTime.Close();
            args.Cancel = true;
            Console.ReadKey();






        };

        SpinWait.SpinUntil(() => !running);


    }

}