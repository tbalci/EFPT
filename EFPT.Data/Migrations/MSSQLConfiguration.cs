namespace EFPT.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class MSSQLConfiguration : DbMigrationsConfiguration<EFPT.Data.MSSQLEntities>
    {
        public MSSQLConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "EFPT.Data.MSSQLEntities";
        }

        protected override void Seed(EFPT.Data.MSSQLEntities context)
        {
            
        }
    }

    

}
