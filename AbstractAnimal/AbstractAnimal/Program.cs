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
			Animal loom = new Animal();
			loom.makeNoise();

			Dog koer = new Dog();
			koer.makeNoise();

			Animal loomKoer = new Dog();
			loomKoer.makeNoise();
		}
	}
}
