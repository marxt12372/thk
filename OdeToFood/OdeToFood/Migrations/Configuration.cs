namespace OdeToFood.Migrations
{
	using OdeToFood.Models;
	using System;
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
            string[] names = new string[]{ "Mcdonalds", "Daily", "Restoran", "Blaaahum", "Lokomotiiv", "Blaahum", "Hesburger", "Wimka", "La Dolce Vita", "Pood", "Rimi", "Selver",
			"Prisma", "Muxima", "Krossipood", "Kassipood", "Raxon", "Viinapood"};
			int[] namesUsed = new int[64];
			string[] linnad = new string[] { "Tallinn", "Tartu", "Pärnu", "Haapsalu", "Valga", "Võru", "Kuressaare", "Kärdla", "Viljandi" };

			Random rand = new Random();

			for(int i = 0; i <= 1000; i++)
			{
				int name = rand.Next(0, names.Length);
				namesUsed[name]++;
				context.Restourants.AddOrUpdate(r => r.Name, new Restourant { Name = names[name] + " " + namesUsed[name], City = linnad[rand.Next(0, linnad.Length)], Country = "Estonia" });
			}
        }
    }
}
