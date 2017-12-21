using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraktneHarjutus2
{
	abstract class Kujund
	{
		public abstract double getPindala();
		public abstract double getYmbermoot();

		private int _kylgedeArv;

		public Kujund(int kylgi)
		{
			_kylgedeArv = kylgi;
		}

		public int getKylgedeArv()
		{
			return _kylgedeArv;
		}
	}

	interface Muudetav
	{
		void MuudaSuurust(double x);
	}

	class Ristkylik:Kujund,Muudetav
	{
		private double _pikkus;
		private double _laius;

		public Ristkylik(double pikkus, double laius):base(4)
		{
			_pikkus = pikkus;
			_laius = laius;
		}

		public override double getPindala()
		{
			return _laius * _pikkus;
		}

		public override double getYmbermoot()
		{
			return 2 * (_laius + _pikkus);
		}

		public void MuudaSuurust(double x)
		{
			_pikkus = _pikkus * x;
			_laius = _laius * x;
		}
	}

	class TaisnurkneKolmnurk:Kujund
	{
		private double _korgus;
		private double _laius;

		public TaisnurkneKolmnurk(double laius, double korgus):base(3)
		{
			_laius = laius;
			_korgus = korgus;
		}

		public override double getPindala()
		{
			return (_laius * _korgus) / 2;
		}

		public override double getYmbermoot()
		{
			double m66t = 0.0;
			m66t += _laius + _korgus;
			m66t += Math.Sqrt(Math.Pow(_laius, 2) + Math.Pow(_korgus, 2));
			return m66t;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Ristkylik kylik = new Ristkylik(2, 2);
			Console.WriteLine("Ristküliku pindala on " + kylik.getPindala() + " ja ümbermõõt on " + kylik.getYmbermoot());
			kylik.MuudaSuurust(2);
			Console.WriteLine("Ristküliku pindala on " + kylik.getPindala() + " ja ümbermõõt on " + kylik.getYmbermoot());

			TaisnurkneKolmnurk kolmnurk = new TaisnurkneKolmnurk(5, 3);
			Console.WriteLine("Kolmnurga pindala on " + kolmnurk.getPindala() + " ning ümbermõõt on " + Math.Round(kolmnurk.getYmbermoot(), 2));
		}
	}
}
