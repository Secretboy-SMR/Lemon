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
        public const int HEADER_LEN = 8;
        public const int MAGIC_LEN = 2;
        public static readonly ushort[] MAGIC = { 0x4567, 0x89AB };

        //the only prupose of this is to be a vehicle for some random protobuf data

        public IMessage obj { get; set; }
        public PacketOpcodes Type { get { return type; } }

        public PacketOpcodes type;

        public PacketHead metaData;
        private ushort metaDataLen = 0xFFFF;

        public byte[] data; // The only purpose of this field now is to parse unknown protobuf messages;
        private uint dataLen = 0xFFFFFFFF; // The only purpose of this field now is to parse unknown protobuf messages;

        public Packet(PacketOpcodes msgType = PacketOpcodes.Invalid) { type = msgType; }
        public Packet(byte[] incomingData, bool noCopy = false) { Decode(noCopy ? incomingData : incomingData.ToArray()); }

        public Packet(ByteString data)
        {
            this.data = data.ToByteArray();
        }
        public int Length
        {
            get
            {
                if (metaData == null) metaDataLen = 0;
                return HEADER_LEN + MAGIC_LEN * 2 +
                (metaData == null ? 0 : metaData.CalculateSize()) +
                GetDataLen();
            }
        }
        public virtual int GetDataLen()
        {
            return data == null ? 0 : data.Length;
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
            buffer.SetUInt16(0, MAGIC[0], true);
            // 2+           CmdId
            buffer.SetUInt16(2, (ushort)type, true);
            // 2+           PacketHead Length
            buffer.SetUInt16(4, metaDataLen != 0xFFFF ? metaDataLen : (ushort)metaData.CalculateSize(), true);

            // 4+           Data Length
            buffer.SetUInt32(6, dataLen != 0xFFFFFFFF ? dataLen : (uint)GetDataLen(), true);


            // 2+           PacketHead Length
            // 4+           Data Length
            // 0+           PacketHead bytes | Skip
            // Data.length  Data bytes
            // +2;          Magic


            // +2;          Magic
            if (setFinalMagic)
                buffer.SetUInt16(buffer.Length - 2, MAGIC[1], true);
        }


        protected virtual void EncodeData(ref byte[] buffer, int offset)
        {
            data.CopyTo(buffer, offset);
        }

        private void Decode(byte[] buffer)
        {
            if (buffer.Length < 4)
                throw new ArgumentException("Packet is too small to be valid", "buffer");

            if (buffer.GetUInt16(0, true) != MAGIC[0] || buffer.GetUInt16(buffer.Length - 2, true) != MAGIC[1])
                throw new ArgumentException("Invalid packet magic", "buffer");

            type = (PacketOpcodes)buffer.GetUInt16(2, true);

            metaDataLen = buffer.GetUInt16(4, true);
            dataLen = buffer.GetUInt32(6, true);

            // If there's more than one packet on a message
            // Should consider using a RecyclableMemoryStream instead of byte[] for tracking position
            if (buffer.Length != MAGIC_LEN * 2 + HEADER_LEN + metaDataLen + dataLen)
                throw new ArgumentException("Packet is invalid or buffer contains more than one packet", "buffer");

            int offset = MAGIC_LEN + HEADER_LEN;
            metaData = PacketHead.Parser.ParseFrom(buffer, offset, metaDataLen);

            offset += metaDataLen;

            DecodeData(buffer, offset, dataLen);
        }
        protected virtual void DecodeData(byte[] buffer, int offset, uint dataLength)
        {
            // data = buffer[offset..(offset + (int)dataLen)];
            data = buffer.AsSpan().Slice(offset, (int)dataLength).ToArray();

        }


        public virtual byte[] AsBytes(bool includeData = true)
        {
            //allocate a byte array
            var ret = new byte[includeData ? Length : (HEADER_LEN + MAGIC_LEN)];

            //write the header and magic ending

            Encode(ret, includeData);


            if (includeData)
            {
                //write the meta data 
                if (metaData != null) metaData.ToByteArray().CopyTo(ret, MAGIC_LEN + HEADER_LEN);

                //write the data in the space left between the header and magic
                if (data != null) EncodeData(ref ret, MAGIC_LEN + HEADER_LEN + (metaData != null ? metaData.CalculateSize() : 0));
            }
            return ret;
        }

        public override string ToString()
        {
            // We are using JsonConvert to sacrifice performance for a better idented Debug Output
            var _metaData = JsonConvert.DeserializeObject(metaData.ToString());

            return $"msgType : {type.ToString()}\nHead :\n{JsonConvert.SerializeObject(_metaData, Formatting.Indented)}\nBody :\n{DumpBody()}";
        }

        protected virtual string DumpBody() { return ""; }
    }
}