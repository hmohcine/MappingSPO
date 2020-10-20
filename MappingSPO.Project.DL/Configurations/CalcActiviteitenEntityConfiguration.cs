using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcActiviteitenEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcActiviteitenEntity>
    {
        public CalcActiviteitenEntityConfiguration()
            : this("Project")
        {
        }

        public CalcActiviteitenEntityConfiguration(string schema)
        {
            ToTable("tCalcActiviteiten", schema);
            HasKey(x => new { x.CalcId, x.CalcActiviteitId });

            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CalcActiviteitId).HasColumnName(@"CalcActiviteitID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ActiviteitId).HasColumnName(@"ActiviteitID").HasColumnType("bigint").IsOptional();
            Property(x => x.PostId).HasColumnName(@"PostID").HasColumnType("bigint").IsOptional();

            HasRequired(a => a.Calculation).WithMany(b => b.CalcActiviteitens).HasForeignKey(c => c.CalcId);
        }
    }
}
