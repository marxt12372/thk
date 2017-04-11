using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiideseHarjutused3
{
	interface ILadusta
	{
		bool Ladusta(string asi);
		string asjad();
	}

	class Riiul:ILadusta
	{
		protected List<string> _asjad = new List<string>();
		protected int _suurus;
		public Riiul(int suurus)
		{
			_suurus = suurus;
		}

		public bool Ladusta(string asi)
		{
			if (_asjad.Count < _suurus)
			{
				_asjad.Add(asi);
				return true;
			}
			else return false;
		}

		public string asjad()
		{
			string aa = "";
			foreach(string asi in _asjad)
			{
				if(aa == "")
				{
					aa = asi;
				}
				else aa = aa + ", " + asi;
			}
			return aa;
		}
	}

	class Kapp:Riiul
	{
		private bool _uksed;
		public Kapp(int suurus):base(suurus)
		{
		}

		public void avaUksed()
		{
			_uksed = true;
		}

		public void sulgeUksed()
		{
			_uksed = false;
		}

		public new bool Ladusta(string asi)
		{
			if (_asjad.Count < _suurus)
			{
				if (_uksed)
				{
					_asjad.Add(asi);
					return true;
				}
				else return false;
			}
			else return false;
		}
	}

	class Karp:ILadusta
	{
		private string _asi;
		public Karp()
		{
			_asi = "";
		}

		public bool Ladusta(string asi)
		{
			if (_asi == "")
			{
				_asi = asi;
				return true;
			}
			else return false;
		}

		public string asjad()
		{
			return _asi;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Riiul riiul = new Riiul(10);
			Kapp kapp = new Kapp(10);
			Karp karp = new Karp();

			riiul.Ladusta("Monopol");
			riiul.Ladusta("Tetris");
			Console.WriteLine("Riiulis on: " + riiul.asjad());

			kapp.Ladusta("Jope");
			kapp.avaUksed();
			kapp.Ladusta("Püksid");
			kapp.sulgeUksed();
			Console.WriteLine("Kapis on: " + kapp.asjad());

			karp.Ladusta("Legod");
			Console.WriteLine("Karbis on: " + karp.asjad());
		}
	}
}
