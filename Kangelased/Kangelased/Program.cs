using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
	class Program
	{
		public static List<Kangelane> _kangelased = new List<Kangelane>();
		public static Random rnd = new Random();

		public static void laeKangelased(string filename, List<Kangelane> kangelased)
		{
			try
			{
				FileStream f = new FileStream(filename, FileMode.Open, FileAccess.Read);
				StreamReader sisse = new StreamReader(f);
				string rida = sisse.ReadLine();
				while (rida != null)
				{
					//Console.WriteLine("");
					string[] aa = rida.Split('/');
					if (aa[0].Contains('*')) //Superkangelane
					{
						string nimi = aa[0].Remove(aa[0].Length - 1, 1);
						kangelased.Add(new SuperKangelane(nimi, aa[1]));
					}
					else //Mitte nii super kuid ka kangelane
					{
						kangelased.Add(new Kangelane(aa[0], aa[1]));
					}
					rida = sisse.ReadLine();
				}
			}
			catch(FileNotFoundException e)
			{
				Console.WriteLine(e.ToString());
				Environment.Exit(-1);
			}
		}

		static void Main(string[] args)
		{
			laeKangelased("kangelased.txt", _kangelased);

			Console.WriteLine("Kangelased, tutvustage ennast!");

			foreach (Kangelane kangur in _kangelased)
			{
				Console.WriteLine(kangur.ToString());
			}

			Console.WriteLine("\n");

			foreach (Kangelane kangelane in _kangelased)
			{
				if (kangelane.GetType().ToString() == "Kangelased.SuperKangelane")
				{
					int inimesi = rnd.Next(25, 200);
					Console.WriteLine(kangelane.Nimi + " tuleb ja aitab!");
					Console.WriteLine(kangelane.Nimi + " päästis " + inimesi + " inimesest " + kangelane.päästa(inimesi) + " inimest!");
					break;
				}
			}

			Console.WriteLine("\n");

			foreach (Kangelane kangelane in _kangelased)
			{
				if (kangelane.GetType().ToString() == "Kangelased.Kangelane")
				{
					int inimesi = rnd.Next(25, 200);
					Console.WriteLine(kangelane.Nimi + " tuleb ja aitab!");
					Console.WriteLine(kangelane.Nimi + " päästis " + inimesi + " inimesest " + kangelane.päästa(inimesi) + " inimest!");
					break;
				}
			}
		}
	}
}
