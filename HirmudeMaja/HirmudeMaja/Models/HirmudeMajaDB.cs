using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HirmudeMaja.Models
{
	public class HirmudeMajaDB:DbContext
	{
		public DbSet<Visitor> Visitors { get; set; }
	}
}