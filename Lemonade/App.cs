using System.Windows;
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;

namespace Lemonade;

public class App
{

    
    public static void Main()
    {
        Sniffer sniffer = new Sniffer();
        
        sniffer.Start();

        var running = true;
        Console.CancelKeyPress += async delegate(object sender, ConsoleCancelEventArgs args)
        {
            sniffer.Close();
            Console.WriteLine("Yo!");

            
            Console.WriteLine("Done: press any key to close.");
            Console.ReadLine();
            running = false;
            args.Cancel = true;


        };

        while (running)
        {
            Task.Delay(1000);
        }
        
        
    }
    
}