using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiideseHarjutused2
{
	interface IMootorSõiduk
	{
		void KäivitaMootor();
		void SeiskaMootor();
		void Kiirenda(int kiirus);
		int getKiirus();
	}

	class Auto : Mootorratas
	{
		public Auto(string kirj):base(kirj)
		{
		}

		public new void YtleAndmed()
		{
			Console.WriteLine("---" + _kirjeldus + "---");
			Console.WriteLine("Mootor: " + _mootor);
			Console.WriteLine("Kiirus: " + _kiirus);
		}

		public new void Kiirenda(int kiirus)
		{
			if (kiirus > 0)
			{
				if (_mootor)
				{
					_kiirus += kiirus;
				}
				else
				{
					Console.WriteLine("Sa ei jaksa autot üksinda lükata.");
				}
			}
			else
			{
				_kiirus += kiirus;
				if (_kiirus < 0)
				{
					_kiirus = 0;
				}
			}
		}
	}

	class Mootorratas : IMootorSõiduk
	{
		protected bool _mootor;
		protected int _kiirus;
		protected string _kirjeldus;

		public Mootorratas(string kirj)
		{
			_kirjeldus = kirj;
		}

		public void YtleAndmed()
		{
			Console.WriteLine("---" + _kirjeldus + "---");
			Console.WriteLine("Mootor: " + _mootor);
			Console.WriteLine("Kiirus: " + _kiirus);
		}

		public void KäivitaMootor()
		{
			_mootor = true;
		}

		public void SeiskaMootor()
		{
			if(_kiirus == 0)
			{
				_mootor = false;
			}
		}

		public void Kiirenda(int kiirus)
		{
			if (kiirus > 0)
			{
				if (_mootor)
				{
					_kiirus += kiirus;
				}
				else
				{
					_kiirus += kiirus / 8;
					if(_kiirus > 20)
					{
						_kiirus = 20;
					}
					Console.WriteLine("No lükka siis kui tahad...");
				}
			}
			else
			{
				_kiirus += kiirus;
				if (_kiirus < 0)
				{
					_kiirus = 0;
				}
			}
		}

		public int getKiirus()
		{
			return _kiirus;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Auto ülbik = new Auto("Roosa A5");
			Mootorratas peeglilõhkuja = new Mootorratas("REPSOL CBR600R");

			ülbik.Kiirenda(60);
			ülbik.KäivitaMootor();
			ülbik.Kiirenda(60);
			ülbik.YtleAndmed();

			peeglilõhkuja.Kiirenda(225);
			peeglilõhkuja.YtleAndmed();
			peeglilõhkuja.KäivitaMootor();
			peeglilõhkuja.Kiirenda(225);
			peeglilõhkuja.YtleAndmed();
			peeglilõhkuja.SeiskaMootor();
			peeglilõhkuja.Kiirenda(-250);
			peeglilõhkuja.YtleAndmed();
		}
	}
}
