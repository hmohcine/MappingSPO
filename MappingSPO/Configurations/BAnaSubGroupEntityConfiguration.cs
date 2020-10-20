using MappingSPO.Entities;

namespace MappingSPO
{
    public class BAnaSubGroupEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BAnaSubGroupEntity>
    {
        public BAnaSubGroupEntityConfiguration()
            : this("Settings")
        {
        }

        public BAnaSubGroupEntityConfiguration(string schema)
        {
            ToTable("tBAnaSubGroup", schema);
            HasKey(x => x.SubGroupId);

            Property(x => x.SubGroupId).HasColumnName(@"SubGroupID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.GroupId).HasColumnName(@"GroupID").HasColumnType("bigint").IsRequired();
            Property(x => x.SubGroupName).HasColumnName(@"SubGroupName").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);

            HasRequired(a => a.BAnaGroup1).WithMany(b => b.BAnaSubGroups).HasForeignKey(c => c.GroupId).WillCascadeOnDelete(false);
        }
    }
}
