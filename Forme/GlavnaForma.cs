using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZI_Projekat_18036.Forme;


namespace ZI_Projekat_18036
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnA5_2_Click(object sender, EventArgs e)
        {
            A52_Forma a = new A52_Forma();
            a.ShowDialog();
        }

        private void btnRailFence_Click(object sender, EventArgs e)
        {
            RailFence_Forma r = new RailFence_Forma();
            r.ShowDialog();
        }

        private void btnPCBC_Click(object sender, EventArgs e)
        {
            string poruka = "-Objasnjenje projekta, kako se pokrece, kako radi...\n" +
                "-Za svaki od algoritama postoji posebna forma.\n" +
                "-Klikom na dugme na pocetnoj formi se otvara forma za odgovarajuci algoritam\n" +
                "-Podrzani su upis i citanje iz svih vrsta fajlova (txt, bin, bmp)\n\n" +
                "-Algoritam A5/2\n" +
                "  Moguce je rucno uneti tekst u polje 'Tekst', ili ucitati tekst iz fajla\n" +
                "  Kljucevi se mogu uneti rucno, a mogu se ucitati iz fajla\n" +
                "  Kljucevi su nizovi nula ili jedinica\n" +
                "  Podesiti izlazni folder(gde ce se cuvati fajl kad se kriptuje / dekriptuje)\n" +
                "  Kada se tekst kriptuje, u polju 'Tekst' ce se prikazati kriptovani tekst u vidu niza bitova\n" +
                "  Kada se tekst dekriptuje, u polju 'Tekst ce se prikazati dekriptovani tekst kao string\n" +
                "  Moguce je iskoristiti MD5 hash za proveru da li je polazni fajl isti kao onaj koji je kriptovan pa dekriptovan.\n" +
                "  Po ucitavanju fajla, u text boxu 'Pocetni fajl' se pojavljuje MD5 vrednost fajla\n" +
                "  Kada se izvrsi kriptovanje pa dekriptovanje, u text boxu 'Krajnji fajl' se pojavljuje MD5 vrednost fajla\n" +
                "  Klikom na dugme proveri MD5 se uporedjuju te dve vrednosti, ako su jednake, znaci da su fajlovi identicni\n" +
                "  Kriptovan fajl se cuva pod imenom A52-encrypted, tamo gde je odabran izlazni folder\n" +
                "  Dekriptovan fajl se cuva pod imenom A52-decrypted\n\n" +

                "-Algoritam RailFence:\n" +
                "  Moguce je rucno uneti tekst u polje 'Tekst', ili ucitati tekst iz fajla\n" +
                "  Kljuc se moze uneti rucno, a moze se ucitati iz fajla. Kljuc je broj redova\n" +
                "  Podesiti offset\n" +
                "  Podesiti izlazni folder (gde ce se cuvati fajl kad se kriptuje/dekriptuje)\n" +
                "  Kada se tekst kriptuje, u polju 'Tekst' ce se prikazati kriptovani tekst. Isto vazi i za dekriptovanje.\n" +
                "  Moguce je iskoristiti MD5 hash za proveru da li je polazni fajl isti kao onaj koji je kriptovan pa dekriptovan.\n" +
                "  Po ucitavanju fajla, u text boxu 'Pocetni fajl' se pojavljuje MD5 vrednost fajla\n" +
                "  Kada se izvrsi kriptovanje pa dekriptovanje, u text boxu 'Krajnji fajl' se pojavljuje MD5 vrednost fajla\n" +
                "  Klikom na dugme proveri MD5 se uporedjuju te dve vrednosti, ako su jednake, znaci da su fajlovi identicni\n" +
                "  Kriptovan fajl se cuva pod imenom RF-encrypted, tamo gde je odabran izlazni folder\n" +
                "  Dekriptovan fajl se cuva pod imenom RF-decrypted\n\n" +

                "-Algoritam XTEA:\n" +
                "  Moguce je rucno uneti tekst u polje 'Tekst', ili ucitati tekst iz fajla\n" +
                "  Kljuc se moze uneti rucno, a moze se ucitati iz fajla. Kljuc mora imati 16 karaktera\n" +
                "  Podesiti izlazni folder (gde ce se cuvati fajl kad se kriptuje/dekriptuje)\n" +
                "  Za XTEA algoritam je implementiran PCBC, koji se moze aktivirati stikliranjem checkbox-a\n" +
                "  Ukoliko se stiklira checkbox za PCBC, potrebno je uneti inicijalni vektor u duzini od 8 karaktera\n" +
                "  Moguce je izabrati broj rundi (32 ili 64) preko radio button-a\n" +
                "  Pokusaj paralelizacije, nije u potpunosti lepo napravljeno\n" +
                "  Kada se fajl kriptuje, njegon naziv je naziv ulaznog fajla + 'Enc'\n" +
                "  Kada se fajl deriptuje, njegon naziv je naziv ulaznog fajla + 'Dec'\n" +
                "  Moguce je iskoristiti MD5 hash za proveru da li je polazni fajl isti kao onaj koji je kriptovan pa dekriptovan.\n" +
                "  Po ucitavanju fajla, u text boxu 'Pocetni fajl' se pojavljuje MD5 vrednost fajla\n" +
                "  Kada se izvrsi kriptovanje pa dekriptovanje, u text boxu 'Krajnji fajl' se pojavljuje MD5 vrednost fajla\n" +
                "  Klikom na dugme proveri MD5 se uporedjuju te dve vrednosti, ako su jednake, znaci da su fajlovi identicni\n";
            MessageBox.Show(poruka);

        }

        private void btnXTEA_Click(object sender, EventArgs e)
        {
            XTEA_Forma x = new XTEA_Forma();
            x.ShowDialog();
        }

        private void lblNaslov_Click(object sender, EventArgs e)
        {

        }
    }
}
