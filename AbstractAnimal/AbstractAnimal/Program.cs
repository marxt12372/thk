using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAnimal
{
	class Program
	{
		static void Main(string[] args)
		{
			Animal loom = new Animal(10);
			loom.MakeNoise();
			Console.WriteLine();

			Dog koer = new Dog(2);
			koer.MakeNoise();
			Console.WriteLine();

			Animal loomKoer = new Dog(2);
			loomKoer.MakeNoise();
			loomKoer.Greet();
			Console.WriteLine();

			//Species species = new Species(50);
		}
	}
}
