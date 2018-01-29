using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
	public class OdeToFoodDb:DbContext
	{
		public OdeToFoodDb():base("name=DefaultConnection")
		{
		}

		public DbSet<Restourant> Restourants { get; set; }
		public DbSet<RestourantReview> Reviews { get; set; }
	}
}