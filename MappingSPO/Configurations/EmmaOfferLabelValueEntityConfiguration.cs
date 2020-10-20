using MappingSPO.Entities;

namespace MappingSPO
{
    public class EmmaOfferLabelValueEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmmaOfferLabelValueEntity>
    {
        public EmmaOfferLabelValueEntityConfiguration()
            : this("Settings")
        {
        }

        public EmmaOfferLabelValueEntityConfiguration(string schema)
        {
            ToTable("tEmmaOfferLabelValues", schema);
            HasKey(x => new { x.LabelId, x.OfferType });

            Property(x => x.LabelId).HasColumnName(@"LabelID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.OfferType).HasColumnName(@"OfferType").HasColumnType("nvarchar").IsRequired().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.LanguageCode).HasColumnName(@"LanguageCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(4);
            Property(x => x.LabelType).HasColumnName(@"LabelType").HasColumnType("tinyint").IsRequired();
            Property(x => x.LabelValue).HasColumnName(@"LabelValue").HasColumnType("nvarchar").IsOptional().HasMaxLength(1000);
            Property(x => x.TextId).HasColumnName(@"TextID").HasColumnType("bigint").IsOptional();

            HasOptional(a => a.EmmaTexten).WithMany(b => b.EmmaOfferLabelValues).HasForeignKey(c => c.TextId).WillCascadeOnDelete(false);
            HasRequired(a => a.EmmaOfferType).WithMany(b => b.EmmaOfferLabelValues).HasForeignKey(c => c.OfferType).WillCascadeOnDelete(false);
            HasRequired(a => a.Language).WithMany(b => b.EmmaOfferLabelValues).HasForeignKey(c => c.LanguageCode).WillCascadeOnDelete(false);
        }
    }
}
