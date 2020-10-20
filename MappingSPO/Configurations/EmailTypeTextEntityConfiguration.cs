using MappingSPO.Entities;

namespace MappingSPO
{
    public class EmailTypeTextEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmailTypeTextEntity>
    {
        public EmailTypeTextEntityConfiguration()
            : this("Settings")
        {
        }

        public EmailTypeTextEntityConfiguration(string schema)
        {
            ToTable("tEmailTypeText", schema);
            HasKey(x => x.EmailTypeTextId);

            Property(x => x.EmailTypeTextId).HasColumnName(@"EmailTypeTextId").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.EmailTypeId).HasColumnName(@"EmailTypeId").HasColumnType("bigint").IsRequired();
            Property(x => x.LanguageCode).HasColumnName(@"LanguageCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(4);
            Property(x => x.Subject).HasColumnName(@"Subject").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.Body).HasColumnName(@"Body").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.HtmlBody).HasColumnName(@"HtmlBody").HasColumnType("nvarchar(max)").IsOptional();

            HasRequired(a => a.EmailType).WithMany(b => b.EmailTypeTexts).HasForeignKey(c => c.EmailTypeId).WillCascadeOnDelete(false);
            HasRequired(a => a.Language).WithMany(b => b.EmailTypeTexts).HasForeignKey(c => c.LanguageCode).WillCascadeOnDelete(false);
        }
    }
}
