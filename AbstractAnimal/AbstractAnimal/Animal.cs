using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAnimal
{
	class Animal
	{
		public virtual void makeNoise()
		{
			Console.WriteLine("** Looma mõirgamine");
		}
	}
}
