using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace EFPT.Data
{
    public class MYSQLSeedData : DropCreateDatabaseIfModelChanges<MYSQLEntities>
    {
        protected override void Seed(MYSQLEntities context)
        {
            context.Commit();
        }
    }
}