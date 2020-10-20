using MappingSPO.Entities;

namespace MappingSPO
{
    public class WerfMultiAnaCodeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WerfMultiAnaCodeEntity>
    {
        public WerfMultiAnaCodeEntityConfiguration()
            : this("Settings")
        {
        }

        public WerfMultiAnaCodeEntityConfiguration(string schema)
        {
            ToTable("tWerfMultiAnaCodes", schema);
            HasKey(x => x.MultiId);

            Property(x => x.MultiId).HasColumnName(@"MultiID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.MultiIndex).HasColumnName(@"MultiIndex").HasColumnType("int").IsRequired();
            Property(x => x.MultiName).HasColumnName(@"MultiName").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.Disable).HasColumnName(@"Disable").HasColumnType("bit").IsRequired();
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1);
        }
    }
}
