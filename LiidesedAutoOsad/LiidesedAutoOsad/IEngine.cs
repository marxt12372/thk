using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiidesedAutoOsad
{
	interface IEngine
	{
		void SetEngineCylinders(int engineCylinders);
		void SetEngineManufacturedDate(DateTime date);
		void SetEngineManufacturer(string manufacturer);
		void SetEngineMake(string engineMake);
		void SetEngineModel(string engineModel);
		void SetDriveTrain(string driveTrain);
		void SetEngineType(string fuel);
	}
}
