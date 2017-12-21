using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
	class Kangelane
	{
		protected string _nimi;
		protected string _asukoht;

		public Kangelane(string nimi, string asukoht)
		{
			_nimi = nimi;
			_asukoht = asukoht;
		}

		public virtual int päästa(int inimesi)
		{
			return (inimesi * 95 / 100);
		}

		public string Nimi
		{
			get { return _nimi; }
			set { _nimi = value; }
		}

		public string Asukoht
		{
			get { return _asukoht; }
			set { _asukoht = value; }
		}

		public override string ToString()
		{
			return _nimi + ": Olen kõikvõimas kangelane " + _asukoht + "ist";
		}
	}
}
