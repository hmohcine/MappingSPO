
namespace MappingSPO.Entities
{
    public partial class ExactOnlineSettingEntity
    {
		public ExactOnlineSettingEntity()
        {
            JournalSalesCn = "700";
            AnalyticSite = 0;
            SiteFieldToExport = 0;
            SyncWerven = false;
            InitializePartial();
		}

        public int CompanyId { get; set; }
        public int AdministrationCode { get; set; }
        public long Id { get; set; }
        public string DossierName { get; set; }
        public string BookYearName { get; set; }
        public System.DateTime BookYearStartDate { get; set; }
        public System.DateTime BookYearEndDate { get; set; }
        public string JournalSales { get; set; }
        public string JournalSalesCn { get; set; }
        public int AnalyticSite { get; set; }
        public int SiteFieldToExport { get; set; }
        public bool SyncWerven { get; set; }
        public CompanyEntity Company { get; set; }
             
        partial void InitializePartial();
    }
}
