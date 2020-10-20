using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcInkoopCategorieEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcInkoopCategorieEntity>
    {
        public CalcInkoopCategorieEntityConfiguration()
            : this("Project")
        {
        }

        public CalcInkoopCategorieEntityConfiguration(string schema)
        {
            ToTable("tCalcInkoopCategorie", schema);
            HasKey(x => new { x.CalcId, x.ImpactType, x.CalcInkoopCatId, x.CatType });

            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ImpactType).HasColumnName(@"ImpactType").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CalcInkoopCatId).HasColumnName(@"CalcInkoopCatID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Tkp).HasColumnName(@"TKP").HasColumnType("float").IsRequired();
            Property(x => x.Btw).HasColumnName(@"BTW").HasColumnType("decimal").IsRequired().HasPrecision(20,8);
            Property(x => x.TvPex).HasColumnName(@"TVPex").HasColumnType("decimal").IsRequired().HasPrecision(20,8);
            Property(x => x.CatType).HasColumnName(@"CatType").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            HasRequired(a => a.Calculation).WithMany(b => b.CalcInkoopCategories).HasForeignKey(c => c.CalcId);
        }
    }
}
