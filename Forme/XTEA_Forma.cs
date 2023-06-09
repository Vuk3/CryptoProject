using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZI_Projekat_18036.PomocnaSredstva;
using ZI_Projekat_18036.Algoritmi;
using System.IO;
using System.Collections;

namespace ZI_Projekat_18036.Forme
{
    public partial class XTEA_Forma : Form
    {
        private string izlazniFolder;
        private OpenFileDialog ofd;
        private string ulazniFajlPutanja;
        private string ulazniFajlEkstenzija;

        private string izlazniFajlPutanja;

        byte[] ulazniBajtovi;
        byte[] enkriptovaniBajtovi;
        byte[] izlazniBajtovi;

        int kolikoDodati = 0;

        public XTEA_Forma()
        {
            InitializeComponent();
        }

        private bool provera()
        {
            string popraviti = "";
            if (izlazniFolder == null || izlazniFolder == "")
                popraviti += "Morate izabrati izlazni folder\n";
            if (txtKljuc.Text == null || txtKljuc.Text == "")
                popraviti += "Morate uneti kljuc\n";
            if (ulazniBajtovi == null && enkriptovaniBajtovi == null && txtTekst.Text == "")
                popraviti += "Morate uneti tekst koji zelite da kriptujete/dekriptujete\n";
            if (txtKljuc.Text.Length != 16)
                popraviti += "Kljuc mora imati 16 karaktera";
            if (cbPCBC.Checked && txtIV.Text.Length != 8)
                popraviti += "Inicijalni vektor mora imati 8 karaktera";


            if (popraviti=="")
                return true;
            else
            {
                MessageBox.Show(popraviti);
                return false;
            }
        }





        private void EnkriptujBitapu(XTEA x) 
        {
            if (cbPCBC.Checked)
            {
                izlazniFajlPutanja = izlazniFolder + "\\" + Path.GetFileNameWithoutExtension(ofd.FileName) + "EncPCBC.bmp";
            }
            else
            {
                izlazniFajlPutanja = izlazniFolder + "\\" + Path.GetFileNameWithoutExtension(ofd.FileName) + "Enc.bmp";
            }
            
            

            FileStream b = File.OpenWrite(izlazniFajlPutanja);
            int pos = ulazniBajtovi[10] + 256 * (ulazniBajtovi[11] + 256 * (ulazniBajtovi[12] + 256 * ulazniBajtovi[13]));

            byte[] headerPlain = new byte[pos];
            byte[] bodyPlain = new byte[ulazniBajtovi.Length - pos];


            byte[] bodyCipher = new byte[ulazniBajtovi.Length - pos];


            Buffer.BlockCopy(ulazniBajtovi, 0, headerPlain, 0, pos);

            Buffer.BlockCopy(ulazniBajtovi, pos, bodyPlain, 0, ulazniBajtovi.Length - pos);


            var checkedButton = this.panelRunde.Controls.OfType<RadioButton>()
                          .FirstOrDefault(r => r.Checked);

            if (bodyPlain.Length % 8 != 0)
                kolikoDodati = Math.Abs(bodyPlain.Length % 8 - 8);

            if (kolikoDodati != 0)
            {
                int kd = 0;
                byte[] noviBajtovi = new byte[bodyPlain.Length + kolikoDodati];
                byte[] bajt = new byte[] { 0x16 };
                while (kd != kolikoDodati)
                {

                    noviBajtovi[bodyPlain.Length + kd++] = bajt[0];
                }
                Buffer.BlockCopy(bodyPlain, 0, noviBajtovi, 0, bodyPlain.Length);
                bodyPlain = new byte[noviBajtovi.Length];
                Buffer.BlockCopy(noviBajtovi, 0, bodyPlain, 0, noviBajtovi.Length);

            }

            if (cbPCBC.Checked)
                bodyCipher = x.EncryptPCBC(bodyPlain, txtKljuc.Text, txtIV.Text);
            else
                bodyCipher = x.Encrypt(bodyPlain, txtKljuc.Text);



            byte[] rezultat = new byte[headerPlain.Length + bodyCipher.Length];

            Buffer.BlockCopy(headerPlain, 0, rezultat, 0, pos);
            Buffer.BlockCopy(bodyCipher, 0, rezultat, pos, bodyCipher.Length);


            for (int i = 0; i < rezultat.Length; i++)
            {
                b.WriteByte(rezultat[i]);
            }

            izlazniBajtovi = new byte[rezultat.Length];

            Buffer.BlockCopy(rezultat, 0, izlazniBajtovi, 0, izlazniBajtovi.Length);

            b.Close();
        }

