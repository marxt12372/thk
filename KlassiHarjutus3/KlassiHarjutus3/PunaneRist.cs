using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassiHarjutus3
{
	/// <summary>
	/// Üks mitmest(mitte) koolitajatüüpidest.
	/// </summary>
	class PunaneRist:IKoolitaja
	{
		private static List<PunaneRist> _koolitajad = new List<PunaneRist>();

		protected string _nimi;
		protected int _vanus;
		protected string _asukoht;
		
		public PunaneRist(string nimi, string asukoht, int vanus)
		{
			_nimi = nimi;
			_asukoht = asukoht;
			_vanus = vanus;
		}

		public string Nimi {
			get { return _nimi; }
			set { _nimi = value; }
		}

		public static List<PunaneRist> getKoolitajadList()
		{
			return _koolitajad;
		}

		public string Asukoht {
			get { return _asukoht; }
			set { _asukoht = value; }
		}

		public void koolita(int inimesi)
		{
			Console.WriteLine("Koolitame siis " + (inimesi+100) + " inimest.");
		}
	}
}
