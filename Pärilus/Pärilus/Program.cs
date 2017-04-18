using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pärilus
{
	class Inimene
	{
		protected static List<Inimene> _inimenelist = new List<Inimene>();

		protected string _nimi;
		protected double _pikkus;
		protected double _kaal;
		protected int _vanus;

		public Inimene(string nimi, double pikkus, double kaal, int vanus)
		{
			_nimi = nimi;
			_pikkus = pikkus;
			_kaal = kaal;
			_vanus = vanus;

			_inimenelist.Add(this);
		}

		public Inimene(string nimi, double kaal, int vanus)
		{
			_nimi = nimi;
			_pikkus = -1;
			_kaal = kaal;
			_vanus = vanus;

			_inimenelist.Add(this);
		}

		public void YtleVanus()
		{
			Console.WriteLine("Olen " + _vanus + " aastat vana.");
		}

		public void YtlePikkus()
		{
			Console.WriteLine("Olen " + _pikkus + "cm pikk.");
		}

		public int getPikkus()
		{
			return Convert.ToInt32(_pikkus);
		}

		public static bool KasMahubAllveelaeva(Inimene isik)
		{
			if (isik is Modell)
			{
				if (isik.getPikkus() <= 170) return true;
				return false;
			}
			else
			{
				if (isik.getPikkus() <= 165) return true;
				return false;
			}
		}
	}

	class Modell:Inimene
	{
		private static List<Modell> _modellilist = new List<Modell>();

		private int _ymberm66t;

		public Modell(string nimi, double pikkus, double kaal, int vanus, int ymberm66t) : base(nimi, pikkus, kaal, vanus)
		{
			_ymberm66t = ymberm66t;

			_modellilist.Add(this);
		}

		public Modell(string nimi, double kaal, int vanus, int ymberm66t) : base(nimi, kaal, vanus)
		{
			_ymberm66t = ymberm66t;

			_modellilist.Add(this);
		}

		public void Esitle()
		{
			YtleVanus();
			if (getPikkus() != -1)
			{
				YtlePikkus();
			}
			else
			{
				Console.WriteLine("Pikkuse andmed puuduvad.");
			}
			Console.WriteLine("Minu ümbermõõt on " + _ymberm66t + "cm.");
			Console.WriteLine("Vabandust. Tegelikult olen " + (_vanus-5) + " aastat vana.");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<Inimene> dafuq = new List<Inimene>();

			Inimene tyyp = new Inimene("Mart", 170, 70, 17);
			tyyp.YtleVanus();
			Modell blond = new Modell("Kadri", 170, 55, 25, 40);
			blond.Esitle();

			dafuq.Add(tyyp);
			dafuq.Add(blond);

			foreach(Inimene loll in dafuq)
			{
				Console.WriteLine("Kas mahub allveelaeva: " + Inimene.KasMahubAllveelaeva(loll));
			}

			Console.ReadKey();
		}
	}
}
