using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using PacketDotNet;
using SharpPcap;
using SharpPcap.LibPcap;
using Serilog;

namespace Lemonade;



public class Sniffer
{

    private Handler handler;

    private LibPcapLiveDevice pcapDevice;

    public bool running;

    private Thread WorkingThread;

    private Queue<RawCapture> PacketQueue;
    
    public Sniffer()
    {

    }

    public void onPacketArrival(object sender, PacketCapture e)
    {
        Console.WriteLine("ehehe");
        PacketQueue.Enqueue(e.GetPacket());
    }

    public void Start()
    {
        Log.Information("SharpPcap {0}, StartLiveCapture", (object)Pcap.SharpPcapVersion);
        handler = new Handler();
        running = true;
        SharpPcapCapturer();
        WorkingThread = new Thread(ProcessPacketQueue);
        WorkingThread.Name = "ProcessPacketQueue";
        WorkingThread.Start();

    }

    public void SharpPcapCapturer()
    {
        pcapDevice = GetPcapDevice();
        
        pcapDevice.OnPacketArrival += onPacketArrival;
        Console.WriteLine();
        int read_timeout = 1000;
        pcapDevice.Open(DeviceModes.Promiscuous | DeviceModes.DataTransferUdp | DeviceModes.NoCaptureLocal, read_timeout);
        pcapDevice.Filter = "udp portrange 22101-22102";

        pcapDevice.StartCapture();

            
        Console.WriteLine("-- Listening on {0} {1}, hit 'Control + C' to stop...", (object) pcapDevice.Name, (object) pcapDevice.Description);

        
        
    }


    public void ProcessPacketQueue()
    {
        while (running)
        {
            try
            {
                var rawPacket = PacketQueue.Dequeue();
                if (rawPacket != null)
                {
                    //handle it
                }
                else
                {
                    Thread.Sleep(100);
                }

            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                Thread.Sleep(100);
            }

        }
    }
    public void Close()
    {
        pcapDevice.StopCapture();
        Console.WriteLine("-- Capture stopped.");
        Console.WriteLine(pcapDevice.Statistics.ToString());

        running = false;

        WorkingThread.Join();
        
        Console.WriteLine("done cleaning up");
    }

    
    // taken from devove's chrome.dll
    internal static LibPcapLiveDevice GetPcapDevice()
    {
        NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
        foreach (PcapInterface allPcapInterface in PcapInterface.GetAllPcapInterfaces())
        {
            string friendlyName = allPcapInterface.FriendlyName ?? string.Empty;
            if (!friendlyName.ToLower().Contains("loopback") && !(friendlyName == "any") && !(friendlyName == "virbr0-nic"))
            {
                NetworkInterface networkInterface = networkInterfaces.FirstOrDefault(ni => ni.Name == friendlyName);
                if ((networkInterface != null ? (networkInterface.OperationalStatus != OperationalStatus.Up ? 1 : 0) : 1) == 0)
                {
                    using (LibPcapLiveDevice device = new LibPcapLiveDevice(allPcapInterface))
                    {
                        LinkLayers linkType;
                        try
                        {
                            device.Open();
                            linkType = device.LinkType;
                        }
                        catch (PcapException ex)
                        {
                            Console.WriteLine(ex);
                            continue;
                        }
                        if (linkType == LinkLayers.Ethernet)
                            return device;
                    }
                }
            }
        }
        throw new InvalidOperationException("No ethernet pcap supported devices found, are you running as a user with access to adapters (root on Linux)?");
    }
}