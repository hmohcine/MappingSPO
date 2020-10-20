using MappingSPO.Entities;

namespace MappingSPO
{
    public class CodeCaptionTranslationEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CodeCaptionTranslationEntity>
    {
        public CodeCaptionTranslationEntityConfiguration()
            : this("Settings")
        {
        }

        public CodeCaptionTranslationEntityConfiguration(string schema)
        {
            ToTable("tCodeCaptionTranslations", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Context).HasColumnName(@"Context").HasColumnType("int").IsRequired();
            Property(x => x.CodeIndex).HasColumnName(@"CodeIndex").HasColumnType("int").IsRequired();
            Property(x => x.LanguageCode).HasColumnName(@"LanguageCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(4);
            Property(x => x.Caption).HasColumnName(@"Caption").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);

            HasRequired(a => a.Language).WithMany(b => b.CodeCaptionTranslations).HasForeignKey(c => c.LanguageCode).WillCascadeOnDelete(false);
        }
    }
}
