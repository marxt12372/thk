using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Jalgrattaeksam.Models
{
	public class JalgrattaeksamDb:DbContext
	{
		public DbSet<Eksamineeritavad> Eksamineeritavad { get; set; }
	}
}