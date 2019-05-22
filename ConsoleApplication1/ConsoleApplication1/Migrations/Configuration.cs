namespace CsharpTest.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CsharpTest.DBContext.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;   //£¨ÊÇ·ñ¶ªÊý¾Ý£©
            ContextKey = "CsharpTest.DBContext.SchoolContext";
        }

        protected override void Seed(CsharpTest.DBContext.SchoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
