using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intekseering
{
	class Program
	{
		static void Main(string[] args)
		{
			Ruuduarvutus r = new Ruuduarvutus();
			Kuubiarvutis k = new Kuubiarvutis();
			
			Console.WriteLine("Ruudud 1 - 20");
			for(int i = 1; i <= 20; i++)
			{
				Console.WriteLine(i + ": " + r[i]);
			}

			Console.WriteLine("Kuubid 1 - 20");
			for (int i = 1; i <= 20; i++)
			{
				Console.WriteLine(i + ": " + k[i]);
			}
		}
	}
}
