using System;

namespace Lemonade
{
    internal class MT19937
    {
        public static byte[] GenerateKey(ulong source)
        {
            MT19937.MT19937_64 mt1993764_1 = new MT19937.MT19937_64();
            mt1993764_1.Initialize(source);
            MT19937.MT19937_64 mt1993764_2 = new MT19937.MT19937_64();
            mt1993764_2.Initialize(mt1993764_1.GenerateULong());
            long num = (long)mt1993764_2.GenerateULong();
            byte[] key = new byte[4096];
            for (int index1 = 0; index1 < key.Length; index1 += 8)
            {
                byte[] bytes = BitConverter.GetBytes(MT19937.SwapBytes(mt1993764_2.GenerateULong()));
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
                Array.Copy(src, 0, this.mt, 0, src.Length);
                this.mti = mtiSrc;
            }

            public void Initialize(ulong seed)
            {
                ulong[] mt = this.mt;
                mt[0] = seed;
                for (this.mti = 1U; this.mti < 312U; ++this.mti)
                    mt[(int)this.mti] = (ulong)(6364136223846793005L * ((long)mt[(int)this.mti - 1] ^ (long)(mt[(int)this.mti - 1] >> 62))) + this.mti;
            }

            public ulong GetMag01(ulong val) => ((long)val & 1L) == 0L ? 0UL : 13043109905998158313UL;

            public void Regenerate1()
            {
                for (int index1 = 312; index1 < 624; ++index1)
                {
                    int index2 = index1 - 312;
                    ulong val = this.mt[index2] ^ (ulong)(((long)this.mt[index2 + 1] ^ (long)this.mt[index2]) & int.MaxValue);
                    this.mt[index1] = this.GetMag01(val) ^ val >> 1 ^ this.mt[index1 - 156];
                }
            }

            public void Regenerate2()
            {
                int index1;
                for (index1 = 0; index1 < 156; ++index1)
                {
                    int index2 = index1 + 312;
                    ulong val = this.mt[index2] ^ (ulong)(((long)this.mt[index2 + 1] ^ (long)this.mt[index2]) & int.MaxValue);
                    this.mt[index1] = this.GetMag01(val) ^ val >> 1 ^ this.mt[index1 + 312 + 156];
                }
                for (; index1 < 311; ++index1)
                {
                    int index3 = index1 + 312;
                    ulong val = this.mt[index3] ^ (ulong)(((long)this.mt[index3 + 1] ^ (long)this.mt[index3]) & int.MaxValue);
                    this.mt[index1] = this.GetMag01(val) ^ val >> 1 ^ this.mt[index1 - 156];
                }
                ulong val1 = this.mt[index1 + 312] ^ (ulong)(((long)this.mt[0] ^ (long)this.mt[index1 + 312]) & int.MaxValue);
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
