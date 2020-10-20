using MappingSPO.Entities;

namespace MappingSPO
{
    public class ProjectResultReasonEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProjectResultReasonEntity>
    {
        public ProjectResultReasonEntityConfiguration()
            : this("Settings")
        {
        }

        public ProjectResultReasonEntityConfiguration(string schema)
        {
            ToTable("tProjectResultReason", schema);
            HasKey(x => x.ProjectResultReasonId);

            Property(x => x.ProjectResultReasonId).HasColumnName(@"ProjectResultReasonID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ProjectResultReason_).HasColumnName(@"ProjectResultReason").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
        }
    }
}
