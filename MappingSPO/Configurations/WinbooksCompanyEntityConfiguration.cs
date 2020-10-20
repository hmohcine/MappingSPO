using MappingSPO.Entities;

namespace MappingSPO
{
    public class WinbooksCompanyEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WinbooksCompanyEntity>
    {
        public WinbooksCompanyEntityConfiguration()
            : this("Settings")
        {
        }

        public WinbooksCompanyEntityConfiguration(string schema)
        {
            ToTable("tWinbooksCompanies", schema);
            HasKey(x => new { x.Wbid, x.CompanyId });

            Property(x => x.Wbid).HasColumnName(@"WBID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CompanyKey).HasColumnName(@"CompanyKey").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(x => x.SourceFolder).HasColumnName(@"SourceFolder").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
        }
    }
}