        private void DekriptujBitmapu(XTEA x)
        {
            string izlaz = "";
            if (izlazniBajtovi == null)
            {
                if (cbPCBC.Checked)
                {
                    izlaz = izlazniFolder + "\\" + Path.GetFileNameWithoutExtension(ofd.FileName) + "DecPCBC.bmp";
                }
                else
                {
                    izlaz = izlazniFolder + "\\" + Path.GetFileNameWithoutExtension(ofd.FileName) + "Dec.bmp";
                }
            }
            else
            {
                if (cbPCBC.Checked)
                {
                    izlaz = izlazniFolder + "\\" + Path.GetFileNameWithoutExtension(izlazniFajlPutanja) + "DecPCBC.bmp";
                }
                else
                {
                    izlaz = izlazniFolder + "\\" + Path.GetFileNameWithoutExtension(izlazniFajlPutanja) + "Dec.bmp";
                }
                
            }
                
            
            FileStream b = File.OpenWrite(izlaz);

            if (izlazniBajtovi==null)
            {
                izlazniBajtovi = new byte[ulazniBajtovi.Length];
                Buffer.BlockCopy(ulazniBajtovi, 0, izlazniBajtovi, 0, ulazniBajtovi.Length);
            }
            int pos = izlazniBajtovi[10] + 256 * (izlazniBajtovi[11] + 256 * (izlazniBajtovi[12] + 256 * izlazniBajtovi[13]));

            byte[] headerPlain = new byte[pos];
            byte[] bodyPlain = new byte[izlazniBajtovi.Length - pos];

            byte[] bodyCipher = new byte[izlazniBajtovi.Length - pos];


            Buffer.BlockCopy(izlazniBajtovi, 0, headerPlain, 0, pos);

            Buffer.BlockCopy(izlazniBajtovi, pos, bodyPlain, 0, izlazniBajtovi.Length - pos);


            var checkedButton = this.panelRunde.Controls.OfType<RadioButton>()
                          .FirstOrDefault(r => r.Checked);

            if(cbPCBC.Checked)
                bodyCipher = x.DecryptPCBC(bodyPlain, txtKljuc.Text, txtIV.Text);
            else
                bodyCipher = x.Decrypt(bodyPlain, txtKljuc.Text);

            if (kolikoDodati != 0)
            {
                byte[] pomBodyCipher = new byte[bodyCipher.Length - kolikoDodati];
                Buffer.BlockCopy(bodyCipher, 0, pomBodyCipher, 0, bodyCipher.Length - kolikoDodati);
                bodyCipher = new byte[pomBodyCipher.Length];
                Buffer.BlockCopy(pomBodyCipher, 0, bodyCipher, 0, pomBodyCipher.Length - kolikoDodati);
            }

            int kolikoOduzeti = 0;
            int broj = bodyCipher.Length;
            while (bodyCipher[broj-1] == 22)
            {
                kolikoOduzeti++;
                broj--;
            }

            if (kolikoOduzeti != 0)
            {
                byte[] pomBodyCipher = new byte[bodyCipher.Length - kolikoOduzeti];
                Buffer.BlockCopy(bodyCipher, 0, pomBodyCipher, 0, bodyCipher.Length - kolikoOduzeti);
                bodyCipher = new byte[pomBodyCipher.Length];
                Buffer.BlockCopy(pomBodyCipher, 0, bodyCipher, 0, pomBodyCipher.Length - kolikoOduzeti);
            }
            byte[] rezultat = new byte[headerPlain.Length + bodyCipher.Length];

            Buffer.BlockCopy(headerPlain, 0, rezultat, 0, pos);
            Buffer.BlockCopy(bodyCipher, 0, rezultat, pos, bodyCipher.Length);

            txtDrugiFajl.Text = MD5.MD5Hash(rezultat);



            for (int i = 0; i < rezultat.Length; i++)
            {
                b.WriteByte(rezultat[i]);
            }

            b.Close();
        }

