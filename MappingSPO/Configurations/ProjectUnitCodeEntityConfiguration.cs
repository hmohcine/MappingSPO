using MappingSPO.Entities;

namespace MappingSPO
{
    public class ProjectUnitCodeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProjectUnitCodeEntity>
    {
        public ProjectUnitCodeEntityConfiguration()
            : this("Settings")
        {
        }

        public ProjectUnitCodeEntityConfiguration(string schema)
        {
            ToTable("tProjectUnitCodes", schema);
            HasKey(x => x.CodeId);

            Property(x => x.CodeId).HasColumnName(@"CodeID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CodeIndex).HasColumnName(@"CodeIndex").HasColumnType("int").IsRequired();
            Property(x => x.CodeDescription).HasColumnName(@"CodeDescription").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
        }
    }
}
