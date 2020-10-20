
namespace MappingSPO.Project.DL.Entities
{
    public partial class WCalculationExplorerDxEntity
    {
		public WCalculationExplorerDxEntity()
        {
            CalcRelations = new System.Collections.Generic.List<CalcRelationEntity>();
            InitializePartial();
		}

        public long CalcId { get; set; }
        public string CalcTypeId { get; set; }
        public string CalcMayorTypeCode { get; set; }
        public string CalcType { get; set; }
        public int? CalcYear { get; set; }
        public int? CalcNumber { get; set; }
        public int? CalcStatus { get; set; }
        public string FullCalcNumber { get; set; }
        public string VersionCalcNumber { get; set; }
        public long? VersionOriginalCalcId { get; set; }
        public string VersionOriginalCalcTypeId { get; set; }
        public int? VersionOriginalCalcYear { get; set; }
        public int? VersieNr { get; set; }
        public int? OriginalCalcNumber { get; set; }
        public string VersieOpmerking { get; set; }
        public string CalcName { get; set; }
        public double? Tkp { get; set; }
        public double? Tvp { get; set; }
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
        public string Calculator { get; set; }
        public string CalculatorGsm { get; set; }
        public string LoonEc { get; set; }
        public double? LoonAantal { get; set; }
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
        public long? ProjectId { get; set; }
        public string ProjectType { get; set; }
        public string ProjectNumber { get; set; }
        public string ProjectNaam { get; set; }
        public long? MasterProjectId { get; set; }
        public string MasterProjectType { get; set; }
        public string MasterProjectNumber { get; set; }
        public string MasterProjectName { get; set; }
        public string KlantAdresName { get; set; }
        public string KlantAdres { get; set; }
        public string WerfAdresName { get; set; }
        public string WerfAdres { get; set; }
        public int UiVersion { get; set; }
        public long? ProjectUnitId { get; set; }
        public string ProjectUnitNumber { get; set; }
        public string ProjectUnitDescription { get; set; }
        public int? ProjectUnitState { get; set; }
        public double? UpliftPct { get; set; }
        public double? MargePct { get; set; }
        public int? CompanyId { get; set; }
        public System.Collections.Generic.ICollection<CalcRelationEntity> CalcRelations { get; set; }
             
        partial void InitializePartial();
    }
}
