using MappingSPO.Entities;

namespace MappingSPO
{
    public class BAnaCodeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BAnaCodeEntity>
    {
        public BAnaCodeEntityConfiguration()
            : this("Settings")
        {
        }

        public BAnaCodeEntityConfiguration(string schema)
        {
            ToTable("tBAnaCode", schema);
            HasKey(x => x.AnaCodeId);

            Property(x => x.AnaCodeId).HasColumnName(@"AnaCodeID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SubGroupId).HasColumnName(@"SubGroupID").HasColumnType("bigint").IsRequired();
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.AnaMode).HasColumnName(@"AnaMode").HasColumnType("int").IsRequired();

            HasRequired(a => a.BAnaSubGroup).WithMany(b => b.BAnaCodes).HasForeignKey(c => c.SubGroupId).WillCascadeOnDelete(false);
        }
    }
}
