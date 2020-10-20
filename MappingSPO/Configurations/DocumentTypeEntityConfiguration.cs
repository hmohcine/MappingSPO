using MappingSPO.Entities;

namespace MappingSPO
{
    public class DocumentTypeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<DocumentTypeEntity>
    {
        public DocumentTypeEntityConfiguration()
            : this("Documents")
        {
        }

        public DocumentTypeEntityConfiguration(string schema)
        {
            ToTable("tDocumentType", schema);
            HasKey(x => x.DocTypeId);

            Property(x => x.DocTypeId).HasColumnName(@"DocTypeID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DocType).HasColumnName(@"DocType").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
        }
    }
}
