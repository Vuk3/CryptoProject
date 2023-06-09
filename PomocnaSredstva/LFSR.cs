using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_Projekat_18036.PomocnaSredstva
{
    class LFSR
    {

		public string registar = "";
		public int[] XORbitovi;
		public int konstantanBit;
		public LFSR()
		{

		}
		public char Shiftuj(char noviKarakter)
		{
			if (this.registar.Length == 0) 
				return ' ';

			char[] registarNizKaraktera = this.registar.ToCharArray();

			char poslednjiKarakter = izlazniKarakter();

			for (int i = this.registar.Length - 1; i > 0; i--)
			{
				registarNizKaraktera[i] = this.registar[i - 1];
			}

			registarNizKaraktera[0] = noviKarakter;

			this.registar = this.nizKarakteraUString(registarNizKaraktera);

			return poslednjiKarakter;
		}

		public string nizKarakteraUString(char[] start)
		{
			string ret = "";
			for (int i = 0; i < start.Length; i++)
			{
				ret += start[i];
			}

			return ret;
		}
		public char izlazniKarakter()
		{
			return this.registar[this.registar.Length - 1];
		}
	}
}
