using MappingSPO.Entities;

namespace MappingSPO
{
    public class DocCode1EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<DocCode1Entity>
    {
        public DocCode1EntityConfiguration()
            : this("Documents")
        {
        }

        public DocCode1EntityConfiguration(string schema)
        {
            ToTable("tDocCode1", schema);
            HasKey(x => x.CodeId);

            Property(x => x.CodeId).HasColumnName(@"CodeID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CalcCode).HasColumnName(@"CalcCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.CalcDisabled).HasColumnName(@"CalcDisabled").HasColumnType("bit").IsRequired();
        }
    }
}
