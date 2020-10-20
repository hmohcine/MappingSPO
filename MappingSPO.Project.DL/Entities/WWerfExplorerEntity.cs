
namespace MappingSPO.Project.DL.Entities
{
    public partial class WWerfExplorerEntity
    {
		public WWerfExplorerEntity()
        {
            InitializePartial();
		}

        public long WerfId { get; set; }
        public string WerfTypeId { get; set; }
        public string WerfMayorTypeCode { get; set; }
        public string WerfType { get; set; }
        public int WerfYear { get; set; }
        public int WerfNumber { get; set; }
        public int WerfState { get; set; }
        public string FullWerfNumber { get; set; }
        public string WerfName { get; set; }
        public double? Tkp { get; set; }
        public double? Tvp { get; set; }
        public System.DateTime? CreatedDate { get; set; }
        public int? CreatorId { get; set; }
        public string Creator { get; set; }
        public System.DateTime? StartDate { get; set; }
        public System.DateTime? EndDate { get; set; }
        public System.DateTime? CalStartDate { get; set; }
        public System.DateTime? CalEndDate { get; set; }
        public System.DateTime? CalContractDate { get; set; }
        public System.DateTime? CalApprovedDate { get; set; }
        public System.DateTime? CalStartCommandDate { get; set; }
        public System.DateTime? FirstAprovedVorderingDate { get; set; }
        public System.DateTime? LastAprovedVorderingDate { get; set; }
        public System.DateTime? FirstVorderingDate { get; set; }
        public System.DateTime? LastVorderingDate { get; set; }
        public decimal? InvoiceState0Amount { get; set; }
        public decimal? InvoiceState1Amount { get; set; }
        public decimal? InvoiceState2Amount { get; set; }
        public decimal? InvoiceState3Amount { get; set; }
        public decimal? InvoiceStateAfAmount { get; set; }
        public int? DefailtCompanyId { get; set; }
        public string DefaultCompany { get; set; }
        public int? Code1Id { get; set; }
        public string Code1 { get; set; }
        public int? Code2Id { get; set; }
        public string Code2 { get; set; }
        public int? Code3Id { get; set; }
        public string Code3 { get; set; }
        public int? Code4Id { get; set; }
        public string Code4 { get; set; }
        public int? Code5Id { get; set; }
        public string Code5 { get; set; }
        public int? Code6Id { get; set; }
        public string Code6 { get; set; }
        public int? Code7Id { get; set; }
        public string Code7 { get; set; }
        public int? Code8Id { get; set; }
        public string Code8 { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public int? WerfLeiderId { get; set; }
        public string WerfLeider { get; set; }
        public int? ProjectLeiderId { get; set; }
        public string ProjectLeider { get; set; }
        public long? ProjectId { get; set; }
        public string ProjectType { get; set; }
        public int? ProjectYear { get; set; }
        public int? ProjectNumber { get; set; }
        public string ProjectNrText { get; set; }
        public string ProjectName { get; set; }
        public string ProjectState { get; set; }
        public byte[] ProjectStateIcon { get; set; }
        public bool? ProjectDone { get; set; }
        public int? ProjectResultReason { get; set; }
        public string ProjectWerfNotes { get; set; }
        public string ExtNumber { get; set; }
        public bool? CheckInAtWorkYn { get; set; }
        public double? ExtraNum1 { get; set; }
        public double? ExtraNum2 { get; set; }
        public double? ExtraNum3 { get; set; }
        public double? ExtraNum4 { get; set; }
        public double? ExtraNum5 { get; set; }
        public double? ExtraNum6 { get; set; }
        public double? ExtraNum7 { get; set; }
        public double? ExtraNum8 { get; set; }
        public System.DateTime? ExtraDate1 { get; set; }
        public System.DateTime? ExtraDate2 { get; set; }
        public System.DateTime? ExtraDate3 { get; set; }
        public System.DateTime? ExtraDate4 { get; set; }
        public System.DateTime? ExtraDate5 { get; set; }
        public System.DateTime? ExtraDate6 { get; set; }
        public System.DateTime? ExtraDate7 { get; set; }
        public System.DateTime? ExtraDate8 { get; set; }
        public int CountOfExtInvoiceTodo { get; set; }
        public System.DateTime? VoorlopigeOpleveringsdatum { get; set; }
        public System.DateTime? DefinitieveOpleveringsdatum { get; set; }
        public string Domain { get; set; }
        public long? FirstInvoiceAdressRelationId { get; set; }
        public string WerfAdresCountryCode { get; set; }
        public string WerfAdresCountry { get; set; }
             
        partial void InitializePartial();
    }
}
