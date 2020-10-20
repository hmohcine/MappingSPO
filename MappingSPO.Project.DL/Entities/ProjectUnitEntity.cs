
namespace MappingSPO.Project.DL.Entities
{
    public partial class ProjectUnitEntity
    {
		public ProjectUnitEntity()
        {
            IntegrationYn = false;
            VerdeelMode = 0;
            Year = 0;
            VolgNrYear = 0;
            VolgNrYearText = "";
            InitializePartial();
		}

        public long ProjectUnitId { get; set; }
        public long ProjectId { get; set; }
        public string ProjectType { get; set; }
        public int UnitState { get; set; }
        public long UnittypeId { get; set; }
        public string NrPart1 { get; set; }
        public string NrPart2 { get; set; }
        public string NrPart3 { get; set; }
        public int? Nummer { get; set; }
        public string NrFormat { get; set; }
        public string VolgNummer { get; set; }
        public string Description { get; set; }
        public long? CodeId1 { get; set; }
        public long? CodeId2 { get; set; }
        public long? CodeId3 { get; set; }
        public long? CodeId4 { get; set; }
        public long? CodeId5 { get; set; }
        public long? CodeId6 { get; set; }
        public long? CodeId7 { get; set; }
        public long? CodeId8 { get; set; }
        public decimal? BrutoVloerOpp { get; set; }
        public decimal? NettoVloerOpp { get; set; }
        public decimal? Quotiteit { get; set; }
        public decimal? VerkoopField1 { get; set; }
        public decimal? VerkoopField2 { get; set; }
        public decimal? VerkoopField3 { get; set; }
        public decimal? VerkoopField4 { get; set; }
        public decimal? VerkoopField5 { get; set; }
        public decimal? VerkoopField6 { get; set; }
        public decimal? VerkoopField7 { get; set; }
        public decimal? VerkoopField8 { get; set; }
        public decimal? VerkoopField9 { get; set; }
        public decimal? VerkoopField10 { get; set; }
        public decimal? VerkoopField11 { get; set; }
        public decimal? VerkoopField12 { get; set; }
        public decimal? VerkoopField13 { get; set; }
        public decimal? VerkoopField14 { get; set; }
        public decimal? VerkoopField15 { get; set; }
        public decimal? VerkoopField16 { get; set; }
        public decimal? VerkoopField17 { get; set; }
        public decimal? VerkoopField18 { get; set; }
        public decimal? VerkoopField19 { get; set; }
        public decimal? VerkoopField20 { get; set; }
        public decimal? VerkoopField21 { get; set; }
        public decimal? VerkoopField22 { get; set; }
        public decimal? VerkoopField23 { get; set; }
        public decimal? VerkoopField24 { get; set; }
        public decimal? VerkoopField25 { get; set; }
        public decimal? VerkoopOtherVPexcl { get; set; }
        public decimal? VerkoopOtherBtw { get; set; }
        public decimal? VerkoopTotalExcl { get; set; }
        public decimal? VerkoopTotalBtw { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime ChangedDate { get; set; }
        public int CreatedBy { get; set; }
        public int ChangedBy { get; set; }
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
        public int? SubCategoryId { get; set; }
        public int Year { get; set; }
        public int VolgNrYear { get; set; }
        public string VolgNrYearText { get; set; }
        public decimal? PerceelOpp { get; set; }
        public decimal? VerdeelWaarde { get; private set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public bool? ExtraBoolean1 { get; set; }
        public bool? ExtraBoolean2 { get; set; }
        public bool? ExtraBoolean3 { get; set; }
        public bool? ExtraBoolean4 { get; set; }
        public double? ExtraNum1 { get; set; }
        public double? ExtraNum2 { get; set; }
        public double? ExtraNum3 { get; set; }
        public double? ExtraNum4 { get; set; }
        public double? ExtraNum5 { get; set; }
        public double? ExtraNum6 { get; set; }
        public double? ExtraNum7 { get; set; }
        public double? ExtraNum8 { get; set; }
             
        partial void InitializePartial();
    }
}
