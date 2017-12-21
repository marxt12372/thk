using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiidesedAutoOsad
{
	class Vehicle:IEngine,IChassis
	{
		private DateTime _vehicleManufacturedDate;
		private string _vehicleManufacturer;
		private string _vehicleMake;
		private string _vehicleModel;
		private VehicleChassis _vehicleFrame;
		private string _vehicleType;
		private ManufacturedEngine _vehicleEngine;

		public Vehicle()
		{
			_vehicleManufacturedDate = new DateTime(2015, 1, 23, 7, 13, 19);
			_vehicleManufacturer = "Honda";
			_vehicleMake = "Honda";
			_vehicleModel = "Prelude";
			_vehicleType = "null";
			_vehicleFrame = new VehicleChassis("Generic");
			_vehicleEngine = new ManufacturedEngine("Honda", new DateTime(2015, 2, 2, 1, 38, 31), "H-Series", "H23A1", 4, "88 AKI", "2WD: Two-Wheel Drive");
		}

		public Vehicle(DateTime vehicleManufacturedDate, string vehicleManufacturer, string vehicleMake,  string vehicleModel,  string vehicleType, VehicleChassis vehicleFrame, ManufacturedEngine vehicleEngine)
		{
			_vehicleManufacturedDate = vehicleManufacturedDate;
			_vehicleManufacturer = vehicleManufacturer;
			_vehicleMake = vehicleMake;
			_vehicleModel = vehicleModel;
			_vehicleType = vehicleType;
			_vehicleFrame = vehicleFrame;
			_vehicleEngine = vehicleEngine;
		}

		public IChassis GetChassisType()
		{
			return _vehicleFrame.GetChassisType();
		}

		public void SetChassisType(string type)
		{
			_vehicleFrame.SetChassisType(type);
		}

		public void SetDriveTrain(string driveTrain)
		{
			_vehicleEngine.SetDriveTrain(driveTrain);
		}

		public void SetEngineCylinders(int engineCylinders)
		{
			_vehicleEngine.SetEngineCylinders(engineCylinders);
		}

		public void SetEngineMake(string engineMake)
		{
			_vehicleEngine.SetEngineMake(engineMake);
		}

		public void SetEngineManufacturedDate(DateTime date)
		{
			_vehicleEngine.SetEngineManufacturedDate(date);
		}

		public void SetEngineManufacturer(string manufacturer)
		{
			_vehicleEngine.SetEngineManufacturer(manufacturer);
		}

		public void SetEngineModel(string engineModel)
		{
			_vehicleEngine.SetEngineModel(engineModel);
		}

		public void SetEngineType(string fuel)
		{
			_vehicleEngine.SetEngineType(fuel);
		}

		public override string ToString()
		{
			string info = "";
			info += "Manufacturer Name: " + _vehicleManufacturer + "\n";
			info += "Manufactured Date: " + _vehicleManufacturedDate + "\n";
			info += "Vehicle Make: " + _vehicleMake + "\n";
			info += "Vehicle Model: " + _vehicleModel + "\n";
			info += "Vehicle Type: " + _vehicleType + "\n";
			info += _vehicleEngine.ToString();
			return info;
		}
	}
}
