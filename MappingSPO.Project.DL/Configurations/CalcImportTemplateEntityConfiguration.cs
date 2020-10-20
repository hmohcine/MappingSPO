using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcImportTemplateEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcImportTemplateEntity>
    {
        public CalcImportTemplateEntityConfiguration()
            : this("Project")
        {
        }

        public CalcImportTemplateEntityConfiguration(string schema)
        {
            ToTable("tCalcImportTemplates", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.Template).HasColumnName(@"Template").HasColumnType("nvarchar(max)").IsRequired();
        }
    }
}
