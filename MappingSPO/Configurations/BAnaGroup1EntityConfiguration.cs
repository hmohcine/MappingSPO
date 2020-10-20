using MappingSPO.Entities;

namespace MappingSPO
{
    public class BAnaGroup1EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BAnaGroup1Entity>
    {
        public BAnaGroup1EntityConfiguration()
            : this("Settings")
        {
        }

        public BAnaGroup1EntityConfiguration(string schema)
        {
            ToTable("tBAnaGroup1", schema);
            HasKey(x => x.GroupId);

            Property(x => x.GroupId).HasColumnName(@"GroupID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.GroupName).HasColumnName(@"GroupName").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
        }
    }
}
