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
				_parool = value;
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
	}
	class Program
	{
		static void Main(string[] args)
		{
			Kasutaja player = new Kasutaja("marxt12372");
			player.Parool = "progeja";
			//player.Kasutajanimi = "yoyo";
			//Console.WriteLine("Kasutaja " + player.Kasutajanimi + " parool on " + player.Parool);
			Console.WriteLine("Kasutaja " + player.Kasutajanimi + " parool on \"pelur\"? - " + player.KontrolliParooli("pelur"));
			player.Telnr = "56881414";
			Console.WriteLine("Kasutaja " + player.Kasutajanimi + " telefoninumber on " + player.Telnr);

		}
	}
}
