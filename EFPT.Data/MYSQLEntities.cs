using System.Data.Entity;
namespace EFPT.Data
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class MYSQLEntities : DbContext
    {
        public MYSQLEntities() : base("MYSQLBaglanti")
        {

        }
        public DbSet<Model.User> UserListesi { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model.User>().Property(x => x.Ad).HasMaxLength(50);
            modelBuilder.Entity<Model.User>().Property(x => x.Soyad).HasMaxLength(50);
        }
        public virtual void Commit()
        {
            base.SaveChanges();
        }

    }
}