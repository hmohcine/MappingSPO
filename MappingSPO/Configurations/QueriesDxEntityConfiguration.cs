using MappingSPO.Entities;

namespace MappingSPO
{
    public class QueriesDxEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<QueriesDxEntity>
    {
        public QueriesDxEntityConfiguration()
            : this("Settings")
        {
        }

        public QueriesDxEntityConfiguration(string schema)
        {
            ToTable("tQueriesDx", schema);
            HasKey(x => x.QueryId);

            Property(x => x.QueryId).HasColumnName(@"QueryId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.XmlQuery).HasColumnName(@"XmlQuery").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.IsLocked).HasColumnName(@"IsLocked").HasColumnType("bit").IsRequired();
            Property(x => x.Version).HasColumnName(@"Version").HasColumnType("bigint").IsRequired();
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(250);
            HasMany(t => t.ReportsDxes).WithMany(t => t.QueriesDxes).Map(m =>
            {
                m.ToTable("tReportQueryDx", "Settings");
                m.MapLeftKey("QueryId");
                m.MapRightKey("ReportId");
            });
        }
    }
}
