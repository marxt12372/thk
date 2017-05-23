using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassiHarjutus3
{
	/// <summary>
	/// Baasvõimaluste andmestruktuur koolidele.
	/// </summary>
	class Kool
	{
		private static List<Kool> _koolid = new List<Kool>();

		protected string _nimi;
		protected int _vanus;
		protected string _asukoht;

		public Kool(string nimi, string asukoht, int vanus)
		{
			_nimi = nimi;
			_vanus = vanus;
			_asukoht = asukoht;
			_koolid.Add(this);
		}

		public string Nimi {
			get { return _nimi; }
			set { _nimi = value; }
		}

		public static List<Kool> getKoolList()
		{
			return _koolid;
		}

		public string Asukoht {
			get { return _asukoht; }
			set { _asukoht = value; }
		}

		public virtual void õpeta(int inimesi)
		{
			Console.WriteLine("Õpetame " + inimesi + " inimest.");
		}
	}
}
