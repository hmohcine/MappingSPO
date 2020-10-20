using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class ProjectCalculationEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProjectCalculationEntity>
    {
        public ProjectCalculationEntityConfiguration()
            : this("Project")
        {
        }

        public ProjectCalculationEntityConfiguration(string schema)
        {
            ToTable("tProjectCalculations", schema);
            HasKey(x => new { x.ProjectId, x.ProjectType, x.CalcId });

            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsRequired().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IncludeInSum).HasColumnName(@"IncludeInSum").HasColumnType("bit").IsRequired();
            Property(x => x.IncludeInXrm).HasColumnName(@"IncludeInXRM").HasColumnType("bit").IsRequired();
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.LineOrder).HasColumnName(@"LineOrder").HasColumnType("int").IsRequired();

            HasRequired(a => a.Calculation).WithMany(b => b.ProjectCalculations).HasForeignKey(c => c.CalcId);
            HasRequired(a => a.Project).WithMany(b => b.ProjectCalculations).HasForeignKey(c => new { c.ProjectId, c.ProjectType }).WillCascadeOnDelete(false);
        }
    }
}
