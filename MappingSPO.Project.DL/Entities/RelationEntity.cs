
namespace MappingSPO.Project.DL.Entities
{
    public partial class RelationEntity
    {
		public RelationEntity()
        {
            LoonCostFromParentYn = true;
            CalcRelations = new System.Collections.Generic.List<CalcRelationEntity>();
            CostHeaders = new System.Collections.Generic.List<CostHeaderEntity>();
            Projects = new System.Collections.Generic.List<ProjectEntity>();
            ProjectRelations = new System.Collections.Generic.List<ProjectRelationEntity>();
            SysWerfParas = new System.Collections.Generic.List<SysWerfParaEntity>();
            TodoItems = new System.Collections.Generic.List<TodoItemEntity>();
            WerfInvoiceAdresses = new System.Collections.Generic.List<WerfInvoiceAdressEntity>();
            WerfLijsts = new System.Collections.Generic.List<WerfLijstEntity>();
            WerfRelations = new System.Collections.Generic.List<WerfRelationEntity>();
            InitializePartial();
		}

        public long RelationId { get; set; }
        public int Number { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string AdressLine1 { get; set; }
        public string AdressLine2 { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string StreetCode { get; set; }
        public string CountryCode { get; set; }
        public string Language { get; set; }
        public string PayConditionId { get; set; }
        public string NotesInternal { get; set; }
        public string NotesExternal { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Website { get; set; }
        public int? LastUpdatedBy { get; set; }
        public System.DateTime? LastUpdated { get; set; }
        public string OnNumber { get; set; }
        public string Rpr { get; set; }
        public string RegNr { get; set; }
        public string NumberBh { get; set; }
        public string Country { get; set; }
        public int? Code1 { get; set; }
        public int? Code2 { get; set; }
        public int? Code3 { get; set; }
        public int? Code4 { get; set; }
        public int? Code5 { get; set; }
        public int? Code6 { get; set; }
        public int? Code7 { get; set; }
        public int? Code8 { get; set; }
        public byte[] Logo { get; set; }
        public string Gsm { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public string AccountNumber { get; set; }
        public int? DefaultBtwRegime { get; set; }
        public string SPhone1 { get; private set; }
        public string SPhone2 { get; private set; }
        public string SFax1 { get; private set; }
        public string SFax2 { get; private set; }
        public string SOnNumber { get; private set; }
        public string SGsm { get; private set; }
        public bool? IsReportTaxIncl { get; set; }
        public int? DefaultClientDiscountId { get; set; }
        public long? RegioId { get; set; }
        public long? AccId { get; set; }
        public string AccType { get; set; }
        public string ExtraPropText01 { get; set; }
        public string ExtraPropText02 { get; set; }
        public string ExtraPropText03 { get; set; }
        public string ExtraPropText04 { get; set; }
        public decimal? ExtraPropNum01 { get; set; }
        public decimal? ExtraPropNum02 { get; set; }
        public decimal? ExtraPropNum03 { get; set; }
        public decimal? ExtraPropNum04 { get; set; }
        public System.DateTime? UseRelationUntil { get; set; }
        public int IsRelationActive { get; private set; }
        public long? AnaCodeId { get; set; }
        public int? DefaultCashDiscountId { get; set; }
        public string DefaultKs { get; set; }
        public string PayConditionIdSupplier { get; set; }
        public string OnNumberReal { get; set; }
        public int? DefaultBtwRegimeSupplier { get; set; }
        public int? DefaultCashDiscountIdSupplier { get; set; }
        public string DefaultKsSupplier { get; set; }
        public double? DefaultLoonCost { get; set; }
        public bool LoonCostFromParentYn { get; set; }
        public string SOnNumberReal { get; private set; }
        public string SCleanedVatNumber { get; set; }
        public string SCleanedOnNumber { get; set; }
        public byte[] TimeStamp { get; set; }
        public System.Collections.Generic.ICollection<CalcRelationEntity> CalcRelations { get; set; }
        public System.Collections.Generic.ICollection<CostHeaderEntity> CostHeaders { get; set; }
        public System.Collections.Generic.ICollection<ProjectEntity> Projects { get; set; }
        public System.Collections.Generic.ICollection<ProjectRelationEntity> ProjectRelations { get; set; }
        public System.Collections.Generic.ICollection<SysWerfParaEntity> SysWerfParas { get; set; }
        public System.Collections.Generic.ICollection<TodoItemEntity> TodoItems { get; set; }
        public System.Collections.Generic.ICollection<WerfInvoiceAdressEntity> WerfInvoiceAdresses { get; set; }
        public System.Collections.Generic.ICollection<WerfLijstEntity> WerfLijsts { get; set; }
        public System.Collections.Generic.ICollection<WerfRelationEntity> WerfRelations { get; set; }
             
        partial void InitializePartial();
    }
}
