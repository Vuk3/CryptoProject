using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_Projekat_18036.PomocnaSredstva
{
    class MD5
    {
        public static string MD5Hash(byte[] prviFajlBajtovi)
        {

            int[] r = new int[64] { 7, 12, 17, 22, 7, 12, 17, 22, 7, 12, 17, 22, 7, 12, 17, 22, 5, 9, 14, 20, 5, 9, 14, 20, 5, 9, 14, 20, 5, 9, 14, 20, 4, 11, 16, 23, 4, 11, 16, 23, 4, 11, 16, 23, 4, 11, 16, 23, 6, 10, 15, 21, 6, 10, 15, 21, 6, 10, 15, 21, 6, 10, 15, 21 };
            uint[] k = new uint[64];

            string h0Hexa;
            string h1Hexa;
            string h2Hexa;
            string h3Hexa;

            for (int i = 0; i < 64; i++)
                k[i] = (uint)Math.Floor(Math.Abs(Math.Sin(i + 1)) * (Math.Pow(2, 32)));

            uint h0 = 0x67452301;
            uint h1 = 0xEFCDAB89;
            uint h2 = 0x98BADCFE;
            uint h3 = 0x10325476;

            var prviFajlBitovi = new BitArray(prviFajlBajtovi);

            int prviFajlBitoviDuzina = prviFajlBitovi.Length;
            //preprocesiranje

            if (prviFajlBitovi.Length % 512 != 0)
            {

                int pom1 = prviFajlBitoviDuzina;

                if (prviFajlBitovi.Length >= 447)
                {
                    prviFajlBitovi.Length += (512 - prviFajlBitovi.Length % 512 + 512);
                }
                else
                {
                    prviFajlBitovi.Length += (512 - prviFajlBitovi.Length % 512);
                }
                prviFajlBitovi[pom1++] = true;
                while (pom1 % 512 != 448)
                {
                    prviFajlBitovi[pom1++] = false;
                }

                byte[] bajtovi1 = BitConverter.GetBytes(prviFajlBitoviDuzina);
                if (!BitConverter.IsLittleEndian)
                    Array.Reverse(bajtovi1);
                int x = BitConverter.ToInt32(bajtovi1, 0);
                long e = x;

                byte[] bajtovi2 = BitConverter.GetBytes(e);
                BitArray nizBitovaDuzina = new BitArray(bajtovi2);

                int iterator = 0;
                while (pom1 % 512 != 0)
                {
                    prviFajlBitovi[pom1++] = nizBitovaDuzina[iterator++];
                }
            }


            //za svaka 512 bita, prave se 16 grupe po 32 bita(uint)
            for (int i = 0; i < prviFajlBitovi.Length; i += 512)
            {
                uint[] intovi = new uint[16];
                uint s1 = 0;
                int brojac1 = 0;
                int brojac2 = 0;
                while (brojac1 != 512)
                {
                    for (int j = 0; j < 32; j++)
                    {
                        if (prviFajlBitovi[i])
                            s1 += Convert.ToUInt32(Math.Pow(2, j));
                        brojac1++;
                    }

                    intovi[brojac2++] = s1;
                    s1 = 0;

                }
                uint a = h0;
                uint b = h1;
                uint c = h2;
                uint d = h3;

                uint f = 0;
                uint g = 0;

                for (int j = 0; j < 64; j++)
                {
                    if (j >= 0 && j <= 15)
                    {
                        f = (b & c) | ((~b) & d);
                        g = (uint)j;
                    }
                    if (16 >= 0 && j <= 31)
                    {
                        f = (d & b) | ((~d) & c);
                        g = (uint)((5 * j + 1) % 16);
                    }
                    if (j >= 32 && j <= 47)
                    {
                        f = b ^ c ^ d;
                        g = (uint)((3 * i + 5) % 16);
                    }
                    if (j >= 48 && j <= 63)
                    {
                        f = c ^ (b | (~d));
                        g = (uint)((7 * i) % 16);
                    }

                    var temp = d;
                    d = c;
                    c = b;
                    b = (uint)(b + leftRotate((a + f + k[j] + intovi[g]), r[j]));
                    a = temp;
                }

                h0 += a;
                h1 += b;
                h2 += c;
                h3 += d;

            }

            h0Hexa = string.Format("{0:x}", h0);
            h1Hexa = string.Format("{0:x}", h1);
            h2Hexa = string.Format("{0:x}", h2);
            h3Hexa = string.Format("{0:x}", h3);

            string digest = h0Hexa + h1Hexa + h2Hexa + h3Hexa;

            return digest;
        }

        public static long leftRotate(long q, int w)
        {
            return (q << w) | (q >> (32 - w));
        }
    }
}
