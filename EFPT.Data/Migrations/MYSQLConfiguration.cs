namespace EFPT.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class MYSQLConfiguration : DbMigrationsConfiguration<EFPT.Data.MYSQLEntities>
    {
        public MYSQLConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "EFPT.Data.MYSQLEntities";
            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator()); // Çok Önemli.
        }
        protected override void Seed(EFPT.Data.MYSQLEntities context)
        {

        }
    }

    

}
