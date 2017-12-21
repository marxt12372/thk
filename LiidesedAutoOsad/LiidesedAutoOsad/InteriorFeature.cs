using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiidesedAutoOsad
{
	class InteriorFeature:IFeature
	{
		string _interiorFeature;

		public InteriorFeature()
		{
			_interiorFeature = "Generic";
		}

		public InteriorFeature(string feature)
		{
			_interiorFeature = feature;
		}

		public string getFeature()
		{
			return _interiorFeature;
		}

		public void setFeature(string feature)
		{
			_interiorFeature = feature;
		}

		public override string ToString()
		{
			return "Interior [" + _interiorFeature + "]";
		}
	}
}
