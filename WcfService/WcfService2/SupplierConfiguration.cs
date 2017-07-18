using System.Data.Entity.ModelConfiguration;

namespace WcfService2
{
    public class SupplierConfiguration : EntityTypeConfiguration<Supplier>
    { 
        public SupplierConfiguration()
        {
            Property(s => s.SupplierName).HasMaxLength(100).IsRequired();
            Property(s => s.ContactNumber).HasMaxLength(15).IsOptional();
            Property(s => s.Notes).HasMaxLength(200).IsOptional();
        }
    }
}