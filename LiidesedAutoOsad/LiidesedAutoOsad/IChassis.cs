using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiidesedAutoOsad
{
	interface IChassis
	{
		IChassis GetChassisType();
		void SetChassisType(string type);
	}
}
