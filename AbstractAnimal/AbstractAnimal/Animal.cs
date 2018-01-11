using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAnimal
{
	class Animal:Species
	{
		public Animal(int vanus):base(vanus)
		{
		}

		public virtual void MakeNoise()
		{
			Console.WriteLine("** Looma mõirgamine");
		}

		public override void Greet()
		{
			MakeNoise();
			SayAge();
		}
	}
}
