﻿

using System;
using System.Linq;

// This class contains an implementation of miHoYo's awful XOR & mt64 based
// cryptography routines. Truly awful. I wonder if the developers suffered from terminal stupidity.
//- ysfreedom devs

namespace Lemonade.Utils
{
    //thank you so much ysfreedom i am in NOWAY rewriting this bullshit
    //i agree

    public class MTKey
    {
        public static readonly MTKey NoOp = new MTKey(new byte[4096]);
        public const int LEN = 4096;
        public byte[] Bytes;

        public MTKey()
        {
            Bytes = new byte[LEN];
        }

        public MTKey(byte[] buffer)
        {
            if (buffer.Length != LEN)
                throw new ArgumentException("Key must be 4096 bytes", "buffer");
            Bytes = buffer.ToArray();
        }

        public MTKey(ulong seed)
        {
            Bytes = MiHoYoKeyGenerator.GenerateKey(seed);
        }

        public void Crypt(byte[] buffer)
        {
            for (int i = 0; i < buffer.Length; i++)
                buffer[i] ^= Bytes[i % LEN];
        }

        public static MTKey FromBase64(string text)
        {
            return new MTKey(Convert.FromBase64String(text));
        }

        public static void MersenneKeyGen(byte[] buf, ulong seed)
        {

            ulong[] state = new ulong[624];
            ulong v7 = 1, v9 = 0x137, v3;
            state[0] = seed;

            ulong[] pv1 = state;
            int pv1idx = 0;
            do
            {
                pv1idx++;
                seed = (seed ^ seed >> 0x3e) * 0x5851f42d4c957f2d + v7;
                v7++;
                pv1[pv1idx] = seed;
                v9--;
            } while (v9 != 0);

            int v5 = 0;
            int pv6idx = 2;
            do
            {
                int v8 = (v5 + 0x138) % 0x270;
                if (v8 == 0x138)
                {
                    v7 = 0x138;
                    pv1idx = 0x9c;
                    do
                    {
                        v3 = (ulong)(((uint)state[pv1idx - 0x9b] ^ (uint)state[pv1idx - 0x9c]) & 0x7fffffff) ^ state[pv1idx - 0x9c];
                        state[pv1idx + 0x9c] = (ulong)(int)-((uint)v3 & 1) & 0xb5026f5aa96619e9 ^ v3 >> 1 ^ state[pv1idx];
                        v7--;
                        pv1idx++;
                    } while (v7 != 0);
                }
                else if (v8 == 0)
                {
                    v7 = 0x9c;
                    pv1idx = 0x1d4;
                    do
                    {
                        v3 = (ulong)(((uint)state[pv1idx - 0x9b] ^ (uint)state[pv1idx - 0x9c]) & 0x7fffffff) ^ state[pv1idx - 0x9c];
                        state[pv1idx - 0x1d4] = (ulong)(int)-((uint)v3 & 1) & 0xb5026f5aa96619e9 ^ v3 >> 1 ^ state[pv1idx];
                        v7--;
                        pv1idx++;
                    } while (v7 != 0);

                    v7 = 0x9b;
                    pv1idx = 0;
                    do
                    {
                        v3 = (ulong)(((uint)state[pv1idx + 0x1d5] ^ (uint)state[pv1idx + 0x1d4]) & 0x7fffffff) ^ state[pv1idx + 0x1d4];
                        state[pv1idx + 0x9c] = (ulong)(int)-((uint)v3 & 1) & 0xb5026f5aa96619e9 ^ v3 >> 1 ^ state[pv1idx];
                        v7--;
                        pv1idx++;
                    } while (v7 != 0);
                }

                v5++;
                v3 = state[v8] ^ state[v8] >> 0x1d & 0x555555555;
                v3 = v3 ^ (v3 & 0x38eb3ffff6d3) << 0x11;
                ulong v2 = v3 ^ (v3 & 0xffffffffffffbf77) << 0x25;
                ulong v4 = v2 >> 0x2b ^ v2;
                buf[pv6idx + 5] = (byte)v4;
                buf[pv6idx - 2] = (byte)(v2 >> 0x38);
                buf[pv6idx - 1] = (byte)(v2 >> 0x30);
                buf[pv6idx + 0] = (byte)(v2 >> 0x28);
                buf[pv6idx + 1] = (byte)(v2 >> 0x20);
                buf[pv6idx + 2] = (byte)(v3 >> 0x18);
                buf[pv6idx + 3] = (byte)(v4 >> 0x10);
                buf[pv6idx + 4] = (byte)(v4 >> 0x08);
                pv6idx = pv6idx + 8;
            } while (v5 < 0x200);

        }

    }
    public class MiHoYoKeyGenerator
    {
        public static byte[] GenerateKey(ulong source)
        {
            MiHoYoKeyGenerator.MT19937_64 mt1993764_1 = new MiHoYoKeyGenerator.MT19937_64();
            mt1993764_1.Initialize(source);
            MiHoYoKeyGenerator.MT19937_64 mt1993764_2 = new MiHoYoKeyGenerator.MT19937_64();
            mt1993764_2.Initialize(mt1993764_1.GenerateULong());
            long num = (long)mt1993764_2.GenerateULong();
            byte[] key = new byte[4096];
            for (int index1 = 0; index1 < key.Length; index1 += 8)
            {
                byte[] bytes = BitConverter.GetBytes(MiHoYoKeyGenerator.SwapBytes(mt1993764_2.GenerateULong()));
                for (int index2 = index1; index2 < index1 + 8; ++index2)
                    key[index2] = bytes[index2 % 8];
            }
            return key;
        }

