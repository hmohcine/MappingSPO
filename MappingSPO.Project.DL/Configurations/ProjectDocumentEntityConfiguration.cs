using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class ProjectDocumentEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProjectDocumentEntity>
    {
        public ProjectDocumentEntityConfiguration()
            : this("Project")
        {
        }

        public ProjectDocumentEntityConfiguration(string schema)
        {
            ToTable("tProjectDocuments", schema);
            HasKey(x => new { x.ProjectId, x.ProjectType, x.DocumentId });

            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsRequired().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DocumentId).HasColumnName(@"DocumentID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            HasRequired(a => a.Project).WithMany(b => b.ProjectDocuments).HasForeignKey(c => new { c.ProjectId, c.ProjectType }).WillCascadeOnDelete(false);
        }
    }
}
