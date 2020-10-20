using MappingSPO.Entities;

namespace MappingSPO
{
    public class ProjectTypeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProjectTypeEntity>
    {
        public ProjectTypeEntityConfiguration()
            : this("Settings")
        {
        }

        public ProjectTypeEntityConfiguration(string schema)
        {
            ToTable("tProjectTypes", schema);
            HasKey(x => x.ProjectType_);

            Property(x => x.ProjectType_).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsRequired().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ProjectMasterType).HasColumnName(@"ProjectMasterType").HasColumnType("int").IsRequired();
            Property(x => x.DigitsDocumentnummer).HasColumnName(@"DigitsDocumentnummer").HasColumnType("int").IsRequired();
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
            Property(x => x.ForeCastingYn).HasColumnName(@"ForeCastingYn").HasColumnType("bit").IsRequired();
            Property(x => x.DefaultCodeRange).HasColumnName(@"DefaultCodeRange").HasColumnType("int").IsRequired();
            Property(x => x.AutoLinkWerfYnOnCreate).HasColumnName(@"AutoLinkWerfYnOnCreate").HasColumnType("bit").IsRequired();
            Property(x => x.HasExtendedSecurity).HasColumnName(@"HasExtendedSecurity").HasColumnType("bit").IsRequired();
            Property(x => x.TotalsColumn).HasColumnName(@"TotalsColumn").HasColumnType("int").IsRequired();
            Property(x => x.ProjectNumberStyle).HasColumnName(@"ProjectNumberStyle").HasColumnType("int").IsOptional();
            Property(x => x.ProjectYearMode).HasColumnName(@"ProjectYearMode").HasColumnType("int").IsOptional();
            Property(x => x.ProjectNumberDigits).HasColumnName(@"ProjectNumberDigits").HasColumnType("int").IsOptional();
        }
    }
}
