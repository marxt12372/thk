using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vahendaja2
{
	class Tunnisumeerija
	{
		private int[] _tooTunde;
		public Tunnisumeerija()
		{
			_tooTunde = new int[7];
		}
		
		public int this[int paev]
		{
			get
			{
				return _tooTunde[paev];
			}

			set
			{
				if(value > 0)
				{
					_tooTunde[paev] += value;
				}
			}
		}
	}
}
