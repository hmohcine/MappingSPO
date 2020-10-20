using MappingSPO.Entities;

namespace MappingSPO
{
    public class BtwBoekingsgroepEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BtwBoekingsgroepEntity>
    {
        public BtwBoekingsgroepEntityConfiguration()
            : this("Settings")
        {
        }

        public BtwBoekingsgroepEntityConfiguration(string schema)
        {
            ToTable("tBTWBoekingsgroep", schema);
            HasKey(x => x.BtwBoekingsgroepId);

            Property(x => x.BtwBoekingsgroepId).HasColumnName(@"BTWBoekingsgroepID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsRequired().HasMaxLength(150);
            Property(x => x.BtwRegime).HasColumnName(@"BTWRegime").HasColumnType("int").IsRequired();
            Property(x => x.VatCode).HasColumnName(@"VatCode").HasColumnType("int").IsRequired();
            Property(x => x.CalcVatCode).HasColumnName(@"CalcVatCode").HasColumnType("int").IsRequired();

            HasRequired(a => a.Vat_CalcVatCode).WithMany(b => b.BtwBoekingsgroeps_CalcVatCode).HasForeignKey(c => c.CalcVatCode).WillCascadeOnDelete(false);
            HasRequired(a => a.Vat_VatCode).WithMany(b => b.BtwBoekingsgroeps_VatCode).HasForeignKey(c => c.VatCode).WillCascadeOnDelete(false);
            HasRequired(a => a.VatRegime).WithMany(b => b.BtwBoekingsgroeps).HasForeignKey(c => c.BtwRegime).WillCascadeOnDelete(false);
        }
    }
}
