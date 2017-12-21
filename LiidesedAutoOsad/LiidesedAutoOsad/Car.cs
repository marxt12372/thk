using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiidesedAutoOsad
{
	class Car:Vehicle
	{
		private List<IFeature> _features = new List<IFeature>();
		private int _carAxle;

		public Car() : base()
		{
			_features = new List<IFeature>();
			_features.Add(new InteriorFeature("AM/FM Radio"));
			_features.Add(new InteriorFeature("Air Conditioning"));
			_features.Add(new ExteriorFeature("Wood Panels"));
			_features.Add(new ExteriorFeature("Moonroof"));
			_carAxle = 2;
		}

		public Car(DateTime vehicleManufacturedDate, string vehicleManufacturer, string vehicleMake, string vehicleModel, string vehicleType, VehicleChassis vehicleFrame, ManufacturedEngine vehicleEngine, List<IFeature> features, int axle) : base(vehicleManufacturedDate, vehicleManufacturer, vehicleMake, vehicleModel, vehicleType, vehicleFrame, vehicleEngine)
		{
			_features = features;
			_carAxle = axle;
		}

		public string GetExteriorFeatures()
		{
			string features = "";
			foreach(IFeature feature in _features)
			{
				if(feature.GetType() == typeof(ExteriorFeature))
				{
					features += feature.ToString() + "\n";
				}
			}
			return features;
		}

		public string GetInteriorFeatures()
		{
			string features = "";
			foreach (IFeature feature in _features)
			{
				if (feature.GetType() == typeof(InteriorFeature))
				{
					features += feature.ToString() + "\n";
				}
			}
			return features;
		}

		public override string ToString()
		{
			string info = "";
			info += base.ToString() + "\n" + GetInteriorFeatures() + GetExteriorFeatures() + "Car Axle: " + _carAxle;
			return info;
		}
	}
}
