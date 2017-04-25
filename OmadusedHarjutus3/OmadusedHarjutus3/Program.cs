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

		public Inimene(DateTime synna)
		{
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
				return (DateTime.Now - _synnipaev).Days / 365;
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Inimene mina = new Inimene(new DateTime(2000, 2, 20));
			Console.WriteLine("Minu vanus: " + mina.Vanus + " aastat.");
		}
	}
}
