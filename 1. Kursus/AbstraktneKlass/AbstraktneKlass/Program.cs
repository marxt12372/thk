using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraktneKlass
{
	abstract class Kujund
	{
		public abstract double getPohjapindala();
		public abstract double getKorgus();
		public abstract double getPohjaYmbermoot();

		public double getKyljePindala()
		{
			return getPohjaYmbermoot() * getKorgus();
		}

		public double getRuumala()
		{
			return getPohjapindala() * getKorgus();
		}
	}

	class Tikutops : Kujund
	{
		public override double getPohjapindala()
		{
			return 8.0;
		}

		public override double getKorgus()
		{
			return 1.5;
		}

		public override double getPohjaYmbermoot()
		{
			return 2+2+4+4;
		}
	}

	class Vorstijupp : Kujund
	{
		private double _pikkus;
		private double _raadius;

		public Vorstijupp(double pikkus, double raadius)
		{
			_pikkus = pikkus;
			_raadius = raadius;
		}

		public override double getPohjapindala()
		{
			return Math.PI * _raadius * _raadius;
		}

		public override double getKorgus()
		{
			return _pikkus;
		}

		public override double getPohjaYmbermoot()
		{
			return 2 * Math.PI  * _raadius;
		}
	}

	class Risttahukas : Kujund
	{
		private double _x;
		private double _y;
		private double _h;

		public Risttahukas(double x, double y, double h)
		{
			_x = x;
			_y = y;
			_h = h;
		}

		public override double getKorgus()
		{
			return _h;
		}

		public override double getPohjapindala()
		{
			return _x * _y;
		}

		public override double getPohjaYmbermoot()
		{
			return _x + _x + _y + _y;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			/*Tikutops tops = new Tikutops();
			Console.WriteLine("Tikutopsi ruumala: " + tops.getRuumala());

			Vorstijupp jupp = new Vorstijupp(60, 15);

			Console.WriteLine("Vorstijuppi ruumala: " + Math.Round(jupp.getRuumala()/1000000) + " liitrit.");*/

			//Risttahukas tahukas = new Risttahukas(5, 10, 20);
			//Console.WriteLine("Risttahuka ruumala on " + tahukas.getRuumala() + ", ning selle küljepindala on " + tahukas.getKyljePindala());

			List<Kujund> kujundid = new List<Kujund>();

			for (int i = 1; i <= 25; i++)
			{
				Risttahukas aa = new Risttahukas(i, i * 2, i * 4);
				kujundid.Add(aa);
			}

			for (int i = 1; i <= 12; i++)
			{
				Vorstijupp aa = new Vorstijupp(i*2, i);
				kujundid.Add(aa);
			}

			Console.WriteLine("Tahukate ruumalad: " + Math.Round(ruumaladeSumma(kujundid), 2));
			Console.WriteLine("Tahukate külje pindalad: " + Math.Round(kyljepindaladeSumma(kujundid), 2));
		}

		public static double ruumaladeSumma(List<Kujund> kujundid)
		{
			double summa = 0.0;
			foreach (Kujund kujund in kujundid)
			{
				summa += kujund.getRuumala();
			}
			return summa;
		}

		public static double kyljepindaladeSumma(List<Kujund> kujundid)
		{
			double summa = 0.0;
			foreach(Kujund kujund in kujundid)
			{
				summa += kujund.getKyljePindala() + (2*(kujund.getPohjapindala()));
			}
			return summa;
		}
	}
}
