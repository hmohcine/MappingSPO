
namespace MappingSPO.Entities
{
    public partial class WingsSettingEntity
    {
		public WingsSettingEntity()
        {
            SiteAna = 1;
            ProcessPayments = false;
            InitializePartial();
		}

        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string DossierId { get; set; }
        public string DossierRootPath { get; set; }
        public string LocationExport { get; set; }
        public string JournalSales { get; set; }
        public string JournalCreditNota { get; set; }
        public int SiteAna { get; set; }
        public bool ProcessPayments { get; set; }
        public System.DateTime ProcessPaymentsMinDate { get; set; }
        public CompanyEntity Company { get; set; }
             
        partial void InitializePartial();
    }
}
