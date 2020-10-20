
namespace MappingSPO.Project.DL.Entities
{
    public partial class WWerfExplorerDxEntity
    {
		public WWerfExplorerDxEntity()
        {
            WerfRelations = new System.Collections.Generic.List<WerfRelationEntity>();
            InitializePartial();
		}

        public long WerfId { get; set; }
        public int WerfState { get; set; }
        public string FullWerfNumber { get; set; }
        public string WerfName { get; set; }
        public System.DateTime? CreatedDate { get; set; }
        public string Creator { get; set; }
        public System.DateTime? StartDate { get; set; }
        public System.DateTime? EndDate { get; set; }
        public string WerfTypeId { get; set; }
        public int WerfYear { get; set; }
        public int WerfNumber { get; set; }
        public int? CreatorId { get; set; }
        public int? DefailtCompanyId { get; set; }
        public string DefaultCompany { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public string Code3 { get; set; }
        public string Code4 { get; set; }
        public string Code5 { get; set; }
        public string Code6 { get; set; }
        public string Code7 { get; set; }
        public string Code8 { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public string WerfLeider { get; set; }
        public string WerfLeiderGsm { get; set; }
        public string ProjectLeider { get; set; }
        public string ProjectLeiderGsm { get; set; }
        public string ExtNumber { get; set; }
        public bool? CheckInAtWorkYn { get; set; }
        public string PathDocsFileSystem { get; set; }
        public double? ExtraNum1 { get; set; }
        public double? ExtraNum2 { get; set; }
        public double? ExtraNum3 { get; set; }
        public double? ExtraNum4 { get; set; }
        public double? ExtraNum5 { get; set; }
        public double? ExtraNum6 { get; set; }
        public double? ExtraNum7 { get; set; }
        public double? ExtraNum8 { get; set; }
        public System.DateTime? VoorlopigeOpleveringsdatum { get; set; }
        public System.DateTime? DefinitieveOpleveringsdatum { get; set; }
        public System.DateTime? ExtraDate1 { get; set; }
        public System.DateTime? ExtraDate2 { get; set; }
        public System.DateTime? ExtraDate3 { get; set; }
        public System.DateTime? ExtraDate4 { get; set; }
        public System.DateTime? ExtraDate5 { get; set; }
        public System.DateTime? ExtraDate6 { get; set; }
        public System.DateTime? ExtraDate7 { get; set; }
        public System.DateTime? ExtraDate8 { get; set; }
        public string Domain { get; set; }
        public double? BudgetTkp { get; set; }
        public double? BudgetTvp { get; set; }
        public string AnaCode1 { get; set; }
        public string AnaCode2 { get; set; }
        public string AnaCode3 { get; set; }
        public string AnaCode4 { get; set; }
        public string AnaCode5 { get; set; }
        public string AnaCode6 { get; set; }
        public string AnaCode7 { get; set; }
        public string AnaCode8 { get; set; }
        public string KlantAdresName { get; set; }
        public string KlantAdres { get; set; }
        public string WerfAdresName { get; set; }
        public string WerfAdres { get; set; }
        public string FactuurAdresName { get; set; }
        public string FactuurAdres { get; set; }
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
        public decimal? TvpExcl { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? TvpIncl { get; set; }
        public double? SalesInvoiceBetaald { get; set; }
        public double? SalesInvoiceTeBetalen { get; set; }
        public double? TotBasteldBb { get; set; }
        public double? TotBesteldOa { get; set; }
        public double TotBesteld { get; set; }
        public double? TotalCostCost { get; set; }
        public double? TotalCostContract { get; set; }
        public double TotalCost { get; set; }
        public decimal? PurchaseInvoiceTotal { get; set; }
        public long? ProjectId { get; set; }
        public string ProjectType { get; set; }
        public string ProjectNumber { get; set; }
        public string ProjectNaam { get; set; }
        public long? MasterProjectId { get; set; }
        public string MasterProjectType { get; set; }
        public string MasterProjectNumber { get; set; }
        public string MasterProjectName { get; set; }
        public System.DateTime? CalStartDate { get; set; }
        public System.DateTime? CalEndDate { get; set; }
        public System.DateTime? CalContractDate { get; set; }
        public System.DateTime? CalApprovedDate { get; set; }
        public System.DateTime? CalStartCommandDate { get; set; }
        public string LanguageCode { get; set; }
        public System.Collections.Generic.ICollection<WerfRelationEntity> WerfRelations { get; set; }
             
        partial void InitializePartial();
    }
}
