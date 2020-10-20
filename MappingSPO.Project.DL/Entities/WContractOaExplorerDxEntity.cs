
namespace MappingSPO.Project.DL.Entities
{
    public partial class WContractOaExplorerDxEntity
    {
		public WContractOaExplorerDxEntity()
        {
            InitializePartial();
		}

        public long ContractId { get; set; }
        public int ContractState { get; set; }
        public string ContractNr { get; set; }
        public string ContractName { get; set; }
        public System.DateTime? CreatedDate { get; set; }
        public string Creator { get; set; }
        public System.DateTime? StartDate { get; set; }
        public System.DateTime? EndDate { get; set; }
        public string ContractTypeId { get; set; }
        public int ContractYear { get; set; }
        public int ContractNumber { get; set; }
        public int? CreatorId { get; set; }
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
        public string VerantWoordelijke1 { get; set; }
        public string VerantWoordelijke1Gsm { get; set; }
        public string VerantWoordelijke2 { get; set; }
        public string VerantWoordelijke2Gsm { get; set; }
        public string ExtNumberWerf { get; set; }
        public bool? CheckInAtWorkYnWerf { get; set; }
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
        public string WerfAdresName { get; set; }
        public string WerfAdres { get; set; }
        public string WerfFactuurAdresName { get; set; }
        public string WerfFactuurAdres { get; set; }
        public double? CreditVorderingVpState0 { get; set; }
        public double? CreditVorderingVpState1 { get; set; }
        public double? CreditVorderingVpState2 { get; set; }
        public double? CreditVorderingVpState3 { get; set; }
        public double? CreditVorderingVpState45 { get; set; }
        public double? CreditVorderingVpStateH1 { get; set; }
        public double? CreditVorderingVpStateL2 { get; set; }
        public System.DateTime? FirstCreditVordDate { get; set; }
        public System.DateTime? LastCreditVordDate { get; set; }
        public double? TotalCostContract { get; set; }
        public decimal? PurchaseInvoiceTotal { get; set; }
        public long? ProjectId { get; set; }
        public string ProjectType { get; set; }
        public string ProjectNumber { get; set; }
        public string ProjectNaam { get; set; }
        public long? MasterProjectId { get; set; }
        public string MasterProjectType { get; set; }
        public string MasterProjectNumber { get; set; }
        public string MasterProjectName { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public long? SupplierRelationId { get; set; }
        public string Supplier { get; set; }
        public string SupplierAdres1 { get; set; }
        public string SupplierAdres2 { get; set; }
        public string SupplierCity { get; set; }
        public string SupplierZip { get; set; }
        public string SupplierCountryCode { get; set; }
        public string ContactName { get; set; }
        public string InkoopCats { get; set; }
        public long WerfId { get; set; }
        public string InkoopCatGroups { get; set; }
        public int? RelationTypeId { get; set; }
        public int WerfState { get; set; }
        public string WerfName { get; set; }
        public string FullWerfNumber { get; set; }
        public string LanguageCode { get; set; }
             
        partial void InitializePartial();
    }
}
