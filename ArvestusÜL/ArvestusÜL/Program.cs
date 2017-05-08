using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvestusÜL
{
	class Auto
	{
		protected string _mark;
		protected int _kohti;
		protected int _reisijaid;

		public Auto(string mark, int kohti)
		{
			_mark = mark;
			_kohti = kohti;
			_reisijaid = 0;
		}

		public void ytleMark()
		{
			Console.WriteLine("Mark: " + _mark);
			Console.WriteLine("Kohti: " + _kohti);
			Console.WriteLine("Reisijaid: " + _reisijaid);
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
	}


	class Program
	{
		static void Main(string[] args)
		{
			Auto audi = new Auto("A4", 5);
			audi.ytleMark();
			audi.VabuKohti = 3;
			audi.ytleMark();
		}
	}
}
