using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZI_Projekat_18036.PomocnaSredstva;


namespace ZI_Projekat_18036.Algoritmi
{
    class XTEA
    {
        private readonly uint runde;
        private static byte[] IV;
        uint tmp0, tmp1;
        private const uint delta = 0x9E3779B9;

        public XTEA(uint runde)
        {
            IV = new byte[8];
            this.runde = runde;
        }
        public byte[] DecryptPCBC(byte[] bytesToDecrypt, string decryptionKey, string iv)
        {
            byte[] decryptedBytes = (byte[])bytesToDecrypt.Clone();

            byte[] pomUlazniBajtovi = (byte[])decryptedBytes.Clone();

            IV = Encoding.UTF8.GetBytes(iv);

            uint[] key = generisiKljuc(decryptionKey);

            uint IV0 = BitConverter.ToUInt32(IV, 0);
            uint IV1 = BitConverter.ToUInt32(IV, 4);

            for (int j = 0; j < decryptedBytes.Length; j += 8)
            {
                uint v0 = BitConverter.ToUInt32(decryptedBytes, j);
                uint v1 = BitConverter.ToUInt32(decryptedBytes, j + 4);


                uint pom0 = BitConverter.ToUInt32(pomUlazniBajtovi, j);
                uint pom1 = BitConverter.ToUInt32(pomUlazniBajtovi, j + 4);


                uint sum = delta * runde;
                for (uint i = 0; i < runde; i++)
                {
                    v1 -= (((v0 << 4) ^ (v0 >> 5)) + v0) ^ (sum + key[(sum >> 11) & 3U]);
                    sum -= delta;
                    v0 -= (((v1 << 4) ^ (v1 >> 5)) + v1) ^ (sum + key[sum & 3U]);
                }

                if (j == 0)
                {
                    v0 ^= IV0;
                    v1 ^= IV1;
                }
                else
                {
                    v0 ^= tmp0;
                    v1 ^= tmp1;
                }


                Array.Copy(BitConverter.GetBytes(v0), 0, decryptedBytes, j, 4);
                Array.Copy(BitConverter.GetBytes(v1), 0, decryptedBytes, j + 4, 4);

                tmp0 = pom0 ^ v0;
                tmp1 = pom1 ^ v1;
            }
            return decryptedBytes;
        }

        public byte[] EncryptPCBC(byte[] bytesToEncrypt, string encryptionKey, string iv)
        {

            byte[] pomUlazniBajtovi = (byte[])bytesToEncrypt.Clone();

            uint[] key = generisiKljuc(encryptionKey);

            IV = Encoding.UTF8.GetBytes(iv);

            //PCBC

            uint IV0 = BitConverter.ToUInt32(IV, 0);
            uint IV1 = BitConverter.ToUInt32(IV, 4);

            for (int j = 0; j < bytesToEncrypt.Length; j += 8)
            {
                uint v0 = BitConverter.ToUInt32(bytesToEncrypt, j);
                uint v1 = BitConverter.ToUInt32(bytesToEncrypt, j + 4);



                uint pom0 = BitConverter.ToUInt32(pomUlazniBajtovi, j);
                uint pom1 = BitConverter.ToUInt32(pomUlazniBajtovi, j + 4);

                if (j == 0)
                {
                    v0 ^= IV0;
                    v1 ^= IV1;
                }
                else
                {
                    v0 ^= tmp0;
                    v1 ^= tmp1;
                }


                uint sum = 0;
                for (uint i = 0; i < runde; i++)
                {
                    v0 += (((v1 << 4) ^ (v1 >> 5)) + v1) ^ (sum + key[sum & 3U]);
                    sum += delta;
                    v1 += (((v0 << 4) ^ (v0 >> 5)) + v0) ^ (sum + key[(sum >> 11) & 3U]);
                }


                Array.Copy(BitConverter.GetBytes(v0), 0, bytesToEncrypt, j, 4);
                Array.Copy(BitConverter.GetBytes(v1), 0, bytesToEncrypt, j + 4, 4);
                tmp0 = v0 ^ pom0;
                tmp1 = v1 ^ pom1;
            }

            return bytesToEncrypt;
        }


