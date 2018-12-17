using CellPhone.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CellPhone.DAL
{
    public class CellPhoneContext : DbContext
    {

        public CellPhoneContext() : base("CellPhoneContext")
        {
        }

        public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
