using MappingSPO.Entities;

namespace MappingSPO
{
    public class VatRegimeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VatRegimeEntity>
    {
        public VatRegimeEntityConfiguration()
            : this("Settings")
        {
        }

        public VatRegimeEntityConfiguration(string schema)
        {
            ToTable("tVATRegime", schema);
            HasKey(x => x.BtwRegime);

            Property(x => x.BtwRegime).HasColumnName(@"BTWRegime").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.ExternalCode).HasColumnName(@"ExternalCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CalcWithOtherCode).HasColumnName(@"CalcWithOtherCode").HasColumnType("bit").IsOptional();
            Property(x => x.OtherCode).HasColumnName(@"OtherCode").HasColumnType("int").IsOptional();

            HasOptional(a => a.Vat).WithMany(b => b.VatRegimes).HasForeignKey(c => c.OtherCode).WillCascadeOnDelete(false);
        }
    }
}
