
namespace MappingSPO.Project.DL.Entities
{
    public partial class WContractExplorerEntity
    {
		public WContractExplorerEntity()
        {
            InitializePartial();
		}

        public long ContractId { get; set; }
        public string ContractTypeId { get; set; }
        public int Contractjaar { get; set; }
        public int Contractnummer { get; set; }
        public int ContractStatus { get; set; }
        public string FullContractNummer { get; set; }
        public string ContractNaam { get; set; }
        public double? Tkp { get; set; }
        public double? Tvp { get; set; }
        public System.DateTime? CreatedDate { get; set; }
        public int? CreatorId { get; set; }
        public string Creator { get; set; }
        public System.DateTime? StartDate { get; set; }
        public System.DateTime? EndDate { get; set; }
        public System.DateTime? KalenderStartDatum { get; set; }
        public System.DateTime? KalenderEinddatum { get; set; }
        public System.DateTime? KalenderContractDatum { get; set; }
        public System.DateTime? KalenderGoedkeurdatum { get; set; }
        public System.DateTime? KalenderUitvoeringsdatum { get; set; }
        public System.DateTime? FirstAprovedVorderingDate { get; set; }
        public System.DateTime? LastAprovedVorderingDate { get; set; }
        public System.DateTime? FirstVorderingDate { get; set; }
        public System.DateTime? LastVorderingDate { get; set; }
        public int? DefailtCompanyId { get; set; }
        public string DefaultCompany { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public int? WerfLeiderId { get; set; }
        public string WerfLeider { get; set; }
        public int? ProjectLeiderId { get; set; }
        public string ProjectLeider { get; set; }
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
        public System.DateTime? VoorlopigeOpleveringsdatum { get; set; }
        public System.DateTime? DefinitieveOpleveringsdatum { get; set; }
        public string Domain { get; set; }
        public int? ParentWerfOpvolgingsnummer { get; set; }
        public string ParentWerfName { get; set; }
        public string ParentProjectNummer { get; set; }
        public string ParentProjectName { get; set; }
        public int? ParentWerfYear { get; set; }
        public string ParentWerfTypeOmschrijving { get; set; }
        public string ParentWerfType { get; set; }
        public string Code1Contract { get; set; }
        public string Code2Contract { get; set; }
        public string Code3Contract { get; set; }
        public string Code4Contract { get; set; }
        public string Code5Contract { get; set; }
        public string Code6Contract { get; set; }
        public string Code8Contract { get; set; }
        public string Code7Contract { get; set; }
        public string ParentWerfTypeId { get; set; }
        public int? ProjectYear { get; set; }
        public string ProjectWerfNotes { get; set; }
        public bool? ProjectDone { get; set; }
        public int? ProjectState { get; set; }
        public int? ProjectResultReason { get; set; }
        public int? ProjectNumber { get; set; }
        public string OaNaam { get; set; }
        public string OaPhone { get; set; }
        public string OaEmail { get; set; }
        public string OaGsm { get; set; }
        public long? OaRelationId { get; set; }
             
        partial void InitializePartial();
    }
}
