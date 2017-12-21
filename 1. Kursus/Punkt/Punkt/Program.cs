using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punkt
{
	class Vector2
	{
		public double X;
		public double Y;

		public Vector2(double x, double y)
		{
			X = x;
			Y = y;
		}

		public Vector2()
		{
			X = 0.0;
			Y = 0.0;
		}

		public static double getDistanceBetweenPoints(Vector2 pos1, Vector2 pos2)
		{
			//return Math.Round((pos1.X - pos2.X) * (pos1.Y - pos2.Y) * (pos1.Z - pos2.Z));
			return Math.Sqrt(Math.Pow(Math.Abs(pos2.X - pos1.X), 2) + Math.Pow(Math.Abs(pos2.Y - pos1.Y), 2));
		}

		public virtual double getDistanceFromZero()
		{
			return getDistanceBetweenPoints(new Vector2(0.0, 0.0), new Vector2(X, Y));
		}

		public virtual void KuvaAndmed()
		{
			Console.WriteLine("Kaugus nullist: " + getDistanceFromZero());
			Console.WriteLine("X: " + X);
			Console.WriteLine("Y: " + Y);
		}
	}

	class Vector3:Vector2
	{
		public double Z;

		public Vector3(double x, double y, double z):base(x, y)
		{
			Z = z;
		}

		public Vector3():base(0.0, 0.0)
		{
			Z = 0.0;
		}

		public static double getDistanceBetweenPoints(Vector3 pos1, Vector3 pos2)
		{
			//return Math.Round((pos1.X - pos2.X) * (pos1.Y - pos2.Y) * (pos1.Z - pos2.Z));
			return Math.Sqrt(Math.Pow(Math.Abs(pos2.X - pos1.X), 2) + Math.Pow(Math.Abs(pos2.Y - pos1.Y), 2) + Math.Pow(Math.Abs(pos2.Z - pos1.Z), 2));
		}

		public override double getDistanceFromZero()
		{
			return getDistanceBetweenPoints(new Vector3(0.0, 0.0, 0.0), new Vector3(X, Y, Z));
		}

		public override void KuvaAndmed()
		{
			base.KuvaAndmed();
			Console.WriteLine("Z: " + Z);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Vector2 a = new Vector2(3.0, 4.0);
			a.KuvaAndmed();
			/*Console.WriteLine("Distance: " + Vector3.getDistanceBetweenPoints(new Vector3(-1, 2, -25), new Vector3(1, 1, 1)));
			Console.WriteLine("Distance: " + Vector3.getDistanceBetweenPoints(new Vector3(-25, -25, -25), new Vector3(25, 25, 25)));
			Console.WriteLine("Distance: " + Vector2.getDistanceBetweenPoints(new Vector2(-3, -4), new Vector2(3, 4)));*/
			Console.ReadKey();
		}
	}
}
