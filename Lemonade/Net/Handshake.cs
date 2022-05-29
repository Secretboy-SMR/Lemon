using Lemonade.Utils;
using System;

namespace Lemonade.Net;

public class Handshake
{
    public static readonly uint[] MagicConnect = { 0xFF, 0xFFFFFFFF };
    public static readonly uint[] MagicSendBackConv = { 0x145, 0x14514545 };
    public static readonly uint[] MagicDisconnect = { 0x194, 0x19419494 };
    public const int Len = 20;

    public uint Magic1;
    public ulong Conv;

    public uint Data;
    public uint Magic2;

    public Handshake() { }
    public Handshake(uint[] magic, ulong conv = 0, uint data = 0)
    {
        Magic1 = magic[0];
        Conv = conv;
        Data = data;
        Magic2 = magic[1];
    }

    public void Encode(byte[] buffer)
    {
        buffer.SetUInt32(0, Magic1, true);
        buffer.SetUInt64(4, Conv, true);
        buffer.SetUInt32(12, Data, true);
        buffer.SetUInt32(16, Magic2, true);
    }

    public void Decode(byte[] buffer, uint[] verifyMagic = null)
    {
        if (buffer.Length < Len)
            throw new ArgumentException("Handshake packet too small", "buffer");

        Magic1 = buffer.GetUInt32(0, true);
        Conv = buffer.GetUInt64(4, true);
        Data = buffer.GetUInt32(12, true);
        Magic2 = buffer.GetUInt32(16, true);

        if (verifyMagic != null)
        {
            if (Magic1 != verifyMagic[0] || Magic2 != verifyMagic[1])
                throw new ArgumentException("Invalid handshake packet", "buffer");
        }
    }

    public byte[] AsBytes()
    {
        var ret = new byte[20];
        Encode(ret);
        return ret;
    }
}
