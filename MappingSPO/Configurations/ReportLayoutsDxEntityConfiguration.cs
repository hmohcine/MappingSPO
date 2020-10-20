using MappingSPO.Entities;

namespace MappingSPO
{
    public class ReportLayoutsDxEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ReportLayoutsDxEntity>
    {
        public ReportLayoutsDxEntityConfiguration()
            : this("Settings")
        {
        }

        public ReportLayoutsDxEntityConfiguration(string schema)
        {
            ToTable("tReportLayoutsDx", schema);
            HasKey(x => new { x.ReportId, x.LangCode });

            Property(x => x.ReportId).HasColumnName(@"ReportId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.LangCode).HasColumnName(@"LangCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Layout).HasColumnName(@"Layout").HasColumnType("varbinary(max)").IsRequired();
            Property(x => x.Version).HasColumnName(@"Version").HasColumnType("bigint").IsRequired();

            HasRequired(a => a.Language).WithMany(b => b.ReportLayoutsDxes).HasForeignKey(c => c.LangCode).WillCascadeOnDelete(false);
            HasRequired(a => a.ReportsDx).WithMany(b => b.ReportLayoutsDxes).HasForeignKey(c => c.ReportId).WillCascadeOnDelete(false);
        }
    }
}
