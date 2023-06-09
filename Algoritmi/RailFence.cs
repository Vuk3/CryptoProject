using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZI_Projekat_18036.Forme;

namespace ZI_Projekat_18036.Algoritmi
{
    class RailFence
    {
        static SemaphoreSlim semaphore = new SemaphoreSlim(1);
        public RailFence() { }
        public string Encrypt(string plaintext, int brojRedova, int offset)
        {
            int duzina = plaintext.Length;
            char[,] matrica = new char[brojRedova, duzina];
            for (int i = 0; i < brojRedova; i++)
                for (int j = 0; j < duzina; j++)
                    matrica[i, j] = '-';
            int red = 0, kolona = 0;
            bool smer = false;
            if (offset==0)
                smer = false;
            if (offset == brojRedova - 1)
                smer = true;
            if (offset > 0 && offset < brojRedova - 1)
                smer = true;
            if (offset > brojRedova - 1)
            {
                smer = false;
                offset = (brojRedova - 1) - (offset - (brojRedova - 1));
            }
            red += offset;
            for (int i = 0; i < duzina; i++)
            {
                if (red == 0 || red == brojRedova - 1)
                    smer = !smer;
                matrica[red, kolona++] = plaintext[i];
                if (smer)
                    red++;
                else
                    red--;
            }
            string rezultat = "";
            for (int i = 0; i < brojRedova; i++)
                for (int j = 0; j < duzina; j++)
                    if (matrica[i, j] != '-')
                        rezultat += matrica[i, j];
            return rezultat;
        }

        public string Decrypt(string ciphertext, int brojRedova, int offset)
        {
 
            int duzina = ciphertext.Length;
            char[,] matrica = new char[brojRedova, duzina];
            for (int i = 0; i < brojRedova; i++)
                for (int j = 0; j < duzina; j++)
                    matrica[i, j] = '-';
            int red = 0, kolona = 0;
            int pomeraj1, pomeraj2, pomeraj3 = 0;
            bool pomerajBool = true;
            for (int i = 0; i < duzina; i++)
            {
                pomeraj1 = red;
                if (kolona + pomeraj1 - offset>= duzina)
                {
                    red++;
                    kolona = 0;
                    pomerajBool = true;
                }
                pomeraj1 = red;
                pomeraj2 = brojRedova + brojRedova - 2 - 2 * red;
                pomeraj3 = brojRedova + brojRedova - 2 - pomeraj2;
                if (kolona + pomeraj1 - offset < 0)
                {
                    if (pomeraj2 == 0)
                        kolona += pomeraj3;
                    if (kolona + pomeraj2 + pomeraj1 - offset < 0)
                    {
                        kolona += pomeraj2 + pomeraj3;
                        pomerajBool = !pomerajBool;
                    }

                    else
                        kolona += pomeraj2;
                    pomerajBool = !pomerajBool;
                }
                    

                matrica[ red, kolona + pomeraj1 - offset] = ciphertext[i];
                //if (red != 0 && flagSmer && red != offset && offset != 0)
                //{
                //    pomerajBool = !pomerajBool;
                //    flagSmer = false;
                //}
                if (pomerajBool == true)
                    if(pomeraj2==0)
                        kolona += pomeraj3;
                    else
                        kolona += pomeraj2;
                else
                    if (pomeraj3 == 0)
                        kolona += pomeraj2;
                    else
                        kolona += pomeraj3;
                pomerajBool = !pomerajBool;

               
            }

            string rezultat = "";
            int red1 = 0, kolona1 = 0;
            bool smer1 = false;

            if (offset == 0)
                smer1 = false;
            if (offset == brojRedova - 1)
                smer1 = true;
            if (offset > 0 && offset < brojRedova - 1)
                smer1 = true;
            if (offset > brojRedova - 1)
            {
                smer1 = false;
                offset = (brojRedova - 1) - (offset - (brojRedova - 1));
            }
            red1 += offset;
            for (int i = 0; i < duzina; i++)
            {
                if (red1 == 0 || red1 == brojRedova - 1)
                    smer1 = !smer1;
                rezultat += matrica[red1, kolona1++];
                if (smer1)
                    red1++;
                else
                    red1--;
            }
            return rezultat;

        }

        public void TeaThreads(int brojNiti, string plaintext, string path, int brojRedova, int offset, RailFence_Forma tx)
        {


            tx.Text = "";
            int korak = 0;
            int poslednjiKorak = -1;

            korak = (plaintext.Length / brojNiti);

            if (plaintext.Length % brojNiti != 0)
            {
                poslednjiKorak = Math.Abs(plaintext.Length % brojNiti);
            }

            Thread[] threads = new Thread[brojNiti];


            string subS = "";

            for (int i = 0; i < brojNiti; i++)
            {

                subS = "";         

                if(poslednjiKorak!=-1 && i == brojNiti - 1)
                {
                    subS = plaintext.Substring(i * korak, poslednjiKorak+korak);
                }
                else
                {
                    subS = plaintext.Substring(i * korak, korak);
                }
                int l = subS.Length;
                threads[i] = new Thread(() =>
                {
                    string encText = this.Encrypt(subS, brojRedova, offset);
                    //tx.txtTekst.Text += encText;
                    threadJob(encText, path);
                });
            }



            for (int i = 0; i < brojNiti; i++)
            {
                threads[i].Start();
                Thread.Sleep(10);
            }



            for (int i = 0; i < brojNiti; i++)
            {
                threads[i].Join();
            }



        }
        public void threadJob(string text, string path)
        {
            semaphore.Wait();
            try
            {
                using (FileStream fs = File.Open(path, FileMode.Append))
                using (StreamWriter sw = new(fs))
                {
                    sw.Write(text);
                }
            }
            finally
            {
                // Release access to the file
                semaphore.Release();
            }
        }
        

    }
}

