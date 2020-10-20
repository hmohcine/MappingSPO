using MappingSPO.Entities;

namespace MappingSPO
{
    public class ProjectUnitMultiAnaCodeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProjectUnitMultiAnaCodeEntity>
    {
        public ProjectUnitMultiAnaCodeEntityConfiguration()
            : this("Settings")
        {
        }

        public ProjectUnitMultiAnaCodeEntityConfiguration(string schema)
        {
            ToTable("tProjectUnitMultiAnaCodes", schema);
            HasKey(x => x.MultiId);

            Property(x => x.MultiId).HasColumnName(@"MultiID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.MultiIndex).HasColumnName(@"MultiIndex").HasColumnType("int").IsRequired();
            Property(x => x.MultiName).HasColumnName(@"MultiName").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.Disable).HasColumnName(@"Disable").HasColumnType("bit").IsRequired();
        }
    }
}
