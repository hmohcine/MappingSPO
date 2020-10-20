using MappingSPO.Entities;

namespace MappingSPO
{
    public class WingsSettingEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WingsSettingEntity>
    {
        public WingsSettingEntityConfiguration()
            : this("Settings")
        {
        }

        public WingsSettingEntityConfiguration(string schema)
        {
            ToTable("tWingsSettings", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsRequired();
            Property(x => x.DossierId).HasColumnName(@"DossierID").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.DossierRootPath).HasColumnName(@"DossierRootPath").HasColumnType("nvarchar").IsOptional().HasMaxLength(260);
            Property(x => x.LocationExport).HasColumnName(@"LocationExport").HasColumnType("nvarchar").IsOptional().HasMaxLength(260);
            Property(x => x.JournalSales).HasColumnName(@"JournalSales").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.JournalCreditNota).HasColumnName(@"JournalCreditNota").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.SiteAna).HasColumnName(@"SiteAna").HasColumnType("int").IsRequired();
            Property(x => x.ProcessPayments).HasColumnName(@"ProcessPayments").HasColumnType("bit").IsRequired();
            Property(x => x.ProcessPaymentsMinDate).HasColumnName(@"ProcessPaymentsMinDate").HasColumnType("date").IsRequired();

            HasRequired(a => a.Company).WithMany(b => b.WingsSettings).HasForeignKey(c => c.CompanyId).WillCascadeOnDelete(false);
        }
    }
}
