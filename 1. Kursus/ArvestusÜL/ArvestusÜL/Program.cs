using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvestusÜL
{
	class Auto
	{
		protected static int _autodearv = 0;

		protected string _mark;
		protected int _kohti;
		protected int _reisijaid;

		public Auto(string mark, int kohti)
		{
			_mark = mark;
			_kohti = kohti;
			_reisijaid = 0;

			_autodearv++;
		}

		public virtual void ytleMark()
		{
			Console.WriteLine("Mark: " + _mark);
			Console.WriteLine("Kohti: " + _kohti);
			Console.WriteLine("Reisijaid: " + _reisijaid);
			Console.WriteLine("Sõidukeid maamunal: " + _autodearv);
		}

		public int VabuKohti
		{
			get { return _kohti-_reisijaid; }
			set
			{
				if(value >= 0 && value < _kohti)
				{
					_reisijaid = _kohti - value;
				}
			}
		}

		public void SiseneAutosse(int arv)
		{
			VabuKohti -= arv;
		}
	}

	class Kaubik:Auto, IKaubavedu
	{

		protected double _kaubaruum;
		protected double _kaupa;

		public Kaubik(string mark, double kaubaruum):base(mark, 0)
		{
			_kaubaruum = kaubaruum;
			_kaupa = 0;
		}

		public override void ytleMark()
		{
			Console.WriteLine("Mark: " + _mark);
			Console.WriteLine("Kaubaruum: " + _kaubaruum);
			Console.WriteLine("Kaupa: " + _kaupa);
			Console.WriteLine("Sõidukeid maamunal: " + _autodearv);
		}

		public double VabaKaubaruum
		{
			get { return _kaubaruum - _kaupa; }
			set
			{
				if (value >= 0 && value < _kaubaruum)
				{
					_kaupa = _kaubaruum - value;
				}
			}
		}

		public void LaeEuroAlus()
		{
			VabaKaubaruum -= 1;
		}

		public new void SiseneAutosse(int arv)
		{

		}
	}

	interface IKaubavedu
	{
		void LaeEuroAlus();
	}

	class Program
	{
		static void Main(string[] args)
		{
			Auto audi = new Auto("A4", 5);
			audi.ytleMark();
			audi.VabuKohti = 3;
			audi.ytleMark();

			Kaubik ford = new Kaubik("Ford", 4.5);
			ford.ytleMark();
			ford.VabaKaubaruum = 4;
			ford.ytleMark();
		}
	}
}
