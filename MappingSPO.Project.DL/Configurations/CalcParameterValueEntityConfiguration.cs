using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcParameterValueEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcParameterValueEntity>
    {
        public CalcParameterValueEntityConfiguration()
            : this("Project")
        {
        }

        public CalcParameterValueEntityConfiguration(string schema)
        {
            ToTable("tCalcParameterValues", schema);
            HasKey(x => new { x.CalcId, x.ParameterName });

            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ParameterName).HasColumnName(@"ParameterName").HasColumnType("nvarchar").IsRequired().HasMaxLength(100).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Value).HasColumnName(@"Value").HasColumnType("float").IsOptional();

            HasRequired(a => a.Calculation).WithMany(b => b.CalcParameterValues).HasForeignKey(c => c.CalcId);
            HasRequired(a => a.ParameterDefinition).WithMany(b => b.CalcParameterValues).HasForeignKey(c => c.ParameterName).WillCascadeOnDelete(false);
        }
    }
}
