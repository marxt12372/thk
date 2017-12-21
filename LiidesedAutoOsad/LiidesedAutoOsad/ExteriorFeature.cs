using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiidesedAutoOsad
{
	class ExteriorFeature:IFeature
	{
		private string _exteriorFeature;

		public ExteriorFeature()
		{
			_exteriorFeature = "Generic";
		}

		public ExteriorFeature(string feature)
		{
			_exteriorFeature = feature;
		}

		public string getFeature()
		{
			return _exteriorFeature;
		}

		public void setFeature(string feature)
		{
			_exteriorFeature = feature;
		}

		public override string ToString()
		{
			return "Exterior [" + _exteriorFeature + "]";
		}
	}
}
