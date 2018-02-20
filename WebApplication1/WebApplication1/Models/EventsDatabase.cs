
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
	public class EventsDatabase:DbContext
	{
		public EventsDatabase()
		{
		}

		public DbSet<Events> Events { get; set; }
	}
}