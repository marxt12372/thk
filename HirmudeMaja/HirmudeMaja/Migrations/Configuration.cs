namespace HirmudeMaja.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HirmudeMaja.Models.HirmudeMajaDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "HirmudeMaja.Models.HirmudeMajaDB";
        }

        protected override void Seed(HirmudeMaja.Models.HirmudeMajaDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
