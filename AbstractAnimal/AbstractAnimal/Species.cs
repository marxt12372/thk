using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAnimal
{
	abstract class Species
	{
		private int _vanus;

		public Species(int vanus)
		{
			_vanus = vanus;
		}

		public void SayAge()
		{
			Console.WriteLine("Vanus: " + _vanus);
		}

		public abstract void Greet();
	}
}
