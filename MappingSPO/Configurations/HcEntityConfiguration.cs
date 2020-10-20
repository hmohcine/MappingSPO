using MappingSPO.Entities;

namespace MappingSPO
{
    public class HcEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<HcEntity>
    {
        public HcEntityConfiguration()
            : this("Settings")
        {
        }

        public HcEntityConfiguration(string schema)
        {
            ToTable("tHC", schema);
            HasKey(x => x.CalcHc);

            Property(x => x.CalcHc).HasColumnName(@"CalcHC").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.OverVorderenYn).HasColumnName(@"OverVorderenYn").HasColumnType("smallint").IsRequired();
            Property(x => x.AutoCreateOnCalc).HasColumnName(@"AutoCreateOnCalc").HasColumnType("bit").IsOptional();
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
        }
    }
}
