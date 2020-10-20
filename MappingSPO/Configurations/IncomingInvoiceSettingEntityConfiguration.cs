using MappingSPO.Entities;

namespace MappingSPO
{
    public class IncomingInvoiceSettingEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<IncomingInvoiceSettingEntity>
    {
        public IncomingInvoiceSettingEntityConfiguration()
            : this("Settings")
        {
        }

        public IncomingInvoiceSettingEntityConfiguration(string schema)
        {
            ToTable("tIncomingInvoiceSettings", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DigitsNumber).HasColumnName(@"DigitsNumber").HasColumnType("int").IsRequired();
            Property(x => x.DigitsYear).HasColumnName(@"DigitsYear").HasColumnType("int").IsRequired();
            Property(x => x.PrefixInvoice).HasColumnName(@"PrefixInvoice").HasColumnType("nvarchar").IsRequired().HasMaxLength(4);
            Property(x => x.PrefixCreditNota).HasColumnName(@"PrefixCreditNota").HasColumnType("nvarchar").IsRequired().HasMaxLength(4);
            Property(x => x.ModuleActive).HasColumnName(@"ModuleActive").HasColumnType("bit").IsRequired();
            Property(x => x.MaxResiduPercent).HasColumnName(@"MaxResiduPercent").HasColumnType("float").IsOptional();
            Property(x => x.MaxResiduValue).HasColumnName(@"MaxResiduValue").HasColumnType("float").IsOptional();
            Property(x => x.DefaultEc).HasColumnName(@"DefaultEC").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);

            HasOptional(a => a.Uc).WithMany(b => b.IncomingInvoiceSettings).HasForeignKey(c => c.DefaultEc).WillCascadeOnDelete(false);
        }
    }
}
