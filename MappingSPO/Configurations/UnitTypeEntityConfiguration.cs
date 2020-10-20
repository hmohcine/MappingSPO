using MappingSPO.Entities;

namespace MappingSPO
{
    public class UnitTypeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UnitTypeEntity>
    {
        public UnitTypeEntityConfiguration()
            : this("Settings")
        {
        }

        public UnitTypeEntityConfiguration(string schema)
        {
            ToTable("tUnitType", schema);
            HasKey(x => x.UnittypeId);

            Property(x => x.UnittypeId).HasColumnName(@"UnittypeID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Unittype).HasColumnName(@"Unittype").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.Afkorting).HasColumnName(@"Afkorting").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.DefaultFormat).HasColumnName(@"DefaultFormat").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
        }
    }
}
