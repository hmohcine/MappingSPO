using MappingSPO.Entities;

namespace MappingSPO
{
    public class WinbooksCompanyTableEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WinbooksCompanyTableEntity>
    {
        public WinbooksCompanyTableEntityConfiguration()
            : this("Settings")
        {
        }

        public WinbooksCompanyTableEntityConfiguration(string schema)
        {
            ToTable("tWinbooksCompanyTables", schema);
            HasKey(x => new { x.Wbid, x.CompanyId, x.TableId });

            Property(x => x.Wbid).HasColumnName(@"WBID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TableId).HasColumnName(@"TableID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CompanyKey).HasColumnName(@"CompanyKey").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(x => x.SourceFileName).HasColumnName(@"SourceFileName").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(x => x.Memo).HasColumnName(@"Memo").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(x => x.TargetTable).HasColumnName(@"TargetTable").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
        }
    }
}
