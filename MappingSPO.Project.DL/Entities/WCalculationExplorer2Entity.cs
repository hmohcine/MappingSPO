
namespace MappingSPO.Project.DL.Entities
{
    public partial class WCalculationExplorer2Entity
    {
		public WCalculationExplorer2Entity()
        {
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
        public System.DateTime? CreatedDate { get; set; }
        public System.DateTime? LastSaveData { get; set; }
        public int? CreatorId { get; set; }
        public string Creator { get; set; }
        public int? LockedById { get; set; }
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
        public int? CompanyId { get; set; }
        public string Company { get; set; }
        public int? Code1Id { get; set; }
        public int? Code2Id { get; set; }
        public int? Code3Id { get; set; }
        public int? Code4Id { get; set; }
        public int? Code5Id { get; set; }
        public int? Code6Id { get; set; }
        public int? Code7Id { get; set; }
        public int? Code8Id { get; set; }
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
        public int? CalculatorId { get; set; }
        public string Calculator { get; set; }
        public long? WerfId { get; set; }
        public string WerfTypeId { get; set; }
        public int? WerfYear { get; set; }
        public string WerfNr { get; set; }
        public string WerfName { get; set; }
        public long? ProjectId { get; set; }
        public string ProjectNrText { get; set; }
        public string ProjectName { get; set; }
        public string ProjectType { get; set; }
        public int? WerfNumber { get; set; }
        public int? ProjectYear { get; set; }
        public int? ProjectNumber { get; set; }
        public string LoonEc { get; set; }
        public double? LoonAantal { get; set; }
        public bool MarkedForDeletion { get; set; }
        public string DeletionErrorRemark { get; set; }
        public string WhoMarkedForDeletion { get; set; }
        public int CalcSoort { get; set; }
        public string Domain { get; set; }
        public string ProjectUnit { get; set; }
        public int? UnitState { get; set; }
        public string VolgNrYearText { get; set; }
        public string Verantwoordelijke1 { get; set; }
        public string Verantwoordelijke2 { get; set; }
        public string Verantwoordelijke3 { get; set; }
        public int? Verantwoordelijke1Id { get; set; }
        public int? Verantwoordelijke2Id { get; set; }
        public int? Verantwoordelijke3Id { get; set; }
        public double? ExtraNum1 { get; set; }
        public double? ExtraNum2 { get; set; }
        public double? ExtraNum3 { get; set; }
        public double? ExtraNum4 { get; set; }
        public double? ExtraNum5 { get; set; }
        public double? ExtraNum6 { get; set; }
        public double? ExtraNum7 { get; set; }
        public double? ExtraNum8 { get; set; }
        public long? BaseCalcId { get; set; }
        public long? OnderaannemerRelationId { get; set; }
        public string OnderaannemerName { get; set; }
        public string OnderaannemerEmail1 { get; set; }
        public string OnderaannemerPhone1 { get; set; }
        public string OnderaannemerGsm { get; set; }
        public string InkoopCategory { get; set; }
        public string InkoopCategoryGroup { get; set; }
        public int UiVersion { get; set; }
             
        partial void InitializePartial();
    }
}
