using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcPropertyEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcPropertyEntity>
    {
        public CalcPropertyEntityConfiguration()
            : this("Project")
        {
        }

        public CalcPropertyEntityConfiguration(string schema)
        {
            ToTable("tCalcProperties", schema);
            HasKey(x => new { x.CalcId, x.PropertyName });

            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PropertyName).HasColumnName(@"PropertyName").HasColumnType("nvarchar").IsRequired().HasMaxLength(200).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PropertyValue).HasColumnName(@"PropertyValue").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);

            HasRequired(a => a.Calculation).WithMany(b => b.CalcProperties).HasForeignKey(c => c.CalcId);
        }
    }
}
