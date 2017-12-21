using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmadusedHarjutus2
{
	class Kasutaja
	{
		private string _kasutajanimi;
		private string _parool;
		private string _telefoninr;

		public Kasutaja(string kasutajanimi)
		{
			_kasutajanimi = kasutajanimi;
			_parool = "";
		}

		public string Kasutajanimi
		{
			get
			{
				return _kasutajanimi;
			}
		}

		public string Parool
		{
			set
			{
				if (Kasutaja.isValidParool(value))
				{
					_parool = value;
				}
				else throw new Exception("Parool ei ole piisavalt turvaline");
			}
		}

		public string Telnr
		{
			get
			{
				return _telefoninr;
			}

			set
			{
				_telefoninr = value;
			}
		}

		public bool KontrolliParooli(string parool)
		{
			if(parool == _parool)
			{
				return true;
			}
			return false;
		}

		public static bool isValidParool(string parool)
		{
			List<char> numbers = "0123456789".ToList();
			List<char> characters = "abcdefghijklmnopqrstuvwöäõüxyz".ToList();
			List<char> symbls = "<>|!,.-_?+=)([]&€%$#£@".ToList();

			int numbreid = 0;
			int karaktereid = 0;
			int upperkaraktereid = 0;
			int symboleid = 0;

			foreach (char number in numbers)
			{
				if (parool.Contains(number)) { numbreid++; }
			}

			foreach (char karakter in characters)
			{
				if (parool.Contains(karakter)) { karaktereid++; }
			}

			foreach (char karakter in characters)
			{
				if (parool.Contains(char.ToUpper(karakter))) { upperkaraktereid++; }
			}

			foreach (char symbol in symbls)
			{
				if (parool.Contains(char.ToUpper(symbol))) { symboleid++; }
			}

			if (numbreid > 0 && karaktereid > 0 && upperkaraktereid > 0 && symboleid > 0 && parool.Length >= 8)
			{
				return true;
			}

			return false;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			/*Kasutaja player = new Kasutaja("marxt12372");
			player.Parool = "progeja";
			//player.Kasutajanimi = "yoyo";
			//Console.WriteLine("Kasutaja " + player.Kasutajanimi + " parool on " + player.Parool);
			Console.WriteLine("Kasutaja " + player.Kasutajanimi + " parool on \"pelur\"? - " + player.KontrolliParooli("pelur"));
			player.Telnr = "56881414";
			Console.WriteLine("Kasutaja " + player.Kasutajanimi + " telefoninumber on " + player.Telnr);
			Console.ReadKey();*/
			Kasutaja mina = new Kasutaja("Mart");
			string nimi = mina.Kasutajanimi;
			try
			{
				mina.Parool = "ammon";
			}
			catch(Exception e)
			{
				Console.WriteLine("Error: " + e.Message);
			}
			mina.Telnr = "555555";
			string nr = mina.Telnr;
			Console.Write("Mis on sinu parool, " + mina.Kasutajanimi + ": ");
			string parool = Console.ReadLine();
			if(mina.KontrolliParooli(parool))
			{
				Console.Write("Sisesta oma telefoni number: ");
				string num = Console.ReadLine();
				if (num != string.Empty)
				{
					mina.Telnr = num;
					Console.WriteLine("Minu number on " + mina.Telnr);
				}

				Console.WriteLine("Kohustatud paroolimuutus.");
				string uusparool;
				do
				{
					Console.Write("Sisesta uus parool(8 märki, suured, väiksed, numbrid, sümbolid): ");
					uusparool = Console.ReadLine();
				}
				while (!Kasutaja.isValidParool(uusparool));
				mina.Parool = uusparool;
				Console.WriteLine("Parool on muudetud.");
			}
			else
			{
				Console.WriteLine("Vale parool.");
			}
			Console.ReadKey();
		}
	}
}
