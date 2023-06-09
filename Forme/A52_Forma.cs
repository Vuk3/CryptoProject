using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZI_Projekat_18036.Algoritmi;
using ZI_Projekat_18036.PomocnaSredstva;

namespace ZI_Projekat_18036.Forme
{
    public partial class A52_Forma : Form
    {
        private string izlazEnkripcije;
        private string izlazniFolder;
        public A52_Forma()
        {
            InitializeComponent();
        }

        private bool provera()
        {
            string popraviti = "";

            if (izlazniFolder == null || izlazniFolder == "")
                popraviti += "Morate izabrati izlazni folder\n";
            if (txtKljuc1.Text == null || txtKljuc1.Text == "")
                popraviti += "Morate uneti prvi kljuc\n";
            if (txtKljuc2.Text == null || txtKljuc2.Text == "")
                popraviti += "Morate uneti drugi kljuc\n";
            if (txtTekst.Text == "")
                popraviti += "Morate uneti tekst koji zelite da kriptujete/dekriptujete\n";

            if (popraviti == "")
                return true;
            else
            {
                MessageBox.Show(popraviti);
                return false;
            }
        }

        private void btnUlaz_Click(object sender, EventArgs e)
        {
            this.txtTekst.Text = RadSaFajlovima.citajIzTxtFajla();
            if (txtTekst.Text != "")
                txtPrviFajl.Text = MD5.MD5Hash(Encoding.UTF8.GetBytes(txtTekst.Text));
        }

        private void btnKljuc_Click(object sender, EventArgs e)
        {
            this.txtKljuc1.Text = RadSaFajlovima.citajIzTxtFajla();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            izlazniFolder = RadSaFajlovima.izaberiFolder();
        }

        private void btnEnkriptuj_Click(object sender, EventArgs e)
        {
            if (provera())
            {
                string ulazniString = txtTekst.Text;
                A52 a = new A52(txtKljuc1.Text, txtKljuc2.Text);
                izlazEnkripcije = a.Encrypt(ulazniString, true);
                txtTekst.Text = izlazEnkripcije;
                RadSaFajlovima.pisiUTxtFajl(izlazniFolder + "\\A52-encrypted", izlazEnkripcije);
            }

        }

        private void btnKljuc2_Click(object sender, EventArgs e)
        {
            this.txtKljuc2.Text = RadSaFajlovima.citajIzTxtFajla();
        }

        private void btnDekriptuj_Click(object sender, EventArgs e)
        {
            if (provera())
            {
                A52 a = new A52(txtKljuc1.Text, txtKljuc2.Text);
                string w = a.Decrypt(izlazEnkripcije, false);
                RadSaFajlovima.pisiUTxtFajl(izlazniFolder + "\\A52-decrypted", w);
                txtDrugiFajl.Text = MD5.MD5Hash(Encoding.UTF8.GetBytes(w));
                txtTekst.Text = w;
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
                if (string.Compare(txtPrviFajl.Text, txtDrugiFajl.Text) == 0)
                {
                    MessageBox.Show("Fajlovi su identicni");
                }
                else
                {
                    MessageBox.Show("Fajlovi nisu identicni");
                }
            }
        }
    }
}
