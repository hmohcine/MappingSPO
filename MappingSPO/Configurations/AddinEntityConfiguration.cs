using MappingSPO.Entities;

namespace MappingSPO
{
    public class AddinEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AddinEntity>
    {
        public AddinEntityConfiguration()
            : this("Settings")
        {
        }

        public AddinEntityConfiguration(string schema)
        {
            ToTable("tAddin", schema);
            HasKey(x => x.AddinId);

            Property(x => x.AddinId).HasColumnName(@"AddinID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AddinName).HasColumnName(@"AddinName").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(x => x.FullPath).HasColumnName(@"FullPath").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.Trusted).HasColumnName(@"Trusted").HasColumnType("bit").IsRequired();
            Property(x => x.Enabled).HasColumnName(@"Enabled").HasColumnType("bit").IsRequired();
        }
    }
}
