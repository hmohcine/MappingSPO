using MappingSPO.Entities;

namespace MappingSPO
{
    public class WerfTypeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WerfTypeEntity>
    {
        public WerfTypeEntityConfiguration()
            : this("Settings")
        {
        }

        public WerfTypeEntityConfiguration(string schema)
        {
            ToTable("tWerfType", schema);
            HasKey(x => x.WerfTypeId);

            Property(x => x.WerfTypeId).HasColumnName(@"WerfTypeID").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.WerfMayorTypeCode).HasColumnName(@"WerfMayorTypeCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1);
            Property(x => x.WerfType_).HasColumnName(@"WerfType").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WerfTypeDescription).HasColumnName(@"WerfTypeDescription").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1);
        }
    }
}
