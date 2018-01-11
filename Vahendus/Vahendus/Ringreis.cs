using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vahendus
{
	class Ringreis
	{
		private Hashtable esinemised = new Hashtable();

		public Ringreis()
		{
		}

		public string this[DateTime koht]
		{
			get
			{
				if (esinemised[koht] != null) return (string) esinemised[koht];
				else return "Lahti";
			}

			set
			{
				if (esinemised[koht] != null)
				{
					throw new Exception("Juba kinni, esinemine linnas " + esinemised[koht]);
				}
				else esinemised[koht] = value;
			}
		}
	}
}
