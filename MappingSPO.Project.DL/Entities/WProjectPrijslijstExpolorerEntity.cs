
namespace MappingSPO.Project.DL.Entities
{
    public partial class WProjectPrijslijstExpolorerEntity
    {
		public WProjectPrijslijstExpolorerEntity()
        {
            InitializePartial();
		}

        public long ProjectUnitId { get; set; }
        public int ProjectMasterType { get; set; }
        public long ProjectId { get; set; }
        public string ProjectType { get; set; }
        public string ProjectNrText { get; set; }
        public string ProjectName { get; set; }
        public string MasterProjectNr { get; set; }
        public string MasterProjectName { get; set; }
        public long? MasterPid { get; set; }
        public string MasterPType { get; set; }
        public int UnitState { get; set; }
        public long UnittypeId { get; set; }
        public string Unittype { get; set; }
        public string Afkorting { get; set; }
        public string NrPart1 { get; set; }
        public string NrPart2 { get; set; }
        public string NrPart3 { get; set; }
        public int? Nummer { get; set; }
        public string NrFormat { get; set; }
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
        public string DefaultFormat { get; set; }
        public long? CodeId1 { get; set; }
        public long? CodeId2 { get; set; }
        public long? CodeId3 { get; set; }
        public long? CodeId4 { get; set; }
        public long? CodeId5 { get; set; }
        public long? CodeId6 { get; set; }
        public long? CodeId7 { get; set; }
        public long? CodeId8 { get; set; }
        public long? OfferId { get; set; }
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
        public decimal? VerkoopOtherVPexcl { get; set; }
        public decimal? VerkoopOtherBtw { get; set; }
        public decimal? VerkoopTotalExcl { get; set; }
        public decimal? VerkoopTotalBtw { get; set; }
        public decimal? G17 { get; set; }
        public decimal? G18 { get; set; }
        public decimal? G19 { get; set; }
        public decimal? G20 { get; set; }
        public decimal? G21 { get; set; }
        public decimal? G22 { get; set; }
        public decimal? G23 { get; set; }
        public decimal? G24 { get; set; }
        public decimal? G25 { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime ChangedDate { get; set; }
        public int CreatedById { get; set; }
        public int ChangedById { get; set; }
        public string CreatedBy { get; set; }
        public string ChangedBy { get; set; }
        public string FullCalcNumber { get; set; }
        public string VersionCalcNumber { get; set; }
        public int? CalcStatus { get; set; }
        public string VersieOpmerking { get; set; }
        public string CalcName { get; set; }
        public double? Tkp { get; set; }
        public double? Tvp { get; set; }
        public System.DateTime? OfferteDatum { get; set; }
        public System.DateTime? VervalDatum { get; set; }
        public System.DateTime? IndienDatum { get; set; }
        public string Company { get; set; }
        public int? CalcSoort { get; set; }
        public string FullWerfNumber { get; set; }
        public string WerfName { get; set; }
        public System.DateTime? StartDate { get; set; }
        public System.DateTime? EndDate { get; set; }
        public string WerfLeider { get; set; }
        public string ProjectLeider { get; set; }
        public int? WerfState { get; set; }
        public bool IntegrationYn { get; set; }
        public int ProjectYear { get; set; }
        public int ProjectNumber { get; set; }
        public string WerfTypeId { get; set; }
        public int? WerfYear { get; set; }
        public int? WerfNumber { get; set; }
        public string Clients { get; set; }
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
        public long? RegioId { get; set; }
        public string Regio { get; set; }
        public long? MasterProjectRegioId { get; set; }
        public string MasterProjectRegio { get; set; }
        public System.DateTime? VoorlopigeOpleveringsdatum { get; set; }
        public System.DateTime? DefinitieveOpleveringsdatum { get; set; }
        public string SubCategory { get; set; }
        public int? SubCategoryId { get; set; }
        public string VolgNrYearText { get; set; }
        public decimal? PerceelOpp { get; set; }
             
        partial void InitializePartial();
    }
}
