using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//OOPArvestus Ammon Mart - Markus

namespace OOPArvestus
{
	interface INaaber
	{
		void tervitaNaabrit();
	}

	class Maja
	{
		protected int _tubasi;
		protected int _magamistube;
		protected int _korruseid;

		protected static int _tubeKokku;

		public Maja(int tube, int korruseid)
		{
			_tubasi = tube;
			_korruseid = korruseid;
			_tubeKokku += tube;
		}

		public virtual void helistaKella()
		{
			Console.WriteLine("Helistame maja kella.\nUksele tuleb 1 perekond.");
		}

		public int Magamistube {
			get { return _magamistube; }
			set
			{
				_magamistube = value;
				if (_magamistube > _tubasi)
				{
					_magamistube = _tubasi;
				}
				if (_magamistube < 0)
				{
					_magamistube = 0;
				}
			}
		}

		public void renoveeri(int arv)
		{
			_magamistube += arv;
			if(_magamistube > _tubasi)
			{
				_magamistube = _tubasi;
			}
			if(_magamistube < 0)
			{
				_magamistube = 0;
			}
		}

		public static int TubeKokku {
			get { return _tubeKokku; }
		}
	}

	class Ridaelamu:Maja,INaaber
	{
		protected int _naabreid;

		public Ridaelamu(int tube, int korruseid, int naabreid):base(tube, korruseid)
		{
			_naabreid = naabreid;
		}

		public override void helistaKella()
		{
			Console.WriteLine("Helistame ridaelamu kella.\nUksele tuleb " + (_naabreid+1) + " perekonda.");
		}

		public void tervitaNaabrit()
		{
			if (_naabreid > 0)
			{
				for (int i = 1; i <= _naabreid; i++)
				{
					Console.WriteLine("Tere, naaber {0}.", i);
				}
			}
		}

		public new void renoveeri(int arv)
		{
			if (_naabreid > 0)
			{
				_naabreid -= arv;
			}
			if(_naabreid < 0)
			{
				_naabreid = 0;
			}
		}

		public int Naabreid {
			get { return _naabreid; }
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			Maja maja = new Maja(5, 2);
			maja.Magamistube = 3;
			Console.WriteLine("Majal on {0} magamistuba.", maja.Magamistube);
			maja.helistaKella();
			maja.renoveeri(1);
			Console.WriteLine("Majal on pärast renoveeringut {0} magamistuba.", maja.Magamistube);
			Console.WriteLine("\n");

			Ridaelamu elamu = new Ridaelamu(9, 2, 2);
			elamu.Magamistube = 6;
			elamu.helistaKella();
			elamu.tervitaNaabrit();
			Console.WriteLine("Ridaelamul on {0} naabrit.", elamu.Naabreid);
			elamu.renoveeri(1);
			Console.WriteLine("Ridaelamul on pärast renoveeringut {0} naabrit.", elamu.Naabreid);

			Console.WriteLine("\n");
			Console.WriteLine("Tubasi kokku on " + Maja.TubeKokku);

			Console.ReadKey();
        }
    }
}
