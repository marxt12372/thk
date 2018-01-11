using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAnimal
{
	class Dog:Animal
	{
		public Dog(int vanus):base(vanus)
		{
		}

		public override void MakeNoise()
		{
			Console.WriteLine("Auh auh auh");
		}
	}
}
