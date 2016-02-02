using System.Data.Entity;
namespace EFPT.Data
{
    public class MSSQLEntities : DbContext
    {
        public MSSQLEntities() : base("MSSQLBaglanti")
        {

        }
        public DbSet<Model.User> UserListesi { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

    }
}