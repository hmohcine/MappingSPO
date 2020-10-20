using MappingSPO.Entities;

namespace MappingSPO
{
    public class WerfPropertiesItemEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WerfPropertiesItemEntity>
    {
        public WerfPropertiesItemEntityConfiguration()
            : this("Settings")
        {
        }

        public WerfPropertiesItemEntityConfiguration(string schema)
        {
            ToTable("tWerfPropertiesItems", schema);
            HasKey(x => x.Name);

            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(100).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PType).HasColumnName(@"pType").HasColumnType("int").IsOptional();
            Property(x => x.PDefaultvalue).HasColumnName(@"pDefaultvalue").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.PListXml).HasColumnName(@"pListXML").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.PUiType).HasColumnName(@"pUIType").HasColumnType("int").IsOptional();
            Property(x => x.AutoAddOnNewWerf).HasColumnName(@"AutoAddOnNewWerf").HasColumnType("bit").IsOptional();
        }
    }
}
