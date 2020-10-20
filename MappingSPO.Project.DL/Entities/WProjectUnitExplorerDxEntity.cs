
namespace MappingSPO.Project.DL.Entities
{
    public partial class WProjectUnitExplorerDxEntity
    {
		public WProjectUnitExplorerDxEntity()
        {
            InitializePartial();
		}

        public long ProjectUnitId { get; set; }
        public long? ProjectId { get; set; }
        public string ProjectType { get; set; }
        public string ProjectNrText { get; set; }
        public string ProjectName { get; set; }
        public string ProjectRegio { get; set; }
        public long? MasterProjectId { get; set; }
        public string MasterProjectType { get; set; }
        public string MasterProjectNrText { get; set; }
        public string MasterProjectName { get; set; }
        public string MasterProjectRegion { get; set; }
        public int UnitState { get; set; }
        public string Unittype { get; set; }
        public string Afkorting { get; set; }
        public string VolgNummer { get; set; }
        public string Description { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public string Code3 { get; set; }
        public string Code4 { get; set; }
        public string Code5 { get; set; }
        public string Code6 { get; set; }
        public string Code7 { get; set; }
        public string Code8 { get; set; }
        public decimal? BrutoVloerOpp { get; set; }
        public decimal? NettoVloerOpp { get; set; }
        public decimal? Quotiteit { get; set; }
        public long? CalcId { get; set; }
        public decimal? G1 { get; set; }
        public decimal? G2 { get; set; }
        public decimal? G3 { get; set; }
        public decimal? G4 { get; set; }
        public decimal? G5 { get; set; }
        public decimal? G6 { get; set; }
        public decimal? G7 { get; set; }
        public decimal? G8 { get; set; }
        public decimal? G9 { get; set; }
        public decimal? G10 { get; set; }
        public decimal? G11 { get; set; }
        public decimal? G12 { get; set; }
        public decimal? G13 { get; set; }
        public decimal? G14 { get; set; }
        public decimal? G15 { get; set; }
        public decimal? G16 { get; set; }
        public decimal? G17 { get; set; }
        public decimal? G18 { get; set; }
        public decimal? G19 { get; set; }
        public decimal? G20 { get; set; }
        public decimal? G21 { get; set; }
        public decimal? G22 { get; set; }
        public decimal? G23 { get; set; }
        public decimal? G24 { get; set; }
        public decimal? G25 { get; set; }
        public decimal? VerkoopOtherVPexcl { get; set; }
        public decimal? VerkoopOtherBtw { get; set; }
        public decimal? VerkoopTotalExcl { get; set; }
        public decimal? VerkoopTotalBtw { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime ChangedDate { get; set; }
        public string ChangedBy { get; set; }
        public bool IntegrationYn { get; set; }
        public System.DateTime? OptieDatum { get; set; }
        public System.DateTime? OptieVervalDatum { get; set; }
        public System.DateTime? UDatum1 { get; set; }
        public System.DateTime? UDatum2 { get; set; }
        public System.DateTime? UDatum3 { get; set; }
        public System.DateTime? UDatum4 { get; set; }
        public System.DateTime? UDatum5 { get; set; }
        public System.DateTime? UDatum6 { get; set; }
        public System.DateTime? UDatum7 { get; set; }
        public System.DateTime? UDatum8 { get; set; }
        public int VerdeelMode { get; set; }
        public decimal? VerdeelWaarde { get; set; }
        public string VolgNrYearText { get; set; }
        public int Year { get; set; }
        public int VolgNrYear { get; set; }
        public string SubCategory { get; set; }
        public string Category { get; set; }
        public string FullCalcNumber { get; set; }
        public string VersionCalcNumber { get; set; }
        public int? CalcStatus { get; set; }
        public string VersieOpmerking { get; set; }
        public string CalcName { get; set; }
        public double? Tkp { get; set; }
        public double? Tvp { get; set; }
        public double? TvpIncl { get; set; }
        public System.DateTime? OfferteDatum { get; set; }
        public System.DateTime? VervalDatum { get; set; }
        public System.DateTime? IndienDatum { get; set; }
        public string Company { get; set; }
        public int? CalcSoort { get; set; }
        public string FullWerfNumber { get; set; }
        public string WerfName { get; set; }
        public string WerfLeider { get; set; }
        public string ProjectLeider { get; set; }
        public int? WerfState { get; set; }
        public System.DateTime? WerfStartDate { get; set; }
        public System.DateTime? WerfEndDate { get; set; }
        public System.DateTime? VoorlopigeOpleveringsdatum { get; set; }
        public System.DateTime? DefinitieveOpleveringsdatum { get; set; }
        public long? WerfId { get; set; }
        public decimal? PerceelOpp { get; set; }
        public string KlantAdresNaamWerf { get; set; }
        public string KlantAdresWerf { get; set; }
        public string KlantAdresNaamCalc { get; set; }
        public string KlantAdresCalc { get; set; }
        public bool? ExtraBoolean1 { get; set; }
        public bool? ExtraBoolean2 { get; set; }
        public bool? ExtraBoolean3 { get; set; }
        public bool? ExtraBoolean4 { get; set; }
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
        public string MultiSelect1 { get; set; }
        public string MultiSelect2 { get; set; }
        public string MultiSelect3 { get; set; }
        public string MultiSelect4 { get; set; }
        public string MultiSelect5 { get; set; }
        public string MultiSelect6 { get; set; }
        public string MultiSelect7 { get; set; }
        public string MultiSelect8 { get; set; }
             
        partial void InitializePartial();
    }
}
