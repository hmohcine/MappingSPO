using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcHcEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcHcEntity>
    {
        public CalcHcEntityConfiguration()
            : this("Project")
        {
        }

        public CalcHcEntityConfiguration(string schema)
        {
            ToTable("tCalcHC", schema);
            HasKey(x => new { x.CalcId, x.CalcHc_ });

            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CalcHc_).HasColumnName(@"CalcHC").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.OverVorderenYn).HasColumnName(@"OverVorderenYn").HasColumnType("smallint").IsRequired();

            HasRequired(a => a.Calculation).WithMany(b => b.CalcHcs).HasForeignKey(c => c.CalcId);
        }
    }
}
