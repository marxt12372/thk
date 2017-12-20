using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiidesedAutoOsad
{
	class VehicleChassis:IChassis
	{
		private string _chassisName;

		public VehicleChassis(string chassisName)
		{
			_chassisName = chassisName;
		}

		public IChassis GetChassisType()
		{
			return null;
		}

		public void SetChassisType(string type)
		{

		}
	}
}
