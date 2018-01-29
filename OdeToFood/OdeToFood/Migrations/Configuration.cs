namespace OdeToFood.Migrations
{
	using OdeToFood.Models;
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDb>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
		}

		protected override void Seed(OdeToFood.Models.OdeToFoodDb context)
		{
			context.Restourants.AddOrUpdate(r => r.Name,
				new Restourant { Name = "McDonalds", City = "Tallinn", Country = "Estonia" },
				new Restourant { Name = "Staap", City = "Tallinn", Country = "Estonia",
					Reviews = new List<RestourantReview> {
						new RestourantReview { Rating = 4.5f, Body = "Okei koht" },
						new RestourantReview { Rating = 5.5f, Body = "Suhteliselt OK" }
					}
				},
				new Restourant { Name = "Daily", City = "Tallinn", Country = "Estonia",
					Reviews = new List<RestourantReview> {
						new RestourantReview { Rating = 1.0f, Body = "Väga halb toit" },
						new RestourantReview { Rating = 0.1f, Body = "Vastik!" }
					}
				},
				new Restourant { Name = "La Dolce Vita", City = "Tartu", Country = "Estonia" }
			);
		}
	}
}
