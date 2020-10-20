
namespace MappingSPO.Project.DL.Entities
{
    public partial class WPrijsVraagExplorerDxEntity
    {
		public WPrijsVraagExplorerDxEntity()
        {
            InitializePartial();
		}

        public long PrijsAanvraagId { get; set; }
        public string CalcTypeId { get; set; }
        public string PrijsAanvraagType { get; set; }
        public int? PrijsAanvraagYear { get; set; }
        public int? Number { get; set; }
        public int? PrijsAanvraagState { get; set; }
        public string PrijsAanvraagNummer { get; set; }
        public string PrijsAanvraagVersieNummer { get; set; }
        public string PrijsAanvraagName { get; set; }
        public double? Total { get; set; }
        public double? TotalInclVat { get; set; }
        public System.DateTime? CreatedDate { get; set; }
        public System.DateTime? LastSaveData { get; set; }
        public string Creator { get; set; }
        public string LockedBy { get; set; }
        public System.DateTime? Datum1 { get; set; }
        public System.DateTime? Datum2 { get; set; }
        public System.DateTime? OfferteDatum { get; set; }
        public System.DateTime? VervalDatum { get; set; }
        public System.DateTime? IndienDatum { get; set; }
        public System.DateTime? ExtraDate1 { get; set; }
        public System.DateTime? ExtraDate2 { get; set; }
        public System.DateTime? ExtraDate3 { get; set; }
        public System.DateTime? ExtraDate4 { get; set; }
        public System.DateTime? ExtraDate5 { get; set; }
        public string Company { get; set; }
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
        public double? ExtraNum1 { get; set; }
        public double? ExtraNum2 { get; set; }
        public double? ExtraNum3 { get; set; }
        public double? ExtraNum4 { get; set; }
        public double? ExtraNum5 { get; set; }
        public double? ExtraNum6 { get; set; }
        public double? ExtraNum7 { get; set; }
        public double? ExtraNum8 { get; set; }
        public string Calculator { get; set; }
        public string CalculatorGsm { get; set; }
        public bool MarkedForDeletion { get; set; }
        public string DeletionErrorRemark { get; set; }
        public string WhoMarkedForDeletion { get; set; }
        public int CalcSoort { get; set; }
        public string PathDocsFileSystem { get; set; }
        public string BimModelName { get; set; }
        public string Domain { get; set; }
        public long? WerfId { get; set; }
        public int? WerfState { get; set; }
        public string FullWerfNumber { get; set; }
        public string WerfName { get; set; }
        public string WerfLeider { get; set; }
        public string ProjectLeider { get; set; }
        public long? CProjectId { get; set; }
        public string CProjectType { get; set; }
        public string CProjectNumber { get; set; }
        public string CProjectNaam { get; set; }
        public long? CMasterProjectId { get; set; }
        public string CMasterProjectType { get; set; }
        public string CMasterProjectNumber { get; set; }
        public string CMasterProjectName { get; set; }
        public string WerfAdresName { get; set; }
        public string WerfAdres { get; set; }
        public int UiVersion { get; set; }
        public string OfferteNummer { get; set; }
        public string OfferteNaam { get; set; }
        public string InkoopCats { get; set; }
        public string Suppliers { get; set; }
        public long? WProjectId { get; set; }
        public string WProjectType { get; set; }
        public string WProjectNumber { get; set; }
        public string WProjectNaam { get; set; }
        public long? WMasterProjectId { get; set; }
        public string WMasterProjectType { get; set; }
        public string WMasterProjectNumber { get; set; }
        public string WMasterProjectName { get; set; }
        public string Verantw1 { get; set; }
        public string Verantw2 { get; set; }
        public string Verantw3 { get; set; }
        public long CalcId { get; set; }
        public string InkoopCatGroups { get; set; }
             
        partial void InitializePartial();
    }
}
