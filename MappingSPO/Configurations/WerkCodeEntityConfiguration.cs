using MappingSPO.Entities;

namespace MappingSPO
{
    public class WerkCodeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WerkCodeEntity>
    {
        public WerkCodeEntityConfiguration()
            : this("Settings")
        {
        }

        public WerkCodeEntityConfiguration(string schema)
        {
            ToTable("tWerkCode", schema);
            HasKey(x => x.WerkCode_);

            Property(x => x.WerkCode_).HasColumnName(@"WerkCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.IsWerkend).HasColumnName(@"IsWerkend").HasColumnType("bit").IsRequired();
            Property(x => x.DefaultLoonCostFactor).HasColumnName(@"DefaultLoonCostFactor").HasColumnType("decimal").IsOptional().HasPrecision(20,6);
            Property(x => x.ExternalCode).HasColumnName(@"ExternalCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.ExtVvAvailability).HasColumnName(@"ExtVV_Availability").HasColumnType("int").IsOptional();
            Property(x => x.ExtVvFactor).HasColumnName(@"ExtVV_Factor").HasColumnType("float").IsOptional();
            Property(x => x.ExtVvGroepSCode).HasColumnName(@"ExtVV_GroepSCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.VoorschotBerekenenYn).HasColumnName(@"VoorschotBerekenenYn").HasColumnType("bit").IsRequired();
            Property(x => x.WerkcodeType).HasColumnName(@"WerkcodeType").HasColumnType("int").IsRequired();
            Property(x => x.Ks).HasColumnName(@"KS").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);

            HasOptional(a => a.Ks_Ks).WithMany(b => b.WerkCodes).HasForeignKey(c => c.Ks).WillCascadeOnDelete(false);
        }
    }
}
