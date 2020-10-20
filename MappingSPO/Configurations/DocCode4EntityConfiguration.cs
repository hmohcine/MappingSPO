using MappingSPO.Entities;

namespace MappingSPO
{
    public class DocCode4EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<DocCode4Entity>
    {
        public DocCode4EntityConfiguration()
            : this("Documents")
        {
        }

        public DocCode4EntityConfiguration(string schema)
        {
            ToTable("tDocCode4", schema);
            HasKey(x => x.CodeId);

            Property(x => x.CodeId).HasColumnName(@"CodeID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CalcCode).HasColumnName(@"CalcCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.CalcDisabled).HasColumnName(@"CalcDisabled").HasColumnType("bit").IsRequired();
        }
    }
}
