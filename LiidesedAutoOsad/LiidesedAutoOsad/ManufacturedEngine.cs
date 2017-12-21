using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiidesedAutoOsad
{
	class ManufacturedEngine : IEngine
	{
		private string _engineManufacturer;
		private DateTime _engineManufacturedDate;
		private string _engineMake;
		private string _engineModel;
		private int _engineCylinders;
		private string _engineType;
		private string _driveTrain;

		public ManufacturedEngine()
		{
			_engineManufacturer = "Generic";
			_engineManufacturedDate = new DateTime(2012, 2, 2, 00, 55, 44);
			_engineMake = "Generic";
			_engineModel = "Generic";
			_engineCylinders = 0;
			_engineType = "85 AKI";
			_driveTrain = "2WD: Two-Wheel Drive";
		}

		public ManufacturedEngine(string engineManufacturer, DateTime engineManufacturedDate, string engineMake, string engineModel, int engineCylinders, string engineType, string driveTrain)
		{
			_engineManufacturer = engineManufacturer;
			_engineManufacturedDate = engineManufacturedDate;
			_engineMake = engineMake;
			_engineModel = engineModel;
			_engineCylinders = engineCylinders;
			_engineType = engineType;
			_driveTrain = driveTrain;
		}

		public void SetDriveTrain(string driveTrain)
		{
			_driveTrain = driveTrain;
		}

		public void SetEngineCylinders(int engineCylinders)
		{
			_engineCylinders = engineCylinders;
		}

		public void SetEngineMake(string engineMake)
		{
			_engineMake = engineMake;
		}

		public void SetEngineManufacturedDate(DateTime date)
		{
			_engineManufacturedDate = date;
		}

		public void SetEngineManufacturer(string manufacturer)
		{
			_engineManufacturer = manufacturer;
		}

		public void SetEngineModel(string engineModel)
		{
			_engineModel = engineModel;
		}

		public void SetEngineType(string fuel)
		{
			_engineType = fuel;
		}

		public override string ToString()
		{
			string info = "";
			info += "Engine Manufacturer: " + _engineManufacturer + "\n";
			info += "Engine Manufactured: " + _engineManufacturedDate + "\n";
			info += "Engine Make: " + _engineMake + "\n";
			info += "Engine Model: " + _engineModel + "\n";
			info += "Engine Type: " + _engineType + "\n";
			info += "Engine Cylinders: " + _engineCylinders + "\n";
			info += "Drive Train: " + _driveTrain;
			return info;
		}
	}
}
