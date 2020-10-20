
namespace MappingSPO.Project.DL.Entities
{
    public partial class WPrijsAntwoordExplorerDxEntity
    {
		public WPrijsAntwoordExplorerDxEntity()
        {
            InitializePartial();
		}

        public long AntwoordId { get; set; }
        public int AntwoordType { get; set; }
        public int HasPrijsVraag { get; set; }
        public string CalcTypeId { get; set; }
        public string CalcType { get; set; }
        public int? CalcYear { get; set; }
        public int? CalcNumber { get; set; }
        public int? CalcStatus { get; set; }
        public string FullCalcNumber { get; set; }
        public string VersionCalcNumber { get; set; }
        public string CalcName { get; set; }
        public double? Tkp { get; set; }
        public double? TvpIncl { get; set; }
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
        public bool MarkedForDeletion { get; set; }
        public string DeletionErrorRemark { get; set; }
        public string WhoMarkedForDeletion { get; set; }
        public int CalcSoort { get; set; }
        public string PathDocsFileSystem { get; set; }
        public string BimModelName { get; set; }
        public int UiVersion { get; set; }
        public long? SupplierRelationId { get; set; }
        public string Supplier { get; set; }
        public string SupplierAdres1 { get; set; }
        public string SupplierAdres2 { get; set; }
        public string SupplierZip { get; set; }
        public string SupplierCity { get; set; }
        public string SupplierCountryCode { get; set; }
        public string OpmerkingPrijsvraagSupplier { get; set; }
        public string Verantw1 { get; set; }
        public string Verantw2 { get; set; }
        public string Verantw3 { get; set; }
        public string InkoopCats { get; set; }
        public string PrijsvraagNr { get; set; }
        public string PrijsVraagName { get; set; }
        public long? BaseCalcId { get; set; }
        public string BaseCalcNumber { get; set; }
        public string BaseCalcName { get; set; }
        public long? CProjectId { get; set; }
        public string CProjectType { get; set; }
        public string CProjectNumber { get; set; }
        public string CProjectNaam { get; set; }
        public long? CMasterProjectId { get; set; }
        public string CMasterProjectType { get; set; }
        public string CMasterProjectNumber { get; set; }
        public string CMasterProjectName { get; set; }
        public long? CWerfId { get; set; }
        public string CFullWerfNumber { get; set; }
        public string CWerfName { get; set; }
        public string CWerfLeider { get; set; }
        public string CProjectLeider { get; set; }
        public string CWerfAdresName { get; set; }
        public string CWerfAdres { get; set; }
        public long? ContractId { get; set; }
        public string ContractNr { get; set; }
        public string ContractName { get; set; }
        public long? WerfId { get; set; }
        public long? WWerfId { get; set; }
        public string WFullWerfNumber { get; set; }
        public string WWerfName { get; set; }
        public string WWerfLeider { get; set; }
        public string WProjectLeider { get; set; }
        public string WWerfAdresName { get; set; }
        public string WWerfAdres { get; set; }
        public long? WProjectId { get; set; }
        public string WProjectType { get; set; }
        public string WProjectNumber { get; set; }
        public string WProjectNaam { get; set; }
        public long? WMasterProjectId { get; set; }
        public string WMasterProjectType { get; set; }
        public string WMasterProjectNumber { get; set; }
        public string WMasterProjectName { get; set; }
        public string InkoopCatGroups { get; set; }
        public int? ContractState { get; set; }
        public int? RelationTypeId { get; set; }
        public long? PrijsVraagId { get; set; }
        public string LanguageCode { get; set; }
             
        partial void InitializePartial();
    }
}
