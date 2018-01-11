using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vahendaja1
{
	class Program
	{
		static void Main(string[] args)
		{
			Kirjutaja k = new Kirjutaja("Mart.");

			for (int i = 0; i < k.Length; i++)
			{
				Console.WriteLine(k[i] + " - " + k[-i-1]);
			}

			Console.WriteLine(k[k.Length]);
			Console.WriteLine(k[-k.Length - 1]);
		}
	}
}
