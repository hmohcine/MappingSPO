
namespace MappingSPO.Entities
{
    public partial class SageBobCompanySettingEntity
    {
		public SageBobCompanySettingEntity()
        {
            InitializePartial();
		}

        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string DossierCode { get; set; }
        public string BookYearCode { get; set; }
        public System.DateTime BookYearStartDate { get; set; }
        public System.DateTime BookYearEndDate { get; set; }
        public string LocationExport { get; set; }
        public string LocationSalesInvoice { get; set; }
        public string LocationSalesCreditNota { get; set; }
        public string DagboekCodeSalesInvoice { get; set; }
        public string DagboekCodeSalesCreditnota { get; set; }
        public string BatFileSalesInvoice { get; set; }
        public string DagboekCodeLeveringen { get; set; }
        public string BatFileLeveringen { get; set; }
        public CompanyEntity Company { get; set; }
             
        partial void InitializePartial();
    }
}
