using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WerfVorderingInvoiceEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WerfVorderingInvoiceEntity>
    {
        public WerfVorderingInvoiceEntityConfiguration()
            : this("Project")
        {
        }

        public WerfVorderingInvoiceEntityConfiguration(string schema)
        {
            ToTable("tWerfVordering_Invoice", schema);
            HasKey(x => new { x.WerfId, x.VorderingNr, x.InvoiceId });

            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.VorderingNr).HasColumnName(@"VorderingNr").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.InvoiceId).HasColumnName(@"InvoiceID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }
}
