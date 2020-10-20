using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class ProjectSubProjectEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProjectSubProjectEntity>
    {
        public ProjectSubProjectEntityConfiguration()
            : this("Project")
        {
        }

        public ProjectSubProjectEntityConfiguration(string schema)
        {
            ToTable("tProjectSubProject", schema);
            HasKey(x => new { x.MasterProjectId, x.MasterProjectType, x.SubProjectId, x.SubProjectType });

            Property(x => x.MasterProjectId).HasColumnName(@"MasterProjectID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.MasterProjectType).HasColumnName(@"MasterProjectType").HasColumnType("nvarchar").IsRequired().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SubProjectId).HasColumnName(@"SubProjectID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SubProjectType).HasColumnName(@"SubProjectType").HasColumnType("nvarchar").IsRequired().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.LineOrder).HasColumnName(@"LineOrder").HasColumnType("int").IsRequired();
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();

            HasRequired(a => a.MasterProject).WithMany(b => b.ProjectSubProjects_MasterProjectId).HasForeignKey(c => new { c.MasterProjectId, c.MasterProjectType }).WillCascadeOnDelete(false);
            HasRequired(a => a.SubProject).WithMany(b => b.ProjectSubProjects_SubProjectId).HasForeignKey(c => new { c.SubProjectId, c.SubProjectType }).WillCascadeOnDelete(false);
        }
    }
}
