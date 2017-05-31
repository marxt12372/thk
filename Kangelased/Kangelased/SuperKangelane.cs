using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
	class SuperKangelane:Kangelane
	{
		protected double _osavus;

		public SuperKangelane(string nimi, string asukoht):base(nimi, asukoht)
		{
			_osavus = Program.rnd.Next(1, 5) + Program.rnd.NextDouble();
		}

		public override int päästa(int inimesi)
		{
			return (int) (inimesi * (95+_osavus) / 100);
		}

		public override string ToString()
		{
			return base.ToString() + ", ning minu osavus on: " + _osavus + "!";
		}
	}
}
