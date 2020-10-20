using MappingSPO.Entities;

namespace MappingSPO
{
    public class ReportsDxEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ReportsDxEntity>
    {
        public ReportsDxEntityConfiguration()
            : this("Settings")
        {
        }

        public ReportsDxEntityConfiguration(string schema)
        {
            ToTable("tReportsDx", schema);
            HasKey(x => x.ReportId);

            Property(x => x.ReportId).HasColumnName(@"ReportId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(250);
            Property(x => x.IsSystemReport).HasColumnName(@"IsSystemReport").HasColumnType("bit").IsRequired();
            Property(x => x.ReportType).HasColumnName(@"ReportType").HasColumnType("int").IsRequired();
        }
    }
}
