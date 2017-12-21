using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadused
{
	class Ilmaandmed
	{
		private int _temperatuur;
		private int _temperatuur_muudetud;
		private int _temperatuur_kysitud;

		public Ilmaandmed()
		{
		}

		public int Temp
		{
			get{
				_temperatuur_kysitud++;
				return _temperatuur;
			}

			set {
				if(value >= 35)
				{
					Console.WriteLine("Kahtlane temperatuur.");
				}
				_temperatuur_muudetud++;
				_temperatuur = value;
			}
		}

		public void testime()
		{
			Temp = 5;
		}

		public override string ToString()
		{
			return "Muudetud: " + _temperatuur_muudetud + ", Küsitud: " + _temperatuur_kysitud;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Ilmaandmed jaam1 = new Ilmaandmed();
			jaam1.Temp = 15;
			Console.WriteLine("Jaam1 Temp: " + jaam1.Temp);
			jaam1.Temp = 15+15+15;
			Console.WriteLine("Jaam1 Temp: " + jaam1.Temp);
			jaam1.testime();
			Console.WriteLine("Jaam1 Temp: " + jaam1.Temp);
			Console.WriteLine(jaam1.ToString());
		}
	}
}
