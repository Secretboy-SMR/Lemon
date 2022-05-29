﻿using PacketDotNet;
using Serilog;
using SharpPcap;
using SharpPcap.LibPcap;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading;



namespace Lemonade.Sniffer;



public class Sniffer
{

    private Handler _handler;

    private LibPcapLiveDevice _pcapDevice;

    public bool Running;

    private Thread _workingThread;

    private ConcurrentQueue<RawCapture> _packetQueue;

    public Sniffer()
    {
        _packetQueue = new();
    }

    public void OnPacketArrival(object sender, PacketCapture e)
    {

        _packetQueue.Enqueue(e.GetPacket());
    }

    public void Start()
    {
        Log.Information("SharpPcap {0}, StartLiveCapture", (object)Pcap.SharpPcapVersion);
        _handler = new Handler();
        Running = true;
        SharpPcapCapturer();
        _workingThread = new Thread(ProcessPacketQueue);
        _workingThread.Name = "ProcessPacketQueue";
        _workingThread.Start();

    }

    public void SharpPcapCapturer()
    {
        _pcapDevice = GetPcapDevice();

        _pcapDevice.OnPacketArrival += OnPacketArrival;
        Console.WriteLine();
        int readTimeout = 1000;
        _pcapDevice.Open(DeviceModes.Promiscuous | DeviceModes.DataTransferUdp | DeviceModes.NoCaptureLocal, readTimeout);
        _pcapDevice.Filter = "udp portrange 22101-22102";

        _pcapDevice.StartCapture();


        Log.Information("-- Listening on {0} {1}, hit 'Control + C' to stop...", (object)_pcapDevice.Name, (object)_pcapDevice.Description);



    }


    public void ProcessPacketQueue()
    {
        while (Running)
        {
            try
            {


                if (_packetQueue.TryDequeue(out var rawPacket))
                {
                    _handler.HandleRawCapture(rawPacket);
                }
                else
                {
                    Thread.Sleep(10);
                }

            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                Thread.Sleep(10);
            }

        }
    }
    public void Close()
    {
        _pcapDevice.StopCapture();
        Log.Information("-- Capture stopped.");
        Log.Information(_pcapDevice.Statistics.ToString());

        Running = false;

        _workingThread.Join();

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