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
    class A52
    {
		public LFSR R1;
		public LFSR R2;
		public LFSR R3;
		public LFSR R4;

		public string kljuc1;
		public string kljuc2;
		public A52()
		{
            this.postaviDefaultKljuc();

            R1 = new LFSR();
			R2 = new LFSR();
			R3 = new LFSR();
			R4 = new LFSR();

			R1.XORbitovi = new int[] { 13, 16, 17, 18 };
			R2.XORbitovi = new int[] { 20, 21 };
			R3.XORbitovi = new int[] { 7, 20, 21, 22 };
			R4.XORbitovi = new int[] { 11, 16 };

			R1.registar = "0000000000000000000";
			R2.registar = "0000000000000000000000";
			R3.registar = "00000000000000000000000";
			R4.registar = "00000000000000000";

			R1.konstantanBit = 15;
			R2.konstantanBit = 16;
			R3.konstantanBit = 18;
			R4.konstantanBit = 10;


		}

		public A52(string kljuc1, string kljuc2) : this()
		{

			this.kljuc1 = kljuc1;
			this.kljuc2 = kljuc2;

            unesiKljucURegistre();
        }

		public void unesiKljucURegistre()
        {

			ShiftujRegistar(R4);


			char[] r1Niz = R1.registar.ToCharArray();
			char[] r2Niz = R2.registar.ToCharArray();
			char[] r3Niz = R3.registar.ToCharArray();
			char[] r4Niz = R4.registar.ToCharArray();

			foreach (char c in kljuc1)
            {
				ShiftujRegistar(R1);
				ShiftujRegistar(R2);
				ShiftujRegistar(R3);
				ShiftujRegistar(R4);

				r1Niz = R1.registar.ToCharArray();
				r2Niz = R2.registar.ToCharArray();
				r3Niz = R3.registar.ToCharArray();
				r4Niz = R4.registar.ToCharArray();

				r1Niz[0] = XOR(r1Niz[0], c);
				r2Niz[0] = XOR(r2Niz[0], c);
				r3Niz[0] = XOR(r3Niz[0], c);
				r4Niz[0] = XOR(r4Niz[0], c);

				R1.registar = R1.nizKarakteraUString(r1Niz);
				R2.registar = R2.nizKarakteraUString(r2Niz);
				R3.registar = R3.nizKarakteraUString(r3Niz);
				R4.registar = R4.nizKarakteraUString(r4Niz);
			}

			foreach (char c in kljuc2)
			{
				ShiftujRegistar(R1);
				ShiftujRegistar(R2);
				ShiftujRegistar(R3);
				ShiftujRegistar(R4);

				r1Niz = R1.registar.ToCharArray();
				r2Niz = R2.registar.ToCharArray();
				r3Niz = R3.registar.ToCharArray();
				r4Niz = R4.registar.ToCharArray();

				r1Niz[0] = XOR(r1Niz[0], c);
				r2Niz[0] = XOR(r2Niz[0], c);
				r3Niz[0] = XOR(r3Niz[0], c);
				r4Niz[0] = XOR(r4Niz[0], c);

				R1.registar = R1.nizKarakteraUString(r1Niz);
				R2.registar = R2.nizKarakteraUString(r2Niz);
				R3.registar = R3.nizKarakteraUString(r3Niz);
				R4.registar = R4.nizKarakteraUString(r4Niz);
			}

			r1Niz = R1.registar.ToCharArray();
			r2Niz = R2.registar.ToCharArray();
			r3Niz = R3.registar.ToCharArray();
			r4Niz = R4.registar.ToCharArray();

			r1Niz[R1.konstantanBit] = '1';
			r2Niz[R2.konstantanBit] = '1';
			r3Niz[R3.konstantanBit] = '1';
			r4Niz[R4.konstantanBit] = '1';


			R1.registar = R1.nizKarakteraUString(r1Niz);
			R2.registar = R2.nizKarakteraUString(r2Niz);
			R3.registar = R3.nizKarakteraUString(r3Niz);
			R4.registar = R4.nizKarakteraUString(r4Niz);


        }
		public void postaviDefaultKljuc()
		{
			this.kljuc1 = "0101010101010101010101010101010101010101010101010101010101010101";
			this.kljuc2 = "0101010101010101010101";
		}

		public char XOR(char a, char b)
		{
			if (a == b)
				return '0';
			else
				return '1';
		}
		public char ShiftujRegistar(LFSR sr)
		{
			char t = '0';
			foreach (int index in sr.XORbitovi)
			{
				t = XOR(t, sr.registar[index]);
			}

			return sr.Shiftuj(t);
		}

		public char bitParnosti(char a, char b, char c)
		{
			int brojJedinica = 0;
			if (a == '1')
				brojJedinica++;
			if (b == '1')
				brojJedinica++;
			if (c == '1')
				brojJedinica++;

			if (brojJedinica % 2 == 1)

				return '1';
			else
				return '0';
		}

		public string Encrypt(string ulaz, bool enc)
		{
			string izlaz = "";
			string ulazBitovi;
			if (enc)
				ulazBitovi = stringUNizBitova(ulaz);
			else
				ulazBitovi = ulaz;

			char r1, r2, r3;

			char q = R4.registar[10];
			char w = R4.registar[3];
			char e = R4.registar[7];

			char m, m1, m2, m3;

			foreach (char c in ulazBitovi)
			{
				//Bit parnosti za siftovanje registara

				m = bitParnosti(q,w,e);

				if (q == m)
					r1 = ShiftujRegistar(R1);
				else
					r1 = R1.izlazniKarakter();

                if (w == m)
                    r2 = ShiftujRegistar(R2);
				else
					r2 = R2.izlazniKarakter();

				if (e == m)
					r3 = ShiftujRegistar(R3);
				else
					r3 = R3.izlazniKarakter();


				ShiftujRegistar(R4);

				q = R4.registar[10];
				w = R4.registar[3];
				e = R4.registar[7];

				//Bit parnosti za R1

				//Odradjen je xor bita 14 sa 1
				m1 = bitParnosti(R1.registar[15],R1.registar[14]=='1'?'0':'1', R1.registar[12]);


				//Bit parnosti za R2

				//Odradjen je xor bita 16 sa 1
				m2 = bitParnosti(R2.registar[16] == '1' ? '0' : '1', R2.registar[13], R2.registar[9]);


				//Bit parnosti za R3

				//Odradjen je xor bita 13 sa 1
				m3 = bitParnosti(R1.registar[18], R1.registar[16], R1.registar[13] == '1' ? '0' : '1');


				char s = '0';
                s = XOR(XOR(XOR(XOR(XOR(XOR(s, r1), r2), r3),m1),m2),m3);

				izlaz += XOR(s, c);
			}
			if (enc)
				return izlaz;
			else
				return BitoviUString(izlaz);

		}

		public string stringUNizBitova(string s)
        {
			return  string.Join("", Encoding.UTF8.GetBytes(s).Select(n => Convert.ToString(n, 2).PadLeft(8, '0')));
		}
		public string BitoviUString(string podaci)
		{
			List<Byte> listaBajtova = new List<byte>();

			for (int i = 0; i < podaci.Length; i += 8)
			{
				listaBajtova.Add(Convert.ToByte(podaci.Substring(i, 8), 2));
			}
			return Encoding.UTF8.GetString(listaBajtova.ToArray());
		}

		public string Decrypt(string ulaz, bool enc)
		{
			return Encrypt(ulaz, enc);
		}
	}
}
