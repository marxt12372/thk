using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jalgrattaeksam.Models
{
	public class Eksamineeritavad
	{
		public int Id { get; set; }
		public string Eesnimi { get; set; }
		public string Perenimi { get; set; }
		public int Teooriaeksam { get; set; }
		public int Slaalom { get; set; }
		public int Ringtee { get; set; }
		public int Tanavasoit { get; set; }
	}
}