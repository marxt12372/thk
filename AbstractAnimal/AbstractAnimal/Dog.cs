using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAnimal
{
	class Dog:Animal
	{
		public override void makeNoise()
		{
			Console.WriteLine("Auh auh auh");
		}
	}
}
