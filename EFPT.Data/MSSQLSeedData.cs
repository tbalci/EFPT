using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace EFPT.Data
{
    public class MSSQLSeedData : DropCreateDatabaseAlways<MSSQLEntities>
    {
        protected override void Seed(MSSQLEntities context)
        {
            context.Commit();
        }
    }
}