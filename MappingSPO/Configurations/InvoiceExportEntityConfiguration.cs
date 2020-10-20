using MappingSPO.Entities;

namespace MappingSPO
{
    public class InvoiceExportEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<InvoiceExportEntity>
    {
        public InvoiceExportEntityConfiguration()
            : this("Settings")
        {
        }

        public InvoiceExportEntityConfiguration(string schema)
        {
            ToTable("tInvoiceExport", schema);
            HasKey(x => new { x.CountryCode, x.VatCode, x.BtwRegime });

            Property(x => x.CountryCode).HasColumnName(@"CountryCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.VatCode).HasColumnName(@"VatCode").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BtwRegime).HasColumnName(@"BTWRegime").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RekeningVerkoop).HasColumnName(@"RekeningVerkoop").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.RekeningVat).HasColumnName(@"RekeningVAT").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.VentilatieCode).HasColumnName(@"VentilatieCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ExtraValue).HasColumnName(@"ExtraValue").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.TaxCategoryCode).HasColumnName(@"TaxCategoryCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);

            HasRequired(a => a.Country).WithMany(b => b.InvoiceExports).HasForeignKey(c => c.CountryCode).WillCascadeOnDelete(false);
            HasRequired(a => a.Vat).WithMany(b => b.InvoiceExports).HasForeignKey(c => c.VatCode).WillCascadeOnDelete(false);
            HasRequired(a => a.VatRegime).WithMany(b => b.InvoiceExports).HasForeignKey(c => c.BtwRegime).WillCascadeOnDelete(false);
        }
    }
}
