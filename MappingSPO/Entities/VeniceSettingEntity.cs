
namespace MappingSPO.Entities
{
    public partial class VeniceSettingEntity
    {
		public VeniceSettingEntity()
        {
            PurchaseSync = true;
            PurchaseCatAna = 0;
            SiteCodeAna = 0;
            SiteDigitsNumber = 5;
            SiteSync = true;
            RunMatching = false;
            InitializePartial();
		}

        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Cabinet { get; set; }
        public string DossierName { get; set; }
        public string LoginUsername { get; set; }
        public string LoginPassword { get; set; }
        public string LoginInitials { get; set; }
        public string CreatedForVenVer { get; set; }
        public int StartBookYear { get; set; }
        public bool PurchaseSync { get; set; }
        public string JournalSales { get; set; }
        public string JournalCreditNota { get; set; }
        public string AccountCustomer { get; set; }
        public string AccountSupplier { get; set; }
        public int PurchaseCatAna { get; set; }
        public int SiteCodeAna { get; set; }
        public int SiteDigitsNumber { get; set; }
        public bool SiteSync { get; set; }
        public string PurchaseDagboeken { get; set; }
        public bool RunMatching { get; set; }
        public CompanyEntity Company { get; set; }
             
        partial void InitializePartial();
    }
}
