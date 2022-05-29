using Google.Protobuf;
using Lemonade.Net.Protocol;
using Lemonade.Utils;
// using Serilog;
// using System.IO;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace Lemonade.Packet
{

    //this should theoretically work
    public class Packet
    {
        public const int HeaderLen = 8;
        public const int MagicLen = 2;
        public static readonly ushort[] Magic = { 0x4567, 0x89AB };

        //the only prupose of this is to be a vehicle for some random protobuf data

        public IMessage Obj { get; set; }

        public PacketOpcodes Type;

        public PacketHead MetaData;
        private ushort _metaDataLen = 0xFFFF;

        public byte[] Data; // The only purpose of this field now is to parse unknown protobuf messages;
        private uint _dataLen = 0xFFFFFFFF; // The only purpose of this field now is to parse unknown protobuf messages;

        public Packet(PacketOpcodes msgType = PacketOpcodes.Invalid) { Type = msgType; }
        public Packet(byte[] incomingData, bool noCopy = false) { Decode(noCopy ? incomingData : incomingData.ToArray()); }

        public Packet(ByteString data)
        {
            this.Data = data.ToByteArray();
        }
        public int Length
        {
            get
            {
                if (MetaData == null) _metaDataLen = 0;
                return HeaderLen + MagicLen * 2 +
                (MetaData == null ? 0 : MetaData.CalculateSize()) +
                GetDataLen();
            }
        }
        public virtual int GetDataLen()
        {
            return Data == null ? 0 : Data.Length;
        }
        // +---------+---------+-------------------+-------------+------------------+------------------+---------+
        // |  Magic  |  CmdId  | PacketHead Length | Data Length | PacketHead bytes |    Data bytes    |  Magic  |
        // +---------+---------+-------------------+-------------+------------------+------------------+---------+
        // | 2 bytes | 2 bytes | 2 bytes           | 4 bytes     | size = 3rd field | size = 4th field | 2 bytes |
        // +---------+---------+-------------------+-------------+------------------+------------------+---------+
        // If there are any questions, please redirect to @LADIlib
        public void Encode(byte[] buffer, bool setFinalMagic = true)
        {
            // 2+           Magic
            buffer.SetUInt16(0, Magic[0], true);
            // 2+           CmdId
            buffer.SetUInt16(2, (ushort)Type, true);
            // 2+           PacketHead Length
            buffer.SetUInt16(4, _metaDataLen != 0xFFFF ? _metaDataLen : (ushort)MetaData.CalculateSize(), true);

            // 4+           Data Length
            buffer.SetUInt32(6, _dataLen != 0xFFFFFFFF ? _dataLen : (uint)GetDataLen(), true);


            // 2+           PacketHead Length
            // 4+           Data Length
            // 0+           PacketHead bytes | Skip
            // Data.length  Data bytes
            // +2;          Magic


            // +2;          Magic
            if (setFinalMagic)
                buffer.SetUInt16(buffer.Length - 2, Magic[1], true);
        }


        protected virtual void EncodeData(ref byte[] buffer, int offset)
        {
            Data.CopyTo(buffer, offset);
        }

        private void Decode(byte[] buffer)
        {
            if (buffer.Length < 4)
                throw new ArgumentException("Packet is too small to be valid", "buffer");

            if (buffer.GetUInt16(0, true) != Magic[0] || buffer.GetUInt16(buffer.Length - 2, true) != Magic[1])
                throw new ArgumentException("Invalid packet magic", "buffer");

            Type = (PacketOpcodes)buffer.GetUInt16(2, true);

            _metaDataLen = buffer.GetUInt16(4, true);
            _dataLen = buffer.GetUInt32(6, true);

            // If there's more than one packet on a message
            // Should consider using a RecyclableMemoryStream instead of byte[] for tracking position
            if (buffer.Length != MagicLen * 2 + HeaderLen + _metaDataLen + _dataLen)
                throw new ArgumentException("Packet is invalid or buffer contains more than one packet", "buffer");

            int offset = MagicLen + HeaderLen;
            MetaData = PacketHead.Parser.ParseFrom(buffer, offset, _metaDataLen);

            offset += _metaDataLen;

            DecodeData(buffer, offset, _dataLen);
        }
        protected virtual void DecodeData(byte[] buffer, int offset, uint dataLength)
        {
            // data = buffer[offset..(offset + (int)dataLen)];
            Data = buffer.AsSpan().Slice(offset, (int)dataLength).ToArray();

        }


        public virtual byte[] AsBytes(bool includeData = true)
        {
            //allocate a byte array
            var ret = new byte[includeData ? Length : (HeaderLen + MagicLen)];

            //write the header and magic ending

            Encode(ret, includeData);


            if (includeData)
            {
                //write the meta data 
                if (MetaData != null) MetaData.ToByteArray().CopyTo(ret, MagicLen + HeaderLen);

                //write the data in the space left between the header and magic
                if (Data != null) EncodeData(ref ret, MagicLen + HeaderLen + (MetaData != null ? MetaData.CalculateSize() : 0));
            }
            return ret;
        }

        public override string ToString()
        {
            // We are using JsonConvert to sacrifice performance for a better idented Debug Output
            var metaData = JsonConvert.DeserializeObject(MetaData.ToString());

            return $"msgType : {Type.ToString()}\nHead :\n{JsonConvert.SerializeObject(metaData, Formatting.Indented)}\nBody :\n{DumpBody()}";
        }

        protected virtual string DumpBody() { return ""; }
    }
}