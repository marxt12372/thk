using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiideseNäide
{
	class Inimene
	{
		protected int _vanus;
		public Inimene(int van)
		{
			_vanus = van;
		}

		public virtual void sayAge()
		{
			Console.WriteLine("Vanus: " + _vanus);
		}
	}

	interface IViisakas
	{
		void tervita(string tuttav);
	}

	class Laps:Inimene, IViisakas
	{
		public Laps(int vanus):base(vanus)
		{
		}

		public void tervita(string tuttav)
		{
			Console.WriteLine("Tere, " + tuttav);
		}
	}

	class Koer:IViisakas
	{
		public void tervita(string tuttav)
		{
			Console.WriteLine("Auh!");
		}
	}

	class Program
	{
		static void TuleSünnipäevale(IViisakas v)
		{
			v.tervita("vanaema");
		}

		static void Main(string[] args)
		{
			Laps titt = new Laps(1);
			Koer kass = new Koer();
			titt.tervita("äää");
			kass.tervita("a");
			TuleSünnipäevale(titt);
		}
	}
}
