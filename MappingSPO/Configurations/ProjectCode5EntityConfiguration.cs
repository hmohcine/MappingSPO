using MappingSPO.Entities;

namespace MappingSPO
{
    public class ProjectCode5EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProjectCode5Entity>
    {
        public ProjectCode5EntityConfiguration()
            : this("Project")
        {
        }

        public ProjectCode5EntityConfiguration(string schema)
        {
            ToTable("tProjectCode5", schema);
            HasKey(x => x.CodeId);

            Property(x => x.CodeId).HasColumnName(@"CodeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
        }
    }
}
