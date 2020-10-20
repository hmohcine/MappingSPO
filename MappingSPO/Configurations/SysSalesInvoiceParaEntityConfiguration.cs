using MappingSPO.Entities;

namespace MappingSPO
{
    public class SysSalesInvoiceParaEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SysSalesInvoiceParaEntity>
    {
        public SysSalesInvoiceParaEntityConfiguration()
            : this("Settings")
        {
        }

        public SysSalesInvoiceParaEntityConfiguration(string schema)
        {
            ToTable("tsysSalesInvoicePara", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SiteLeaderCaption).HasColumnName(@"SiteLeaderCaption").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ProjectLeiderCaption).HasColumnName(@"ProjectLeiderCaption").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
        }
    }
}
