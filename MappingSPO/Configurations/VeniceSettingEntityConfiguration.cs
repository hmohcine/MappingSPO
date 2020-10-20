using MappingSPO.Entities;

namespace MappingSPO
{
    public class VeniceSettingEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VeniceSettingEntity>
    {
        public VeniceSettingEntityConfiguration()
            : this("Settings")
        {
        }

        public VeniceSettingEntityConfiguration(string schema)
        {
            ToTable("tVeniceSettings", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsRequired();
            Property(x => x.Cabinet).HasColumnName(@"Cabinet").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.DossierName).HasColumnName(@"DossierName").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.LoginUsername).HasColumnName(@"LoginUsername").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.LoginPassword).HasColumnName(@"LoginPassword").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.LoginInitials).HasColumnName(@"LoginInitials").HasColumnType("nvarchar").IsRequired().HasMaxLength(10);
            Property(x => x.CreatedForVenVer).HasColumnName(@"CreatedForVenVer").HasColumnType("nvarchar").IsRequired().HasMaxLength(10);
            Property(x => x.StartBookYear).HasColumnName(@"StartBookYear").HasColumnType("int").IsRequired();
            Property(x => x.PurchaseSync).HasColumnName(@"PurchaseSync").HasColumnType("bit").IsRequired();
            Property(x => x.JournalSales).HasColumnName(@"JournalSales").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.JournalCreditNota).HasColumnName(@"JournalCreditNota").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.AccountCustomer).HasColumnName(@"AccountCustomer").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.AccountSupplier).HasColumnName(@"AccountSupplier").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.PurchaseCatAna).HasColumnName(@"PurchaseCatAna").HasColumnType("int").IsRequired();
            Property(x => x.SiteCodeAna).HasColumnName(@"SiteCodeAna").HasColumnType("int").IsRequired();
            Property(x => x.SiteDigitsNumber).HasColumnName(@"SiteDigitsNumber").HasColumnType("int").IsRequired();
            Property(x => x.SiteSync).HasColumnName(@"SiteSync").HasColumnType("bit").IsRequired();
            Property(x => x.PurchaseDagboeken).HasColumnName(@"PurchaseDagboeken").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.RunMatching).HasColumnName(@"RunMatching").HasColumnType("bit").IsRequired();

            HasRequired(a => a.Company).WithMany(b => b.VeniceSettings).HasForeignKey(c => c.CompanyId).WillCascadeOnDelete(false);
        }
    }
}
