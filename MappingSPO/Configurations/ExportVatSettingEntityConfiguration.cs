using MappingSPO.Entities;

namespace MappingSPO
{
    public class ExportVatSettingEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ExportVatSettingEntity>
    {
        public ExportVatSettingEntityConfiguration()
            : this("Settings")
        {
        }

        public ExportVatSettingEntityConfiguration(string schema)
        {
            ToTable("tExportVATSettings", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.VatRegime).HasColumnName(@"VATRegime").HasColumnType("int").IsRequired();
            Property(x => x.CountryCode).HasColumnName(@"CountryCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(4);
            Property(x => x.VatCode).HasColumnName(@"VATCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.VatPctCode).HasColumnName(@"VATPctCode").HasColumnType("int").IsRequired();
            Property(x => x.LedgerAccountVat).HasColumnName(@"LedgerAccountVat").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.VatExternalCode).HasColumnName(@"VATExternalCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.VatPctExternalCode).HasColumnName(@"VATPctExternalCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.UseAsDefaultSettings).HasColumnName(@"UseAsDefaultSettings").HasColumnType("bit").IsRequired();
            Property(x => x.CustGroup).HasColumnName(@"CustGroup").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.LedgerAccountOverride).HasColumnName(@"LedgerAccountOverride").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.VatFieldInVenice).HasColumnName(@"VatFieldInVenice").HasColumnType("int").IsOptional();
            Property(x => x.RevenueFieldInVenice).HasColumnName(@"RevenueFieldInVenice").HasColumnType("int").IsOptional();

            HasRequired(a => a.Country).WithMany(b => b.ExportVatSettings).HasForeignKey(c => c.CountryCode).WillCascadeOnDelete(false);
            HasRequired(a => a.Vat).WithMany(b => b.ExportVatSettings).HasForeignKey(c => c.VatPctCode).WillCascadeOnDelete(false);
            HasRequired(a => a.VatRegime_VatRegime).WithMany(b => b.ExportVatSettings).HasForeignKey(c => c.VatRegime).WillCascadeOnDelete(false);
        }
    }
}
