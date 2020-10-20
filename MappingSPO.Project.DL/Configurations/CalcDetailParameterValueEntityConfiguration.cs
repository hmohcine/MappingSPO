using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcDetailParameterValueEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcDetailParameterValueEntity>
    {
        public CalcDetailParameterValueEntityConfiguration()
            : this("Project")
        {
        }

        public CalcDetailParameterValueEntityConfiguration(string schema)
        {
            ToTable("tCalcDetailParameterValue", schema);
            HasKey(x => new { x.CalcDetailId, x.CalcId, x.ParameterName });

            Property(x => x.CalcDetailId).HasColumnName(@"CalcDetailID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ParameterName).HasColumnName(@"ParameterName").HasColumnType("nvarchar").IsRequired().HasMaxLength(100).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Value).HasColumnName(@"Value").HasColumnType("float").IsOptional();

            HasRequired(a => a.CalcDetail).WithMany(b => b.CalcDetailParameterValues).HasForeignKey(c => new { c.CalcDetailId, c.CalcId });
            HasRequired(a => a.ParameterDefinition).WithMany(b => b.CalcDetailParameterValues).HasForeignKey(c => c.ParameterName).WillCascadeOnDelete(false);
        }
    }
}
