
using System;
using System.Net;
using System.Text;


namespace Lemonade.Utils
{

    public static class ByteArray
    {
        public static void SetUInt16(this byte[] arr, int offset, ushort value, bool bigEndian = false)
        {
            if (bigEndian) value = (ushort)IPAddress.HostToNetworkOrder((short)value);
            arr[offset + 0] = (byte)(value & 0xFF);
            arr[offset + 1] = (byte)((value & 0xFF00) >> 8);
        }

        public static void SetUInt32(this byte[] arr, int offset, uint value, bool bigEndian = false)
        {
            if (bigEndian) value = (uint)IPAddress.HostToNetworkOrder((int)value);
            arr[offset + 0] = (byte)(value & 0xFF);
            arr[offset + 1] = (byte)((value & 0xFF00) >> 8);
            arr[offset + 2] = (byte)((value & 0xFF0000) >> 16);
            arr[offset + 3] = (byte)((value & 0xFF000000) >> 24);
        }

        public static void SetUInt64(this byte[] arr, int offset, UInt64 value, bool bigEndian = false)
        {
            if (bigEndian) value = (UInt64)IPAddress.HostToNetworkOrder((Int64)value);
            arr[offset + 0] = (byte)(value & 0xFF);
            arr[offset + 1] = (byte)((value & 0xFF00) >> 8);
            arr[offset + 2] = (byte)((value & 0xFF0000) >> 16);
            arr[offset + 3] = (byte)((value & 0xFF000000) >> 24);
            arr[offset + 4] = (byte)((value & 0xFF00000000) >> 32);
            arr[offset + 5] = (byte)((value & 0xFF0000000000) >> 40);
            arr[offset + 6] = (byte)((value & 0xFF000000000000) >> 48);
            arr[offset + 7] = (byte)((value & 0xFF00000000000000) >> 54);

        }

        public static ushort GetUInt16(this byte[] arr, int offset, bool bigEndian = false)
        {
            ushort ret = (ushort)(arr[offset + 0] | arr[offset + 1] << 8);
            if (bigEndian) ret = (ushort)IPAddress.NetworkToHostOrder((short)ret);
            return ret;
        }

        public static uint GetUInt32(this byte[] arr, int offset, bool bigEndian = false)
        {
            uint ret = arr[offset + 0] | (uint)arr[offset + 1] << 8 |
                         (uint)arr[offset + 2] << 16 | (uint)arr[offset + 3] << 24;
            if (bigEndian) ret = (uint)IPAddress.NetworkToHostOrder((int)ret);
            return ret;
        }

        public static UInt64 GetUInt64(this byte[] arr, int offset, bool bigEndian = false)
        {
            int pos = offset;


            UInt64 ret = ((UInt64)arr[pos + 0] << 00) | ((UInt64)arr[pos + 1] << 08)
                                                      | ((UInt64)arr[pos + 2] << 16) | ((UInt64)arr[pos + 3] << 24)
                                                      | ((UInt64)arr[pos + 4] << 32) | ((UInt64)arr[pos + 5] << 40)
                                                      | ((UInt64)arr[pos + 6] << 48) | ((UInt64)arr[pos + 7] << 56);

            if (bigEndian) ret = (UInt64)IPAddress.NetworkToHostOrder((long)ret);

            return ret;


        }

        public static string HexDump(this byte[] bytes, int bytesPerLine = 16)
        {
            if (bytes == null) return "<null>";
            int bytesLength = bytes.Length;

            char[] HexChars = "0123456789ABCDEF".ToCharArray();

            int firstHexColumn =
                  8                   // 8 characters for the address
                + 3;                  // 3 spaces

            int firstCharColumn = firstHexColumn
                + bytesPerLine * 3       // - 2 digit for the hexadecimal value and 1 space
                + (bytesPerLine - 1) / 8 // - 1 extra space every 8 characters from the 9th
                + 2;                  // 2 spaces 

            int lineLength = firstCharColumn
                + bytesPerLine           // - characters to show the ascii value
                + Environment.NewLine.Length; // Carriage return and line feed (should normally be 2)

            char[] line = (new string(' ', lineLength - Environment.NewLine.Length) + Environment.NewLine).ToCharArray();
            int expectedLines = (bytesLength + bytesPerLine - 1) / bytesPerLine;
            StringBuilder result = new StringBuilder(expectedLines * lineLength);

            result.Append($"HexDump - Length : {bytes.Length}\n");

            for (int i = 0; i < bytesLength; i += bytesPerLine)
            {
                line[0] = HexChars[i >> 28 & 0xF];
                line[1] = HexChars[i >> 24 & 0xF];
                line[2] = HexChars[i >> 20 & 0xF];
                line[3] = HexChars[i >> 16 & 0xF];
                line[4] = HexChars[i >> 12 & 0xF];
                line[5] = HexChars[i >> 8 & 0xF];
                line[6] = HexChars[i >> 4 & 0xF];
                line[7] = HexChars[i >> 0 & 0xF];

                int hexColumn = firstHexColumn;
                int charColumn = firstCharColumn;

                for (int j = 0; j < bytesPerLine; j++)
                {
                    if (j > 0 && (j & 7) == 0) hexColumn++;
                    if (i + j >= bytesLength)
                    {
                        line[hexColumn] = ' ';
                        line[hexColumn + 1] = ' ';
                        line[charColumn] = ' ';
                    }
                    else
                    {
                        byte b = bytes[i + j];
                        line[hexColumn] = HexChars[b >> 4 & 0xF];
                        line[hexColumn + 1] = HexChars[b & 0xF];
                        line[charColumn] = b < 32 ? '�' : (char)b;
                    }
                    hexColumn += 3;
                    charColumn++;
                }
                result.Append(line);
            }
            return result.ToString();
        }
    }
}

