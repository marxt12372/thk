using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HirmudeMaja.Models
{
	public class Visitor
	{
		public int Id { get; set; }

		[Required]
		public string Eesnimi { get; set; }
		public int Sisenes { get; set; }
		public int Lahkus { get; set; }
	}
}