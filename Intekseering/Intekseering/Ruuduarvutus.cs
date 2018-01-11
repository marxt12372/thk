using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intekseering
{
	class Ruuduarvutus
	{
		public Ruuduarvutus()
		{
		}

		public int this[int nr]
		{
			get { return nr * nr; }
		}
	}
}
