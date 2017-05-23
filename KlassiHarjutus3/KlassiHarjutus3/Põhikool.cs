using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassiHarjutus3
{
	/// <summary>
	/// Põhikool. Neil on olemas litsenst õpilasi õpetada ja inimesi koolitada.
	/// </summary>
	class Põhikool:Kool,IKoolitaja
	{
		public Põhikool(string nimi, string asukoht, int vanus):base(nimi, asukoht, vanus)
		{

		}

		public override void õpeta(int inimesi)
		{
			Console.WriteLine("Õpetame siis " + (inimesi+5) + " õpilast.");
		}

		public void koolita(int inimesi)
		{
			Console.WriteLine("Koolitame siis " + inimesi + " inimest.");
		}
	}
}
