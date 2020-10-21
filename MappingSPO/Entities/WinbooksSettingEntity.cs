
namespace MappingSPO.Entities
{
    public partial class WinbooksSettingEntity
    {
		public WinbooksSettingEntity()
        {
            SiteAna = 0;
            SalesCatAna = 0;
            PurchaseCatAna = 0;
            SiteCodeAna = 0;
            SiteCodeCode = "ZZZ";
            SiteDigitsYear = 4;
            SiteDigitsNumber = 5;
            SiteSync = true;
            PurchaseSync = true;
            SiteFieldToExport = 0;
            PaymentsSync = false;
            Perform1WayMatching = false;
            InitializePartial();
		}

        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string DossierName { get; set; }
        public string LoginUsername { get; set; }
        public string LoginPassword { get; set; }
        public string BookYearName { get; set; }
        public System.DateTime BookYearStartDate { get; set; }
        public System.DateTime BookYearEndDate { get; set; }
        public string LocationExport { get; set; }
        public string LocationSalesInvoice { get; set; }
        public string LocationSalesCreditNota { get; set; }
        public string JournalSales { get; set; }
        public string JournalCreditNota { get; set; }
        public string AccountCustomer { get; set; }
        public string AccountSupplier { get; set; }
        public string FinDiscountVatCode { get; set; }
        public string LocationPurchaseInvoice { get; set; }
        public string LocationPurchaseCreditNota { get; set; }
        public string JournalPurchase { get; set; }
        public int SiteAna { get; set; }
        public int SalesCatAna { get; set; }
        public int PurchaseCatAna { get; set; }
        public int SiteCodeAna { get; set; }
        public string SiteCodeCode { get; set; }
        public int SiteDigitsYear { get; set; }
        public int SiteDigitsNumber { get; set; }
        public bool SiteSync { get; set; }
        public long? PurchaseOverschrijvingId { get; set; }
        public string PurchaseDagboeken { get; set; }
        public bool PurchaseSync { get; set; }
        public int SiteFieldToExport { get; set; }
        public string PurchaseExcludeSite { get; set; }
        public bool PaymentsSync { get; set; }
        public bool Perform1WayMatching { get; set; }
        public CompanyEntity Company { get; set; }
             
        partial void InitializePartial();
    }
}
