using MappingSPO.Entities;

namespace MappingSPO
{
    public class WinbooksSettingEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WinbooksSettingEntity>
    {
        public WinbooksSettingEntityConfiguration()
            : this("Settings")
        {
        }

        public WinbooksSettingEntityConfiguration(string schema)
        {
            ToTable("tWinbooksSettings", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsRequired();
            Property(x => x.DossierName).HasColumnName(@"DossierName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.LoginUsername).HasColumnName(@"LoginUsername").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.LoginPassword).HasColumnName(@"LoginPassword").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.BookYearName).HasColumnName(@"BookYearName").HasColumnType("nvarchar").IsRequired().HasMaxLength(250);
            Property(x => x.BookYearStartDate).HasColumnName(@"BookYearStartDate").HasColumnType("datetime").IsRequired();
            Property(x => x.BookYearEndDate).HasColumnName(@"BookYearEndDate").HasColumnType("datetime").IsRequired();
            Property(x => x.LocationExport).HasColumnName(@"LocationExport").HasColumnType("nvarchar").IsOptional().HasMaxLength(260);
            Property(x => x.LocationSalesInvoice).HasColumnName(@"LocationSalesInvoice").HasColumnType("nvarchar").IsOptional().HasMaxLength(260);
            Property(x => x.LocationSalesCreditNota).HasColumnName(@"LocationSalesCreditNota").HasColumnType("nvarchar").IsOptional().HasMaxLength(260);
            Property(x => x.JournalSales).HasColumnName(@"JournalSales").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.JournalCreditNota).HasColumnName(@"JournalCreditNota").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.AccountCustomer).HasColumnName(@"AccountCustomer").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.AccountSupplier).HasColumnName(@"AccountSupplier").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.FinDiscountVatCode).HasColumnName(@"FinDiscountVatCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.LocationPurchaseInvoice).HasColumnName(@"LocationPurchaseInvoice").HasColumnType("nvarchar").IsOptional().HasMaxLength(260);
            Property(x => x.LocationPurchaseCreditNota).HasColumnName(@"LocationPurchaseCreditNota").HasColumnType("nvarchar").IsOptional().HasMaxLength(260);
            Property(x => x.JournalPurchase).HasColumnName(@"JournalPurchase").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.SiteAna).HasColumnName(@"SiteAna").HasColumnType("int").IsRequired();
            Property(x => x.SalesCatAna).HasColumnName(@"SalesCatAna").HasColumnType("int").IsRequired();
            Property(x => x.PurchaseCatAna).HasColumnName(@"PurchaseCatAna").HasColumnType("int").IsRequired();
            Property(x => x.SiteCodeAna).HasColumnName(@"SiteCodeAna").HasColumnType("int").IsRequired();
            Property(x => x.SiteCodeCode).HasColumnName(@"SiteCodeCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(10);
            Property(x => x.SiteDigitsYear).HasColumnName(@"SiteDigitsYear").HasColumnType("int").IsRequired();
            Property(x => x.SiteDigitsNumber).HasColumnName(@"SiteDigitsNumber").HasColumnType("int").IsRequired();
            Property(x => x.SiteSync).HasColumnName(@"SiteSync").HasColumnType("bit").IsRequired();
            Property(x => x.PurchaseOverschrijvingId).HasColumnName(@"PurchaseOverschrijvingID").HasColumnType("bigint").IsOptional();
            Property(x => x.PurchaseDagboeken).HasColumnName(@"PurchaseDagboeken").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.PurchaseSync).HasColumnName(@"PurchaseSync").HasColumnType("bit").IsRequired();
            Property(x => x.SiteFieldToExport).HasColumnName(@"SiteFieldToExport").HasColumnType("int").IsRequired();
            Property(x => x.PurchaseExcludeSite).HasColumnName(@"PurchaseExcludeSite").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.PaymentsSync).HasColumnName(@"PaymentsSync").HasColumnType("bit").IsRequired();

            HasRequired(a => a.Company).WithMany(b => b.WinbooksSettings).HasForeignKey(c => c.CompanyId).WillCascadeOnDelete(false);
        }
    }
}
