using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
	public class RestourantListViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
	}
}