using System.Data.Entity;
namespace EFPT.Data
{
    public class MYSQLEntities : DbContext
    {
        public MYSQLEntities() : base("MYSQLBaglanti")
        {

        }
        public DbSet<Model.User> UserListesi { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

    }
}