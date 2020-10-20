using MappingSPO.Entities;

namespace MappingSPO
{
    public class DocCode3EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<DocCode3Entity>
    {
        public DocCode3EntityConfiguration()
            : this("Documents")
        {
        }

        public DocCode3EntityConfiguration(string schema)
        {
            ToTable("tDocCode3", schema);
            HasKey(x => x.CodeId);

            Property(x => x.CodeId).HasColumnName(@"CodeID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CalcCode).HasColumnName(@"CalcCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.CalcDisabled).HasColumnName(@"CalcDisabled").HasColumnType("bit").IsRequired();
        }
    }
}
