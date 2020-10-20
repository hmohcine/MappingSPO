using MappingSPO.Entities;

namespace MappingSPO
{
    public class ReportsDxFormLinkEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ReportsDxFormLinkEntity>
    {
        public ReportsDxFormLinkEntityConfiguration()
            : this("Settings")
        {
        }

        public ReportsDxFormLinkEntityConfiguration(string schema)
        {
            ToTable("tReportsDxFormLink", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ReportId).HasColumnName(@"ReportId").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.FormGuid).HasColumnName(@"FormGuid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.LanguageDetemination).HasColumnName(@"LanguageDetemination").HasColumnType("int").IsRequired();
            Property(x => x.Sequence).HasColumnName(@"Sequence").HasColumnType("int").IsRequired();
            Property(x => x.IsDefaultReport).HasColumnName(@"IsDefaultReport").HasColumnType("bit").IsRequired();

            HasRequired(a => a.ReportsDx).WithMany(b => b.ReportsDxFormLinks).HasForeignKey(c => c.ReportId).WillCascadeOnDelete(false);
        }
    }
}
