using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace RP_FABRICA.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<RP_FABRICA.DbVD>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;

            //  if (System.Diagnostics.Debugger.IsAttached == false)
            //      System.Diagnostics.Debugger.Launch();
            //  System.Diagnostics.Debugger.Break();

            //  CodeGenerator = new CustomVBMigrationCodeGenerator();


        }

        protected override void Seed(RP_FABRICA.DbVD context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
