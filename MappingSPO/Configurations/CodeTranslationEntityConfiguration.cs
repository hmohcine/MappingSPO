using MappingSPO.Entities;

namespace MappingSPO
{
    public class CodeTranslationEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CodeTranslationEntity>
    {
        public CodeTranslationEntityConfiguration()
            : this("Settings")
        {
        }

        public CodeTranslationEntityConfiguration(string schema)
        {
            ToTable("tCodeTranslations", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Context).HasColumnName(@"Context").HasColumnType("int").IsRequired();
            Property(x => x.CodeIndex).HasColumnName(@"CodeIndex").HasColumnType("int").IsRequired();
            Property(x => x.CodeId).HasColumnName(@"CodeId").HasColumnType("int").IsRequired();
            Property(x => x.LanguageCode).HasColumnName(@"LanguageCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(4);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);

            HasRequired(a => a.Language).WithMany(b => b.CodeTranslations).HasForeignKey(c => c.LanguageCode).WillCascadeOnDelete(false);
        }
    }
}
