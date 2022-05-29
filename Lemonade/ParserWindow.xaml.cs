using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lemonade.Utils;
using Serilog;

namespace Lemonade;

public partial class ParserWindow: Window
{
    public ParserWindow()
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
            TimeCs.Close();
            args.Cancel = true;
            Console.ReadKey();






        };

        SpinWait.SpinUntil(() => !running);

            
    }
    private void Window_Deactivated(object sender, EventArgs e)
    {
        Window window = (Window)sender;
        window.Topmost = AlwaysOnTop.IsChecked;
    }

    private void Window_Activated(object sender, EventArgs e)
    {
        Window window = (Window)sender;
        window.Topmost = AlwaysOnTop.IsChecked;
    }

    private void Window_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.LeftButton == MouseButtonState.Pressed)
        {
            DragMove();
        }
    }

    private void Window_StateChanged(object sender, EventArgs e)
    {
        if (WindowState == WindowState.Maximized)
        {
            WindowState = WindowState.Normal;
        }
    }

    private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {
        //PcapHandler.LiveCaptureWaiter.Set();
        Environment.Exit(Environment.ExitCode); //to kill all threads
    }

    private void Exit_Click(object sender, RoutedEventArgs e)
    {
    }

    private void Minimize_Click(object sender, RoutedEventArgs e) => WindowState = WindowState.Minimized;

    private void ClearEntityList_Click(object sender, RoutedEventArgs e)
    {
    }

    private void ResetEntityDamage_Click(object sender, RoutedEventArgs e)
    {

    }
}
