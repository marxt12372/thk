using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vahendaja2
{
	class Program
	{
		static void Main(string[] args)
		{
			Tunnisumeerija t = new Tunnisumeerija();

			t[0] = 1;
			t[0] = 1;
			t[0] = 1;
			Console.WriteLine(t[0]);

			t[6] = 1;
			t[6] = 2;
			t[6] = 3;
			Console.WriteLine(t[6]);
		}
	}
}
