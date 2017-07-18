using System.Data.Entity;

namespace WcfService2
{
    public class SupplierContext : DbContext
    {
        public SupplierContext() : base("SupplierConnection")
        {
        }

        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new SupplierConfiguration()); 
        }
    }

    
}