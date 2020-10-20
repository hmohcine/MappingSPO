using MappingSPO.Entities;

namespace MappingSPO
{
    public class EmmaTextGroupEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmmaTextGroupEntity>
    {
        public EmmaTextGroupEntityConfiguration()
            : this("Settings")
        {
        }

        public EmmaTextGroupEntityConfiguration(string schema)
        {
            ToTable("tEmmaTextGroup", schema);
            HasKey(x => x.GroupId);

            Property(x => x.GroupId).HasColumnName(@"GroupID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.GroupName).HasColumnName(@"GroupName").HasColumnType("nvarchar").IsRequired().HasMaxLength(150);
            Property(x => x.GroupType).HasColumnName(@"GroupType").HasColumnType("tinyint").IsRequired();
        }
    }
}
