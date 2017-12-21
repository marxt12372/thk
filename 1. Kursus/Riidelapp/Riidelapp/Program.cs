using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riidelapp
{
	class Riidelapp
	{
		public static List<Riidelapp> lapilist = new List<Riidelapp>();
		public static int loendur = 0;
		private int _pikkus;
		private int _laius;
		private int _nr;
		private string _toon;

		public Riidelapp(int pikkus, int laius, string toon)
		{
			_pikkus = pikkus;
			_laius = laius;
			_toon = toon;
			_nr = ++loendur;
			lapilist.Add(this);
		}

		public double getPindala()
		{
			return (double) _pikkus * _laius;
		}

		public bool isKalts()
		{
			return _pikkus < 50 || _laius < 50;
		}

		public int annaPindala()
		{
			return _pikkus * _laius;
		}

		public static double annaKeskminePindala()
		{
			if (lapilist.Count > 0)
			{

				double kogupindala = 0.0;
				foreach (Riidelapp lapp in lapilist)
				{
					kogupindala = kogupindala + lapp.getPindala();
				}
				return kogupindala / lapilist.Count;
			}
			else
			{
				return -1;
			}
		}

		public static double annaKoguPindala()
		{
			if (lapilist.Count > 0)
			{

				double kogupindala = 0.0;
				foreach (Riidelapp lapp in lapilist)
				{
					kogupindala = kogupindala + lapp.getPindala();
				}
				return kogupindala;
			}
			else
			{
				return -1;
			}
		}

		public static void prindiStat()
		{
			Console.WriteLine("Riidelappe kokku: " + loendur);
			Console.WriteLine("Kogupindala: " + (double) annaKoguPindala()/10000 + " ruutmeetrit");
			Console.WriteLine("Keskmine pindala: " + (double) annaKeskminePindala()/10000 + " ruutmeetrit");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			//Riidelapp.prindiStat();
			Riidelapp[] mas1 = new Riidelapp[50];
			Riidelapp[] mas2 = new Riidelapp[50];

			for (int i = 0; i < mas1.Length; i++)
			{
				mas1[i] = new Riidelapp(i * 5, i * 2, "värvikas");
			}

			for(int i = 0; i < mas2.Length; i++)
			{
				if(mas1[i].isKalts())
				{
					mas2[i] = mas1[i];
				}
			}

			int pindala = 0;
			for (int i = 0; i < mas1.Length; i++)
			{
				pindala = pindala + mas1[i].annaPindala();
			}
			Console.WriteLine("mas1 kogupindala on " + (double) pindala/10000 + " ruutmeetrit");

			pindala = 0;
			for (int i = 0; i < mas2.Length; i++)
			{
				if (mas2[i] != null)
				{
					pindala = pindala + mas2[i].annaPindala();
				}
			}
			Console.WriteLine("mas2 kogupindala on " + (double) pindala / 10000 + " ruutmeetrit");

			Console.WriteLine("Kogupindala keskmine on " + (double) Riidelapp.annaKeskminePindala() / 10000 + " ruutmeetrit");
			Riidelapp.prindiStat();
			Console.ReadKey();
		}
	}
}
