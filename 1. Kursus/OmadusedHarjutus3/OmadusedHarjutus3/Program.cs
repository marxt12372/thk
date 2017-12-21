using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmadusedHarjutus3
{
	class Inimene
	{
		private string _nimi;
		private DateTime _synnipaev;

		public Inimene(string nimi, DateTime synna)
		{
			_nimi = nimi;
			_synnipaev = synna;
		}

		public string Nimi
		{
			get
			{
				return _nimi;
			}

			set
			{
				_nimi = value;
			}
		}

		public int Vanus
		{
			get
			{
				return (int) ((DateTime.Now - _synnipaev).Days / 365.25);
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Inimene mina = new Inimene("Mart", new DateTime(2000, 4, 24));
			Console.WriteLine(mina.Nimi + " vanus: " + mina.Vanus + " aastat.");
		}
	}
}