        public byte[] Decrypt(byte[] bytesToDecrypt, string decryptionKey)
        {
            byte[] decryptedBytes = (byte[])bytesToDecrypt.Clone();

            uint[] key = generisiKljuc(decryptionKey);

            for (int j = 0; j < decryptedBytes.Length; j += 8)
            {
                uint v0 = BitConverter.ToUInt32(decryptedBytes, j);
                uint v1 = BitConverter.ToUInt32(decryptedBytes, j + 4);

                uint sum = delta * runde;
                for (uint i = 0; i < runde; i++)
                {
                    v1 -= (((v0 << 4) ^ (v0 >> 5)) + v0) ^ (sum + key[(sum >> 11) & 3U]);
                    sum -= delta;
                    v0 -= (((v1 << 4) ^ (v1 >> 5)) + v1) ^ (sum + key[sum & 3U]);
                }

                Array.Copy(BitConverter.GetBytes(v0), 0, decryptedBytes, j, 4);
                Array.Copy(BitConverter.GetBytes(v1), 0, decryptedBytes, j + 4, 4);
            }
            return decryptedBytes;
        }

        public byte[] Encrypt(byte[] bytesToEncrypt, string encryptionKey)
        {

            uint[] key = generisiKljuc(encryptionKey);



            for (int j = 0; j < bytesToEncrypt.Length; j += 8)
            {
                uint v0 = BitConverter.ToUInt32(bytesToEncrypt, j);
                uint v1 = BitConverter.ToUInt32(bytesToEncrypt, j + 4);

                uint sum = 0;
                for (uint i = 0; i < runde; i++)
                {
                    v0 += (((v1 << 4) ^ (v1 >> 5)) + v1) ^ (sum + key[sum & 3U]);
                    sum += delta;
                    v1 += (((v0 << 4) ^ (v0 >> 5)) + v0) ^ (sum + key[(sum >> 11) & 3U]);
                }


                Array.Copy(BitConverter.GetBytes(v0), 0, bytesToEncrypt, j, 4);
                Array.Copy(BitConverter.GetBytes(v1), 0, bytesToEncrypt, j + 4, 4);
            }

            return bytesToEncrypt;
        }

        static SemaphoreSlim semafor = new SemaphoreSlim(1);

        public void Paralelizacija(string plaintext, string kljuc, string path)
        {

            int brojNiti = plaintext.Length / 8;
            string[] podStringovi = new string[brojNiti];
            Thread[] niti = new Thread[brojNiti];
            for (int i = 0; i < podStringovi.Length; i++)
            {
                podStringovi[i] = "";
            }

            for (int i = 0; i < brojNiti; i++)
            {
                podStringovi[i] = plaintext.Substring(i * 8, 8);
                niti[i] = new Thread(() =>
                {
                    var enkriptovaniBajtovi= this.Encrypt(Encoding.UTF8.GetBytes(podStringovi[i]), kljuc);
                    nitiFunkcija(Encoding.UTF8.GetString(enkriptovaniBajtovi), path);
                });
            }

            for (int i = 0; i < brojNiti; i++)
            {
                niti[i].Start();
                Thread.Sleep(5);
            }

            for (int i = 0; i < brojNiti; i++)
            {
                niti[i].Join();
            }
        }
        public void nitiFunkcija(string text, string path)
        {
            semafor.Wait();
            try
            {
                using (FileStream fs = File.Open(path, FileMode.Append))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(text);
                }
            }
            finally
            {
                semafor.Release();
            }
        }
        private uint[] generisiKljuc(string encryptionKey)
        {
            uint[] key = new uint[4];
            byte[] keyBytes = Encoding.Unicode.GetBytes(encryptionKey);

            for (int i = 0; i < 4; i++)
            {
                key[i] = BitConverter.ToUInt32(keyBytes, i * 4);
            }

            return key;
        }
    }
    
}
