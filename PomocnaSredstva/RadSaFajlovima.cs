using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZI_Projekat_18036.PomocnaSredstva
{
    class RadSaFajlovima
    {
        public static string izaberiFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                return fbd.SelectedPath;
            }
            return "";
        }
        public static void pisiUTxtFajl(string filePath, string fileContent)
        {
            File.WriteAllText(filePath + ".txt", fileContent);
        }

        public static OpenFileDialog OtvoriFajl()
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "txt files (*.txt)|*.txt|bin files (*.bin)|*.bin|bmp files (*.bmp)|*.bmp",
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
               
            }

            return ofd;
        }

        public static string citajIzTxt(OpenFileDialog ofd)
        {
            string fileContent = "";

            using StreamReader reader = new StreamReader(ofd.OpenFile());
            fileContent = reader.ReadToEnd();

            return fileContent;
        }


        public static string citajIzTxtFajla()
        {
            var fileContent = "";
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 0
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using StreamReader reader = new StreamReader(ofd.OpenFile());
                fileContent = reader.ReadToEnd();

            }

            return fileContent;
        }

        public static void pisiUBinarniFajl(string putanja, byte[] sadrzaj)
        {
            File.WriteAllBytes(putanja + ".bin", sadrzaj);
        }

        public static byte[] citajIzBinarnogFajla(string putanja)
        {

            if (File.Exists(putanja))
            {
                return File.ReadAllBytes(putanja);
            }

            return null;
        }
    }
}
