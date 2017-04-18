using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassiMuutuja
{
    class Punkt
    {
        public static List<Punkt> punktid = new List<Punkt>();
        private static int loendur = 0;
        private int _nr;
        private int _x;
        private int _y;
        public Punkt(int x, int y)
        {
            _x = x;
            _y = y;
            _nr = ++loendur;
            punktid.Add(this);
        }

        public void trykiKordinaadid()
        {
            Console.WriteLine("({0}) {1}:{2}", _nr, _x, _y);
        }
    }

	class ValeIsikukood:Exception
	{
		public ValeIsikukood()
		{
			Console.WriteLine("Vale isikukood");
		}
	}

	class Isikukood
	{
		private int _isikukood;

		public Isikukood(int isikukood)
		{
			if(isikukood.ToString().Length == 11)
			{
				_isikukood = isikukood;
			}
			else throw new ValeIsikukood();
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			/*Punkt p1 = new Punkt(1, 1);
            Punkt p2 = new Punkt(3, 2);
            Punkt p3 = new Punkt(8, 6);
			Punkt[] mas = new Punkt[10];
			Punkt[] mas2 = new Punkt[10];
			for (int i = 0; i < 10; i++)
			{
				mas[i] = new Punkt(i + 1, i + 1);
			}
			for (int i = 0; i < mas2.Length; i++)
			{
				mas2[i] = new Punkt(10 - i, i+1);
			}
			p1.trykiKordinaadid();
            p2.trykiKordinaadid();
            p3.trykiKordinaadid();
			foreach (Punkt p in Punkt.punktid)
			{
                p.trykiKordinaadid();
            }*/
            Console.ReadKey();
        }
    }
}
