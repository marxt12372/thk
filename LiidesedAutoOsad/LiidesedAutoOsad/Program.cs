using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiidesedAutoOsad
{
	class Program
	{
		static void Main(string[] args)
		{
			/*VehicleFrame frame = new VehicleFrame();
			VehicleFrame frame2 = new VehicleFrame("Ladder Frame");
			Console.WriteLine(frame.ToString());
			Console.WriteLine();
			Console.WriteLine("Vehicle Frame: " + frame2.GetFrameType());*/

			/*ManufacturedEngine engine = new ManufacturedEngine();
			Console.WriteLine(engine.ToString());
			Console.WriteLine();
			ManufacturedEngine engine2 = new ManufacturedEngine("Honda", new DateTime(2012, 1, 3, 7, 13, 19), "H-Series", "H23A1", 4, "88 AKI", "2WD: Two-Wheel Drive");
			Console.WriteLine(engine2.ToString());*/

			/*InteriorFeature feature = new InteriorFeature();
			Console.WriteLine(feature.ToString());
			Console.WriteLine();
			InteriorFeature feature2 = new InteriorFeature("Climate Control");
			Console.WriteLine(feature2.ToString());*/

			/*ExteriorFeature feature = new ExteriorFeature();
			Console.WriteLine(feature.ToString());
			Console.WriteLine();
			ExteriorFeature feature2 = new ExteriorFeature("Fog Lamps");
			Console.WriteLine(feature2.ToString());*/

			/*Vehicle vehicle = new Vehicle();
			Console.WriteLine(vehicle.ToString());
			Console.WriteLine();
			Vehicle vehicle2 = new Vehicle(new DateTime(2012, 1, 3, 7, 13, 19), "Honda", "Honda", "Prelude", null, new VehicleChassis("Generic"), new ManufacturedEngine("Honda", new DateTime(2012, 2, 2, 1, 38, 31), "H-Series", "H23A1", 4, "88 AKI", "2WD: Two-Wheel Drive"));
			Console.WriteLine(vehicle.ToString());*/

			Car car = new Car();
			Console.WriteLine(car.ToString());
			Console.WriteLine();

			List<IFeature> features = new List<IFeature>();
			features.Add(new InteriorFeature("Electric Windows"));
			features.Add(new InteriorFeature("AM/FM Radio"));
			features.Add(new InteriorFeature("Navigation System"));
			features.Add(new InteriorFeature("Cruise Control"));
			features.Add(new ExteriorFeature("Sunroof"));
			features.Add(new ExteriorFeature("LED headlamps"));
			Car car2 = new Car(new DateTime(2012, 1, 3, 7, 13, 19), "Audi", "A-Series", "A4", "Personal Vehicle", new VehicleChassis("B8"), new ManufacturedEngine("Audi", new DateTime(2012, 1, 3, 7, 13, 19), "V-Series", "AH11", 6, "Petrol", "AWD: All Wheel Drive"), features, 2);
			Console.WriteLine(car2.ToString());
			Console.ReadKey();
		}
	}
}
