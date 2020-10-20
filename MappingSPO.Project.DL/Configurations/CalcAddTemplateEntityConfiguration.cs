using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcAddTemplateEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcAddTemplateEntity>
    {
        public CalcAddTemplateEntityConfiguration()
            : this("Project")
        {
        }

        public CalcAddTemplateEntityConfiguration(string schema)
        {
            ToTable("tCalcAddTemplates", schema);
            HasKey(x => x.CalcId);

            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.LineOrder).HasColumnName(@"LineOrder").HasColumnType("int").IsRequired();
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nvarchar").IsRequired().HasMaxLength(1);

            HasRequired(a => a.Calculation).WithOptional(b => b.CalcAddTemplate).WillCascadeOnDelete(false);
        }
    }
}
