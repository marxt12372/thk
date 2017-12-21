using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiidesedAutoOsad
{
	class VehicleFrame : IChassis
	{
		private string _frameType;

		public VehicleFrame()
		{
			_frameType = "Unibody";
		}

		public VehicleFrame(string type)
		{
			_frameType = type;
		}

		public string GetFrameType()
		{
			return _frameType;
		}

		public IChassis GetChassisType()
		{
			return this;
		}

		public void SetChassisType(string type)
		{
			_frameType = type;
		}

		public override string ToString()
		{
			return "Chassis: Chassis\nVehicle Frame: " + _frameType;
		}
	}
}
