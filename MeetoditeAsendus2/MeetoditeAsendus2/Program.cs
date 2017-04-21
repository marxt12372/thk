using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetoditeAsendus2
{
	class Punkt
	{
		protected int _x;
		protected int _y;

		public Punkt(int x, int y)
		{
			_x = x;
			_y = y;
		}

		public virtual double kaugusNullist()
		{
			return Math.Sqrt(Math.Pow(Math.Abs(_x),2) + Math.Pow(Math.Abs(_y),2));
		}

		public void teataAndmed()
		{
			Console.WriteLine("--Punkt--");
			Console.WriteLine("X: " + _x);
			Console.WriteLine("Y: " + _y);
		}
	}

	class RuumiPunkt:Punkt
	{
		private int _z;

		public RuumiPunkt(int x, int y, int z):base(x, y)
		{
		}

		public override double kaugusNullist()
		{
			Console.WriteLine("3d kaugusnullist");
			return Math.Sqrt(Math.Pow(Math.Abs(_x), 2) + Math.Pow(Math.Abs(_y), 2) + Math.Pow(Math.Abs(_z), 2));
		}

		public new void teataAndmed()
		{
			Console.WriteLine("--Punkt--");
			Console.WriteLine("X: " + _x);
			Console.WriteLine("Y: " + _y);
			Console.WriteLine("Z: " + _z);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Punkt p1 = new Punkt(1, 1);
			Punkt p2 = new Punkt(1, 1), p3 = p1;
			p1.teataAndmed();
			p2.teataAndmed();
			p3.teataAndmed();

			RuumiPunkt rp1 = new RuumiPunkt(1, 1, 1);
			RuumiPunkt rp2 = new RuumiPunkt(1, 1, 1), rp3 = rp1;
			Punkt p8 = new Punkt(1, 1), p9 = rp1;
			p9.teataAndmed();
			Console.WriteLine("kag: " + p9.kaugusNullist());
			rp3.teataAndmed();
			Console.WriteLine("rp3 on: " + rp3.GetType().ToString());
			Console.WriteLine("p9 on: " + p9.GetType().ToString());
		}
	}
}
