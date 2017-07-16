using System.Data.Entity.ModelConfiguration;
using TestSolution.Model;

namespace TestSolution.DataLayer
{
    public class SalesOrderConfiguration : EntityTypeConfiguration<SalesOrder>
    {
        public SalesOrderConfiguration()
        {
            Property(so => so.CustomerName).HasMaxLength(100).IsRequired();
            Property(so => so.PoNumber).HasMaxLength(10).IsOptional();
            Property(so => so.OrderDate).IsRequired();
        }
    }
}
