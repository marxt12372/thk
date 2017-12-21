using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiideseHarjutused
{
	interface ISummeerija
	{
		void Alusta();
		void Lisa(int arv);
		int KysiSumma();
	}

	class Summeerija : ISummeerija
	{
		private int _summa;
		public Summeerija()
		{
		}

		public void Alusta()
		{
			_summa = 0;
		}

		public void Lisa(int a)
		{
			_summa += a;
		}

		public int KysiSumma()
		{
			return _summa;
		}
	}

	class MeeldivSummeerija : ISummeerija
	{
		private List<int> _summa = new List<int>();
		public MeeldivSummeerija()
		{
		}

		public void Alusta()
		{
			_summa.Clear();
		}

		public void Lisa(int a)
		{
			_summa.Add(a);
		}

		public int KysiSumma()
		{
			int summa = 0;
			foreach (int i in _summa)
			{
				summa += i;
			}
			return summa;
		}
	}

	class LibaSummeerija : ISummeerija
	{
		public LibaSummeerija()
		{
		}

		public void Alusta()
		{
		}

		public void Lisa(int a)
		{
		}

		public int KysiSumma()
		{
			return -1;
		}
	}

	class SummeerijaVabrik
	{
		public SummeerijaVabrik()
		{
		}

		public static ISummeerija LooSummeerija(int arv)
		{
			if(arv < 0)
			{
				return new LibaSummeerija();
			}
			else if(arv < 10)
			{
				return new MeeldivSummeerija();
			}
			else
			{
				return new Summeerija();
			}
		}
	}

	class Program
	{
		static void Liida(ISummeerija summeer, int i)
		{
			//summeer.Alusta();
			summeer.Lisa(i);
			//Console.WriteLine("Summa: " + summeer.KysiSumma());
		}

		static void Main(string[] args)
		{
			ISummeerija a = SummeerijaVabrik.LooSummeerija(-1);
			for(int i = 1; i <= 5; i++)
			{
				Console.Write("Sisesta üks arv: ");
				int arv = Convert.ToInt32(Console.ReadLine());
				Liida(a, arv);
			}

			Console.WriteLine("Mina olen: " + a.GetType().Name + ", minu summa: " + a.KysiSumma());
		}
	}
}
