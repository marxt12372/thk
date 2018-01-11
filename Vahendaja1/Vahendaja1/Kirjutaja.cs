using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vahendaja1
{
	class Kirjutaja
	{
		private string _sona;

		public Kirjutaja(string sona)
		{
			_sona = sona;
		}

		public string this[int koht]
		{
			get
			{
				if(koht >= 0 && koht < _sona.Length)
				{
					return _sona[koht].ToString();
				}
				else if(koht < 0 && koht >= -_sona.Length)
				{
					return _sona[_sona.Length+koht].ToString();
				}
				return "Järjekorranumbriga tähte ei leitud";
			}
		}

		public int Length
		{
			get { return _sona.Length; }
		}
	}
}