        private void btnEnkriptuj_Click(object sender, EventArgs e)
        {

            if (provera())
            {
                bool flag = true;
                var checkedButton = this.panelRunde.Controls.OfType<RadioButton>()
                                       .FirstOrDefault(r => r.Checked);
                XTEA x = new XTEA(Convert.ToUInt32(checkedButton.Text));
                if (ulazniFajlEkstenzija != ".bmp")
                {
                    byte[] encryptedBytes = null;
                    if (ulazniBajtovi != null && ulazniBajtovi.Length > 0)
                    {
                        kolikoDodati=0;
                        if (ulazniBajtovi.Length % 8 != 0)
                            kolikoDodati = Math.Abs(ulazniBajtovi.Length % 8 - 8);

                        if (kolikoDodati != 0)
                        {
                            int kd = 0;
                            byte[] noviBajtovi = new byte[ulazniBajtovi.Length + kolikoDodati];
                            byte[] bajt = new byte[] { 0x1E };
                            while( kd != kolikoDodati)
                            {

                                noviBajtovi[ulazniBajtovi.Length + kd++] = bajt[0];
                            }
                            Buffer.BlockCopy(ulazniBajtovi, 0, noviBajtovi, 0, ulazniBajtovi.Length);
                            ulazniBajtovi = new byte[noviBajtovi.Length];
                            Buffer.BlockCopy(noviBajtovi, 0, ulazniBajtovi, 0, noviBajtovi.Length);

                        }
                        if (cbPCBC.Checked)
                        {
                            encryptedBytes = x.EncryptPCBC(ulazniBajtovi, txtKljuc.Text, txtIV.Text);
                            flag = true;
                        }

                        else
                        {
                            if(cbPar.Checked)
                                x.Paralelizacija(Encoding.UTF8.GetString(ulazniBajtovi), txtKljuc.Text, izlazniFolder + "\\XTEA-encryptedPar");
                            else
                                encryptedBytes = x.Encrypt(ulazniBajtovi, txtKljuc.Text);
                            flag = false;
                        }
                    }        
                    else
                    {
                        string ulazniString = txtTekst.Text;
                        while (ulazniString.Length % 8 != 0)
                        {
                            ulazniString += " ";
                        }
                        if (cbPCBC.Checked)
                        {
                            flag = true;
                            encryptedBytes = x.EncryptPCBC(Encoding.UTF8.GetBytes(ulazniString), txtKljuc.Text, txtIV.Text);
                        }
                        else
                        {
                            encryptedBytes = x.Encrypt(Encoding.UTF8.GetBytes(ulazniString), txtKljuc.Text);
                            flag = false;
                        }
                    }
                       
                            
                    enkriptovaniBajtovi = new byte[encryptedBytes.Length];
                    Buffer.BlockCopy(encryptedBytes, 0, enkriptovaniBajtovi, 0, encryptedBytes.Length);


                    txtTekst.Text = Encoding.UTF8.GetString(encryptedBytes);
                    if(flag)
                        RadSaFajlovima.pisiUBinarniFajl(izlazniFolder + "\\XTEAPCBC-encrypted", encryptedBytes);
                    else
                        RadSaFajlovima.pisiUBinarniFajl(izlazniFolder + "\\XTEA-encrypted", encryptedBytes);
                }
                else
                {
                    EnkriptujBitapu(x);
                }
            }


        }
        private void btnDekriptuj_Click(object sender, EventArgs e)
        {

            if (provera())
            {
                bool flag = true;
                var checkedButton = this.panelRunde.Controls.OfType<RadioButton>()
              .FirstOrDefault(r => r.Checked);
                
                XTEA x = new XTEA(Convert.ToUInt32(checkedButton.Text));

                if (ulazniFajlEkstenzija != ".bmp")
                {
                    byte[] decryptedBytes=null;
                    if(cbPCBC.Checked)
                    {
                        decryptedBytes = x.DecryptPCBC(enkriptovaniBajtovi != null ? enkriptovaniBajtovi : ulazniBajtovi, txtKljuc.Text, txtIV.Text);
                        flag = true;
                    }
                    else
                    {
                        decryptedBytes = x.Decrypt(enkriptovaniBajtovi != null ? enkriptovaniBajtovi : ulazniBajtovi, txtKljuc.Text);
                        flag = false;
                    }
                    

                    string decryptedString = Encoding.UTF8.GetString(decryptedBytes);

                    decryptedString = decryptedString.Substring(0,decryptedString.Length-kolikoDodati);
                    kolikoDodati = 0;


                    txtTekst.Text = decryptedString;

                    

                    if (flag)
                        RadSaFajlovima.pisiUTxtFajl(izlazniFolder + "\\XTEAPCBC-decrypted", decryptedString);
                    else
                        RadSaFajlovima.pisiUTxtFajl(izlazniFolder + "\\XTEA-decrypted", decryptedString);

                    txtDrugiFajl.Text = MD5.MD5Hash(Encoding.UTF8.GetBytes(decryptedString));
                }
                else
                {
                    DekriptujBitmapu(x);
                }
            }
        }

