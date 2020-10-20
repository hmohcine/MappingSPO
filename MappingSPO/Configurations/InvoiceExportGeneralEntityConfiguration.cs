using MappingSPO.Entities;

namespace MappingSPO
{
    public class InvoiceExportGeneralEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<InvoiceExportGeneralEntity>
    {
        public InvoiceExportGeneralEntityConfiguration()
            : this("Settings")
        {
        }

        public InvoiceExportGeneralEntityConfiguration(string schema)
        {
            ToTable("tInvoiceExportGeneral", schema);
            HasKey(x => x.Id);

            Property(x => x.Exporter).HasColumnName(@"Exporter").HasColumnType("int").IsOptional();
            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IncomingInvoiceAutoMatchingTolerance).HasColumnName(@"IncomingInvoiceAutoMatchingTolerance").HasColumnType("decimal").IsRequired().HasPrecision(7,2);
        }
    }
}
