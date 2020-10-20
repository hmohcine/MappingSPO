using MappingSPO.Entities;

namespace MappingSPO
{
    public class SageBobCompanySettingEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SageBobCompanySettingEntity>
    {
        public SageBobCompanySettingEntityConfiguration()
            : this("Settings")
        {
        }

        public SageBobCompanySettingEntityConfiguration(string schema)
        {
            ToTable("tSageBobCompanySettings", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsRequired();
            Property(x => x.DossierCode).HasColumnName(@"DossierCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(10);
            Property(x => x.BookYearCode).HasColumnName(@"BookYearCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(5);
            Property(x => x.BookYearStartDate).HasColumnName(@"BookYearStartDate").HasColumnType("date").IsRequired();
            Property(x => x.BookYearEndDate).HasColumnName(@"BookYearEndDate").HasColumnType("date").IsRequired();
            Property(x => x.LocationExport).HasColumnName(@"LocationExport").HasColumnType("nvarchar").IsRequired().HasMaxLength(500);
            Property(x => x.LocationSalesInvoice).HasColumnName(@"LocationSalesInvoice").HasColumnType("nvarchar").IsOptional().HasMaxLength(500);
            Property(x => x.LocationSalesCreditNota).HasColumnName(@"LocationSalesCreditNota").HasColumnType("nvarchar").IsOptional().HasMaxLength(500);
            Property(x => x.DagboekCodeSalesInvoice).HasColumnName(@"DagboekCodeSalesInvoice").HasColumnType("nvarchar").IsRequired().HasMaxLength(4);
            Property(x => x.DagboekCodeSalesCreditnota).HasColumnName(@"DagboekCodeSalesCreditnota").HasColumnType("nvarchar").IsRequired().HasMaxLength(4);
            Property(x => x.BatFileSalesInvoice).HasColumnName(@"BatFileSalesInvoice").HasColumnType("nvarchar").IsRequired().HasMaxLength(500);
            Property(x => x.DagboekCodeLeveringen).HasColumnName(@"DagboekCodeLeveringen").HasColumnType("nvarchar").IsRequired().HasMaxLength(500);
            Property(x => x.BatFileLeveringen).HasColumnName(@"BatFileLeveringen").HasColumnType("nvarchar").IsRequired().HasMaxLength(500);

            HasRequired(a => a.Company).WithMany(b => b.SageBobCompanySettings).HasForeignKey(c => c.CompanyId).WillCascadeOnDelete(false);
        }
    }
}
