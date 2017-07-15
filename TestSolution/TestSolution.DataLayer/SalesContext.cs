using System.Data.Entity;
using TestSolution.Model;

namespace TestSolution.DataLayer
{
    public class SalesContext : DbContext
    {
        public SalesContext() : base("SalesConnection")
        {
        }

        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
              modelBuilder.Configurations.Add(new SalesOrderConfiguration());
        }
    }
}
