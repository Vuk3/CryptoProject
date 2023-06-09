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
    public partial class RailFence_Forma : Form
    {
        private string izlazniFolder;
        public RailFence_Forma()
        {
            InitializeComponent();
        }

        private bool provera()
        {
            string popraviti = "";

            if (izlazniFolder == null || izlazniFolder == "")
                popraviti += "Morate izabrati izlazni folder\n";
            if (numKljuc.Value <3 || numKljuc.Value >7)
                popraviti += "Kljuc nije u opsegu od 3 do 7\n";
            if (numOffset.Value < 0 || numOffset.Value > 2*numKljuc.Value-3)
                popraviti += "Offset nije u opsegu od 0 do" + (numKljuc.Value*2-3) + "\n";
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

        private void btnEnkriptuj_Click(object sender, EventArgs e)
        {
            if (provera())
            {
                RailFence rf = new RailFence();
                var encryptedString = rf.Encrypt(txtTekst.Text, Decimal.ToInt32(numKljuc.Value), Decimal.ToInt32(numOffset.Value));
                txtTekst.Text = encryptedString;
                RadSaFajlovima.pisiUTxtFajl(izlazniFolder + "\\RF-encrypted", encryptedString);
            }

        }

        private void btnDekriptuj_Click(object sender, EventArgs e)
        {
            if (provera())
            {
                RailFence rf = new RailFence();
                var decryptedString = rf.Decrypt(txtTekst.Text, Decimal.ToInt32(numKljuc.Value), Decimal.ToInt32(numOffset.Value));
                txtTekst.Text = decryptedString;
                txtDrugiFajl.Text = MD5.MD5Hash(Encoding.UTF8.GetBytes(decryptedString));
                RadSaFajlovima.pisiUTxtFajl(izlazniFolder + "\\RF-decrypted", decryptedString);
            }

        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            izlazniFolder = RadSaFajlovima.izaberiFolder();
        }

        private void btnUlaz_Click(object sender, EventArgs e)
        {
            //TxtBin tb = new TxtBin();
            //tb.ShowDialog();
            
            this.txtTekst.Text = RadSaFajlovima.citajIzTxtFajla();
            if(txtTekst.Text!="")
                txtPrviFajl.Text = MD5.MD5Hash(Encoding.UTF8.GetBytes(txtTekst.Text));
            //this.txtTekst.Text = Encoding.Default.GetString(RadSaFajlovima.citajIzBinarnogFajla(""));
        }

        private void btnKljuc_Click(object sender, EventArgs e)
        {
            this.numKljuc.Value = Convert.ToDecimal(RadSaFajlovima.citajIzTxtFajla());
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

        private void txtKljuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