        //literally just does the same thing as System.Net.IPAddress.NetworkToHostOrder()
        public static ulong SwapBytes(ulong x)
        {
            x = x >> 32 | x << 32;
            x = (x & 0xFFFF0000FFFF0000UL) >> 16 | (ulong)(((long)x & 0xFFFF0000FFFFL) << 16);
            return (x & 0xFF00FF00FF00FF00UL) >> 8 | (ulong)(((long)x & 0xFF00FF00FF00FFL) << 8);
        }

        private class MT19937_64
        {
            public const int N = 312;
            private const int M = 156;
            private const ulong MatrixA = 13043109905998158313;
            private readonly ulong[] mt = new ulong[624];
            private uint mti = 312;

            public void Initialize(ulong[] src, uint mtiSrc = 0)
            {
                if (src.Length != this.mt.Length)
                    throw new ArgumentException("NN", nameof(src));
                Array.Copy((Array)src, 0, (Array)this.mt, 0, src.Length);
                this.mti = mtiSrc;
            }

            public void Initialize(ulong seed)
            {
                ulong[] mt = this.mt;
                mt[0] = seed;
                for (this.mti = 1U; this.mti < 312U; ++this.mti)
                    mt[(int)this.mti] = (ulong)(6364136223846793005L * ((long)mt[(int)this.mti - 1] ^ (long)(mt[(int)this.mti - 1] >> 62))) + (ulong)this.mti;
            }

            public ulong GetMag01(ulong val) => ((long)val & 1L) == 0L ? 0UL : 13043109905998158313UL;

            public void Regenerate1()
            {
                for (int index1 = 312; index1 < 624; ++index1)
                {
                    int index2 = index1 - 312;
                    ulong val = this.mt[index2] ^ (ulong)(((long)this.mt[index2 + 1] ^ (long)this.mt[index2]) & (long)int.MaxValue);
                    this.mt[index1] = this.GetMag01(val) ^ val >> 1 ^ this.mt[index1 - 156];
                }
            }

            public void Regenerate2()
            {
                int index1;
                for (index1 = 0; index1 < 156; ++index1)
                {
                    int index2 = index1 + 312;
                    ulong val = this.mt[index2] ^ (ulong)(((long)this.mt[index2 + 1] ^ (long)this.mt[index2]) & (long)int.MaxValue);
                    this.mt[index1] = this.GetMag01(val) ^ val >> 1 ^ this.mt[index1 + 312 + 156];
                }
                for (; index1 < 311; ++index1)
                {
                    int index3 = index1 + 312;
                    ulong val = this.mt[index3] ^ (ulong)(((long)this.mt[index3 + 1] ^ (long)this.mt[index3]) & (long)int.MaxValue);
                    this.mt[index1] = this.GetMag01(val) ^ val >> 1 ^ this.mt[index1 - 156];
                }
                ulong val1 = this.mt[index1 + 312] ^ (ulong)(((long)this.mt[0] ^ (long)this.mt[index1 + 312]) & (long)int.MaxValue);
                this.mt[index1] = this.GetMag01(val1) ^ val1 >> 1 ^ this.mt[155];
                this.mti = 0U;
            }

            public ulong GenerateULong()
            {
                if (this.mti == 312U)
                    this.Regenerate1();
                else if (624U <= this.mti)
                    this.Regenerate2();
                ulong num1 = this.mt[(int)this.mti++];
                ulong num2 = (ulong)((((long)(num1 >> 29) & 22906492245L ^ (long)num1) & 62583042209491L) << 17 ^ (long)(num1 >> 29) & 22906492245L) ^ num1;
                return (ulong)(((long)num2 & -16521L) << 37) ^ num2 ^ ((ulong)(((long)num2 & -16521L) << 37) ^ num2) >> 43;
            }
        }
    }
}