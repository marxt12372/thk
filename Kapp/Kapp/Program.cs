using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapp
{
	class Sahtel
	{
		private static List<Sahtel> _sahtlilist = new List<Sahtel>();

		private Kapp _kapp;
		private Vector3 _m66t;

		public Sahtel(Kapp kapp, Vector3 m66t)
		{
			_kapp = kapp;
			_m66t = m66t;

			_sahtlilist.Add(this);
		}

		public Vector3 getM66t()
		{
			return _m66t;
		}

		public Kapp getKapp()
		{
			return _kapp;
		}

		public static List<Sahtel> getSahtliList()
		{
			return _sahtlilist;
		}
	}

	class Kapp
	{
		private static List<Kapp> _kapilist = new List<Kapp>();

		private string _asukoht;
		private bool _lukustatav;
		private bool _lukus;

		public Kapp(string asukoht, bool lukustatav)
		{
			_asukoht = asukoht;
			_lukustatav = lukustatav;

			_kapilist.Add(this);
		}

		public List<Sahtel> getSahtlid()
		{
			List<Sahtel> sahtlilist = new List<Sahtel>();
			foreach (Sahtel sahtel in Sahtel.getSahtliList())
			{
				if(sahtel.getKapp() == this)
				{
					sahtlilist.Add(sahtel);
				}
			}
			return sahtlilist;
		}

		public Vector3 getMaht()
		{
			Vector3 maht = new Vector3();
			Vector3 m66t;
			foreach(Sahtel sahtel in this.getSahtlid())
			{
				m66t = sahtel.getM66t();
				maht.X = maht.X + m66t.X;
				maht.Y = maht.Y + m66t.Y;
				maht.Z = maht.Z + m66t.Z;
			}
			return maht;
		}

		public double getKoguMaht()
		{
			Vector3 maht = getMaht();
			return (maht.X * maht.Y * maht.Z);
		}

		public void lukusta()
		{
			if (_lukustatav)
			{
				if (_lukus == false)
				{
					_lukus = true;
					Console.WriteLine("Kapp lukustati");
				}
			}
			else
			{
				Console.WriteLine("see kappi ei ole lukustatav");
			}
		}

		public void ava()
		{
			if (_lukustatav)
			{
				if (_lukus == true)
				{
					_lukus = false;
					Console.WriteLine("Kapp avati");
				}
			}
			else
			{
				Console.WriteLine("see kappi ei ole lukustatav");
			}
		}

		public static List<Kapp> getKapiList()
		{
			return _kapilist;
		}

		public void showStats()
		{
			Console.WriteLine("-- " + _asukoht + " kapi andmed --");
			Console.WriteLine("Lukustatav: " + _lukustatav + ", Lukus: " + _lukus);
			Console.WriteLine("Sahtlite arv: " + getSahtlid().Count);
			Console.WriteLine("Kogumaht: " + getKoguMaht());
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Kapp kapp1 = new Kapp("elutuba", true);
			for (int i = 0; i < 7; i++)
			{
				Sahtel sahtel = new Sahtel(kapp1, new Vector3(5, 5, 7));
			}
			kapp1.lukusta();
			kapp1.showStats();
			kapp1.ava();
			kapp1.showStats();

			Kapp kapp2 = new Kapp("magamistuba", false);
			for (int i = 0; i < 7; i++)
			{
				Sahtel sahtel = new Sahtel(kapp2, new Vector3(5, 5, 7));
			}
			kapp2.lukusta();
			kapp2.showStats();
			kapp2.ava();
			kapp2.showStats();

			Console.ReadKey();
		}
	}

	class Vector3
	{
		public double X;
		public double Y;
		public double Z;

		public Vector3(double _x, double _y, double _z)
		{
			X = _x;
			Y = _y;
			Z = _z;
		}

		public Vector3()
		{

		}
	}
}
