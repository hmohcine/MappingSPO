using MappingSPO.Entities;

namespace MappingSPO
{
    public class EmmaTextenEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmmaTextenEntity>
    {
        public EmmaTextenEntityConfiguration()
            : this("Settings")
        {
        }

        public EmmaTextenEntityConfiguration(string schema)
        {
            ToTable("tEmmaTexten", schema);
            HasKey(x => x.TextId);

            Property(x => x.TextId).HasColumnName(@"TextID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ReferentieIntern).HasColumnName(@"ReferentieIntern").HasColumnType("nvarchar").IsRequired().HasMaxLength(250);
            Property(x => x.RtfText).HasColumnName(@"rtfText").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ShowOnOffer).HasColumnName(@"ShowOnOffer").HasColumnType("bit").IsRequired();
            Property(x => x.ShowOnVko).HasColumnName(@"ShowOnVKO").HasColumnType("bit").IsRequired();
            Property(x => x.ShowOnInvoice).HasColumnName(@"ShowOnInvoice").HasColumnType("bit").IsRequired();
            Property(x => x.ShowOnLeverbon).HasColumnName(@"ShowOnLeverbon").HasColumnType("bit").IsRequired();
            Property(x => x.ShowOnBestelbon).HasColumnName(@"ShowOnBestelbon").HasColumnType("bit").IsRequired();
            Property(x => x.KeepToghether).HasColumnName(@"KeepToghether").HasColumnType("bit").IsRequired();
            Property(x => x.Type).HasColumnName(@"Type").HasColumnType("tinyint").IsRequired();
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
            Property(x => x.GroupId).HasColumnName(@"GroupID").HasColumnType("bigint").IsRequired();
            Property(x => x.LinePosition).HasColumnName(@"LinePosition").HasColumnType("int").IsRequired();
            Property(x => x.LanguageCode).HasColumnName(@"LanguageCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);

            HasOptional(a => a.Language).WithMany(b => b.EmmaTextens).HasForeignKey(c => c.LanguageCode).WillCascadeOnDelete(false);
            HasRequired(a => a.EmmaTextGroup).WithMany(b => b.EmmaTextens).HasForeignKey(c => c.GroupId).WillCascadeOnDelete(false);
        }
    }
}