        private void btnUlaz_Click(object sender, EventArgs e)
        {
            ofd = RadSaFajlovima.OtvoriFajl();
            ulazniFajlPutanja = ofd.FileName;
            ulazniFajlEkstenzija = Path.GetExtension(ulazniFajlPutanja);
            if (ulazniFajlEkstenzija==".txt")
            {
                this.txtTekst.Text = RadSaFajlovima.citajIzTxt(ofd);
                ulazniBajtovi = Encoding.UTF8.GetBytes(txtTekst.Text);
            } 
            else if (ulazniFajlEkstenzija==".bin")
            {
                ulazniBajtovi = RadSaFajlovima.citajIzBinarnogFajla(ulazniFajlPutanja);
                this.txtTekst.Text = Encoding.UTF8.GetString(ulazniBajtovi);
            }
            else if (ulazniFajlEkstenzija == ".bmp")
            {
                FileStream fsr = File.OpenRead(ofd.FileName);
                ulazniBajtovi = new byte[fsr.Length];
                fsr.Read(ulazniBajtovi, 0, Convert.ToInt32(fsr.Length));
                txtPrviFajl.Text = MD5.MD5Hash(ulazniBajtovi);
            }
            if (txtTekst.Text != "")
                txtPrviFajl.Text = MD5.MD5Hash(ulazniBajtovi);
        }

        private void btnKljuc_Click(object sender, EventArgs e)
        {
            this.txtKljuc.Text = RadSaFajlovima.citajIzTxtFajla();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            izlazniFolder = RadSaFajlovima.izaberiFolder();
        }

        private void btnBitmap_Click(object sender, EventArgs e)
        {
            ofd = RadSaFajlovima.OtvoriFajl();
            FileStream fsr = File.OpenRead(ofd.FileName);
            byte[] a = new byte[fsr.Length];
            fsr.Read(a, 0, Convert.ToInt32(fsr.Length));

            FileStream b = File.OpenWrite(izlazniFolder +"\\"+ Path.GetFileNameWithoutExtension(ofd.FileName) + "Enc.bmp");
            int pos = a[10] + 256 * (a[11] + 256 * (a[12] + 256 * a[13]));

            byte[] headerPlain = new byte[pos];
            byte[] bodyPlain = new byte[a.Length-pos];

            //byte[] headerCipher = new byte[pos];
            byte[] bodyCipher = new byte[a.Length - pos];

            for (int i = 0; i < pos; i++)
            {
                headerPlain[i] = a[i];
            }

            for (int i = pos; i < a.Length; i++)
            {
                int j = i - pos;
                bodyPlain[j] = a[i];
            }

            var checkedButton = this.panelRunde.Controls.OfType<RadioButton>()
                          .FirstOrDefault(r => r.Checked);
            XTEA x = new XTEA(Convert.ToUInt32(checkedButton.Text));
            //headerCipher = x.Encrypt(headerPlain, txtKljuc.Text);
            bodyCipher = x.Encrypt(bodyPlain, txtKljuc.Text);

            byte[] rezultat = new byte[headerPlain.Length + bodyCipher.Length];
            Buffer.BlockCopy(headerPlain, 0, rezultat, 0, headerPlain.Length);
            Buffer.BlockCopy(bodyCipher, 0, rezultat, headerPlain.Length, bodyCipher.Length);


            for (int i = 0; i < fsr.Length; i++)
            {
                b.WriteByte(rezultat[i]);
            }
        }

        private void btnMD5_Click(object sender, EventArgs e)
        {
            string provera = "";
            if (txtPrviFajl.Text == "")
                provera += "Morate ucitati fajl\n";
            if (txtDrugiFajl.Text == "")
                provera += "Morate ucitati fajl, izvrsiti kodiranje, zatim dekodiranje\n";
            if (provera != "")
                MessageBox.Show(provera);
            else
            {
                if(string.Compare(txtPrviFajl.Text, txtDrugiFajl.Text) == 0)
                {
                    MessageBox.Show("Fajlovi su identicni");
                }
                else
                {
                    MessageBox.Show("Fajlovi nisu identicni");
                }
            }
        }

        private void cbPCBC_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPCBC.Checked)
                txtIV.Enabled = true;
            else
                txtIV.Enabled = false;
        }
    }
}
