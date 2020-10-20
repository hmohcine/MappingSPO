using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WCalculationInkoopCatEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WCalculationInkoopCatEntity>
    {
        public WCalculationInkoopCatEntityConfiguration()
            : this("dbo")
        {
        }

        public WCalculationInkoopCatEntityConfiguration(string schema)
        {
            ToTable("vwCalculationInkoopCats", schema);
            HasKey(x => x.CalcId);

            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.InkoopCats).HasColumnName(@"InkoopCats").HasColumnType("nvarchar(max)").IsOptional();
        }
    }
}
