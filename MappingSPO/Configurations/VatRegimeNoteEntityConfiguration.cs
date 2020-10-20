using MappingSPO.Entities;

namespace MappingSPO
{
    public class VatRegimeNoteEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VatRegimeNoteEntity>
    {
        public VatRegimeNoteEntityConfiguration()
            : this("Settings")
        {
        }

        public VatRegimeNoteEntityConfiguration(string schema)
        {
            ToTable("tVATRegimeNotes", schema);
            HasKey(x => new { x.BtwRegime, x.LanguageCode });

            Property(x => x.BtwRegime).HasColumnName(@"BTWRegime").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.LanguageCode).HasColumnName(@"LanguageCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.NotesVat).HasColumnName(@"NotesVAT").HasColumnType("nvarchar(max)").IsOptional();

            HasRequired(a => a.Language).WithMany(b => b.VatRegimeNotes).HasForeignKey(c => c.LanguageCode).WillCascadeOnDelete(false);
            HasRequired(a => a.VatRegime).WithMany(b => b.VatRegimeNotes).HasForeignKey(c => c.BtwRegime).WillCascadeOnDelete(false);
        }
    }
}
