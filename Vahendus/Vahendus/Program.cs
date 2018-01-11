using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vahendus
{
	class Program
	{
		static void Main(string[] args)
		{
			Ringreis r = new Ringreis();
			DateTime neljapaev = new DateTime(2018, 1, 11, 0, 0, 0);
			DateTime reede = new DateTime(2018, 1, 12, 0, 0, 0);
			DateTime laupaev = new DateTime(2018, 1, 13, 0, 0, 0);

			r[neljapaev] = "Narva";
			r[reede] = "Tartu";

			Console.WriteLine(r[neljapaev]);
			Console.WriteLine(r[laupaev]);
			r[laupaev] = "Viljandi";
		}
	}
}
