using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassiHarjutus3
{
	class Program
	{
		static void Main(string[] args)
		{
			Kool thk = new Kool("THK", "Sõpruse puiestee", 100);
			Põhikool rpk = new Põhikool("Ristiku põhikool", "Kolde puiestee", 100);
			PunaneRist koolitaja = new PunaneRist("Blah", "Haigla", 2500);
			//Koolitaja koolitab inimesi.
			koolitaja.koolita(10);
			Console.WriteLine("Olen " + koolitaja.Nimi + ", ning asun " + koolitaja.Asukoht + "s");
			//THK õpetab õpilasi.
			thk.õpeta(10);
			Console.WriteLine("Olen " + thk.Nimi + ", ning asun " + thk.Asukoht + "l");
			//RPK põhikool õpetab õpilasi. Lisaks on neil ka koolituslitsenst, aga nad jäid rahapuudusesse, seega nad ei suutnud ühtegi õpetajat omale koolitama palgata.
			//Noh, nagu mu ema alati ütleb: Rahapuud ei ole olemas. Kahjuks. :(
			//rpk.koolita(10);
			rpk.õpeta(10);
			Console.WriteLine("Olen " + rpk.Nimi + ", ning asun " + rpk.Asukoht + "l");
		}
	}
}
