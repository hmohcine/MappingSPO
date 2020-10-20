using MappingSPO.Entities;

namespace MappingSPO
{
    public class ProjectCode3EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProjectCode3Entity>
    {
        public ProjectCode3EntityConfiguration()
            : this("Project")
        {
        }

        public ProjectCode3EntityConfiguration(string schema)
        {
            ToTable("tProjectCode3", schema);
            HasKey(x => x.CodeId);

            Property(x => x.CodeId).HasColumnName(@"CodeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
        }
    }
}
