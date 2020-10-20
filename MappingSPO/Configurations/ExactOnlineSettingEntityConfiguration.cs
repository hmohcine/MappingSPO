using MappingSPO.Entities;

namespace MappingSPO
{
    public class ExactOnlineSettingEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ExactOnlineSettingEntity>
    {
        public ExactOnlineSettingEntityConfiguration()
            : this("Settings")
        {
        }

        public ExactOnlineSettingEntityConfiguration(string schema)
        {
            ToTable("tExactOnlineSettings", schema);
            HasKey(x => x.Id);

            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsRequired();
            Property(x => x.AdministrationCode).HasColumnName(@"AdministrationCode").HasColumnType("int").IsRequired();
            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DossierName).HasColumnName(@"DossierName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.BookYearName).HasColumnName(@"BookYearName").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.BookYearStartDate).HasColumnName(@"BookYearStartDate").HasColumnType("datetime").IsRequired();
            Property(x => x.BookYearEndDate).HasColumnName(@"BookYearEndDate").HasColumnType("datetime").IsRequired();
            Property(x => x.JournalSales).HasColumnName(@"JournalSales").HasColumnType("nvarchar").IsRequired().HasMaxLength(20);
            Property(x => x.JournalSalesCn).HasColumnName(@"JournalSalesCN").HasColumnType("nvarchar").IsRequired().HasMaxLength(20);
            Property(x => x.AnalyticSite).HasColumnName(@"AnalyticSite").HasColumnType("int").IsRequired();
            Property(x => x.SiteFieldToExport).HasColumnName(@"SiteFieldToExport").HasColumnType("int").IsRequired();
            Property(x => x.SyncWerven).HasColumnName(@"SyncWerven").HasColumnType("bit").IsRequired();

            HasRequired(a => a.Company).WithMany(b => b.ExactOnlineSettings).HasForeignKey(c => c.CompanyId).WillCascadeOnDelete(false);
        }
    }
}
