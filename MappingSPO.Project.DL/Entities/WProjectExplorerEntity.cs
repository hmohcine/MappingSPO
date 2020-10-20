
namespace MappingSPO.Project.DL.Entities
{
    public partial class WProjectExplorerEntity
    {
		public WProjectExplorerEntity()
        {
            InitializePartial();
		}

        public long ProjectId { get; set; }
        public string ProjectType { get; set; }
        public int ProjectYear { get; set; }
        public int ProjectNumber { get; set; }
        public string ProjectNrText { get; set; }
        public string ProjectName { get; set; }
        public System.DateTime ProjectDate { get; set; }
        public System.DateTime? StartDate { get; set; }
        public System.DateTime? DueDate { get; set; }
        public System.DateTime? DoneDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public int CreatedBy { get; set; }
        public string Creator { get; set; }
        public int UpdatedBy { get; set; }
        public string LastChangedBy { get; set; }
        public int OwnerId { get; set; }
        public string Owner { get; set; }
        public int? DefaultCompanyId { get; set; }
        public string Company { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public int? IdProjectVerantWoordelijke1 { get; set; }
        public int? IdProjectVerantWoordelijke2 { get; set; }
        public int? IdProjectVerantWoordelijke3 { get; set; }
        public int ProjectResult { get; set; }
        public string ProjectResultText { get; set; }
        public bool HasExtendedSecurity { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public string Code3 { get; set; }
        public string Code4 { get; set; }
        public string Code5 { get; set; }
        public string Code6 { get; set; }
        public string Code7 { get; set; }
        public string Code8 { get; set; }
        public int? IdCode1 { get; set; }
        public int? IdCode2 { get; set; }
        public int? IdCode3 { get; set; }
        public int? IdCode4 { get; set; }
        public int? IdCode5 { get; set; }
        public int? IdCode6 { get; set; }
        public int? IdCode7 { get; set; }
        public int? IdCode8 { get; set; }
        public string ProjectVerantWoordelijke1 { get; set; }
        public string ProjectVerantWoordelijke2 { get; set; }
        public string ProjectVerantWoordelijke3 { get; set; }
        public int? RelationTypeId { get; set; }
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
        public long? CurrentStateId { get; set; }
        public bool ProjectDone { get; set; }
        public string ProjectDoneText { get; set; }
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
        public long? OriginalWorkFlowId { get; set; }
        public double? OpportunityPct { get; set; }
        public string OpportunityPctInText { get; set; }
        public string ForeCastOwner { get; set; }
        public double? TvpWerf { get; set; }
        public double? TvpCalc { get; set; }
        public decimal? ExtraNum1 { get; set; }
        public decimal? ExtraNum2 { get; set; }
        public decimal? ExtraNum3 { get; set; }
        public decimal? ExtraNum4 { get; set; }
        public decimal? ExtraNum5 { get; set; }
        public decimal? ExtraNum6 { get; set; }
        public decimal? ExtraNum7 { get; set; }
        public decimal? ExtraNum8 { get; set; }
        public string MainRelationPhone1 { get; set; }
        public string MainRelationPhone2 { get; set; }
        public string MainRelationEmail1 { get; set; }
        public string MainRelationEmail2 { get; set; }
        public string MainRelationGsm { get; set; }
        public string MainContact { get; set; }
        public string MainContactPhone { get; set; }
        public string MainContactEmail { get; set; }
        public string MainContactGsm { get; set; }
        public int CountOfExtInvoiceTodo { get; set; }
        public long? MasterPid { get; set; }
        public string MasterPType { get; set; }
        public string MasterProjectNr { get; set; }
        public string MasterProjectName { get; set; }
        public long? RegioId { get; set; }
        public string Regio { get; set; }
        public int? MasterProjectRelationTypeId { get; set; }
        public long? MasterProjectRelationId { get; set; }
        public long? MasterProjectRegioId { get; set; }
        public string MasterProjectRegio { get; set; }
        public int? ProjectMasterType { get; set; }
        public bool? CheckInAtWorkYn { get; set; }
        public string ExtNumber { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string TeamsUrl { get; set; }
             
        partial void InitializePartial();
    }
}
