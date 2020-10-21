
namespace MappingSPO.Project.DL.Entities
{
    public partial class WMasterProjectExplorerDxEntity
    {
		public WMasterProjectExplorerDxEntity()
        {
            WProjectRelationsDxes = new System.Collections.Generic.List<WProjectRelationsDxEntity>();
            InitializePartial();
		}

        public long ProjectId { get; set; }
        public string ProjectType { get; set; }
        public long GlobalId { get; set; }
        public int ProjectYear { get; set; }
        public int ProjectNumber { get; set; }
        public string ProjectNrText { get; set; }
        public string ProjectName { get; set; }
        public System.DateTime ProjectDate { get; set; }
        public System.DateTime? StartDate { get; set; }
        public System.DateTime? DueDate { get; set; }
        public System.DateTime? DoneDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Owner { get; set; }
        public string Company { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public int ProjectResult { get; set; }
        public bool HasExtendedSecurity { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public string Code3 { get; set; }
        public string Code4 { get; set; }
        public string Code5 { get; set; }
        public string Code6 { get; set; }
        public string Code7 { get; set; }
        public string Code8 { get; set; }
        public string ProjectVerantWoordelijke1 { get; set; }
        public string ProjectVerantWoordelijke2 { get; set; }
        public string ProjectVerantWoordelijke3 { get; set; }
        public long? RelationId { get; set; }
        public string MainRelationType { get; set; }
        public string MainRelationName { get; set; }
        public string AdressLine1 { get; set; }
        public string AdressLine2 { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string CurrentState { get; set; }
        public byte[] CurrentStateIcon { get; set; }
        public string CurrentStateWorkflow { get; set; }
        public bool ProjectDone { get; set; }
        public System.DateTime? ExtraDate1 { get; set; }
        public System.DateTime? ExtraDate2 { get; set; }
        public System.DateTime? ExtraDate3 { get; set; }
        public System.DateTime? ExtraDate4 { get; set; }
        public System.DateTime? ExtraDate5 { get; set; }
        public System.DateTime? ExtraDate6 { get; set; }
        public System.DateTime? ExtraDate7 { get; set; }
        public int? ContactId { get; set; }
        public int? ProjectResultReason { get; set; }
        public string ProjectResultReasonText { get; set; }
        public System.DateTime? ForeCastDate { get; set; }
        public long? OppertunityValue { get; set; }
        public double? OpportunityPct { get; set; }
        public decimal? ExtraNum1 { get; set; }
        public decimal? ExtraNum2 { get; set; }
        public decimal? ExtraNum3 { get; set; }
        public decimal? ExtraNum4 { get; set; }
        public decimal? ExtraNum5 { get; set; }
        public decimal? ExtraNum6 { get; set; }
        public decimal? ExtraNum7 { get; set; }
        public decimal? ExtraNum8 { get; set; }
        public string MainContact { get; set; }
        public int? ProjectMasterType { get; set; }
        public string ExtNumber { get; set; }
        public string CountryCode { get; set; }
        public string TeamsUrl { get; set; }
        public bool? CheckInAtWorkYn { get; set; }
        public string CExtNumber { get; set; }
        public string SubCategory { get; set; }
        public int ProjectState { get; set; }
        public double? BudgetTkp { get; set; }
        public double? BudgetTvp { get; set; }
        public double? VorderingVpState0 { get; set; }
        public double? VorderingVpState1 { get; set; }
        public double? VorderingVpState2 { get; set; }
        public double? VorderingVpState3 { get; set; }
        public double? VorderingVpState45 { get; set; }
        public double? VorderingVpStateH1 { get; set; }
        public double? VorderingVpStateL2 { get; set; }
        public System.DateTime? FirstVordDate { get; set; }
        public System.DateTime? LastVordDate { get; set; }
        public decimal? SalesInvoiceState0 { get; set; }
        public decimal? SalesInvoiceState1 { get; set; }
        public decimal? SalesInvoiceState2 { get; set; }
        public decimal? SalesInvoiceState3 { get; set; }
        public decimal? SalesInvoiceStateAf { get; set; }
        public decimal? SalesInvoiceTvpExcl { get; set; }
        public decimal? SalesInvoiceVatAmount { get; set; }
        public decimal? SalesInvoiceTvpIncl { get; set; }
        public double? SalesInvoiceBetaald { get; set; }
        public double? SalesInvoiceTeBetalen { get; set; }
        public double? TotBesteldBb { get; set; }
        public double? TotBesteldOa { get; set; }
        public double? TotBesteld { get; set; }
        public double? TotalCostCost { get; set; }
        public double? TotalCostContract { get; set; }
        public double? TotalCost { get; set; }
        public decimal? PurchaseInvoiceTotal { get; set; }
        public string LanguageCode { get; set; }
        public System.Collections.Generic.ICollection<WProjectRelationsDxEntity> WProjectRelationsDxes { get; set; }
             
        partial void InitializePartial();
    }
}
