using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetoditeAsendus
{
	class Inimene
	{
		protected int _vanus;

		public Inimene(int vanus)
		{
			_vanus = vanus;
		}

		public virtual void YtleVanus()
		{
			Console.WriteLine("Olen " + _vanus + " aastane inimene.");
		}
	}

	class Daam:Inimene
	{
		public Daam(int vanus):base(vanus)
		{

		}

		public override void YtleVanus()
		{
			Console.WriteLine("Olen " + (_vanus-5) + " aastane daam.");
		}
	}
	
	class Beib:Daam
	{
		public Beib(int vanus):base(vanus)
		{
		}

		public new virtual void YtleVanus()
		{
			Console.WriteLine("Beibi vanus ei ole sinu asi.");
		}
	}

	sealed class KavalBeib : Beib
	{
		public KavalBeib(int vanus):base(vanus)
		{
		}

		public override void YtleVanus()
		{
			Console.WriteLine("No mis sa arvad, kas olen " + (_vanus+2) + "?");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			KavalBeib kb = new KavalBeib(17);
			Console.Write("Kavalbeib: ");
			kb.YtleVanus();
			Beib b = new Beib(17), bkb = kb;
			Console.Write("Beib: ");
			b.YtleVanus();
			Console.Write("Beib Kavalbeib: ");
			bkb.YtleVanus();
			Daam d = new Daam(40), db = b, dkb = kb;
			Console.Write("Daam: ");
			d.YtleVanus();
			Console.Write("DaamBeib: ");
			db.YtleVanus();
			Console.Write("Daam Kavalbeib: ");
			dkb.YtleVanus();
			Inimene i = new Inimene(40), id = d, ib = b, ikb = kb;
			Console.Write("Inimene: ");
			i.YtleVanus();
			Console.Write("Inimdaam: ");
			id.YtleVanus();
			Console.Write("Inimbeib: ");
			ib.YtleVanus();
			Console.Write("Inimene Kavalbeib: ");
			ikb.YtleVanus();
		}
	}
}
