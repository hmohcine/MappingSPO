
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcDetailEntity
    {
		public CalcDetailEntity()
        {
            TakeNotesFromCustomer = true;
            ActivatedMode = 0;
            Weight = 1;
            ResultFormula = 0;
            ReadyToCompile = false;
            UseSimpleFormula = false;
            CalcDetailParameterValues = new System.Collections.Generic.List<CalcDetailParameterValueEntity>();
            CalcTransactionPosts = new System.Collections.Generic.List<CalcTransactionPostEntity>();
            CalcTransactionPostArticles = new System.Collections.Generic.List<CalcTransactionPostArticleEntity>();
            CalcTransIndirectPosts = new System.Collections.Generic.List<CalcTransIndirectPostEntity>();
            InitializePartial();
		}

        public long CalcDetailId { get; set; }
        public long CalcId { get; set; }
        public long? ParentId { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public string Code3 { get; set; }
        public string Code4 { get; set; }
        public string Code5 { get; set; }
        public string Code6 { get; set; }
        public string Code7 { get; set; }
        public string Code8 { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string NotesExternal { get; set; }
        public string NotesExternalOa { get; set; }
        public bool? TakeNotesFromCustomer { get; set; }
        public string NotesInternal { get; set; }
        public string NotesXml { get; set; }
        public string CalcHc { get; set; }
        public string CalcLineTypeCode { get; set; }
        public string Ks { get; set; }
        public string Uc { get; set; }
        public double? Aantal { get; set; }
        public double? BestelAantal { get; set; }
        public double? ArchitectAantal { get; set; }
        public double? Ekp { get; set; }
        public double? Kp { get; set; }
        public double? Tkp { get; set; }
        public long? PrizeRequestDetailId { get; set; }
        public double? TotWinstpct { get; set; }
        public double? Winstpct2 { get; set; }
        public double? Winstpct3 { get; set; }
        public double? Ewinst { get; set; }
        public double? Evp { get; set; }
        public double? Vp { get; set; }
        public System.DateTime? DateUpdatedEkp { get; set; }
        public int? LineOrder { get; set; }
        public int? LineLevel { get; set; }
        public int? DigitsUnit { get; set; }
        public int? DigitsTotal { get; set; }
        public bool? DigitsChild { get; set; }
        public double? OldEkp { get; set; }
        public System.DateTime? OldDateUpdatedEkp { get; set; }
        public string Formule { get; set; }
        public bool IsImpactFormule { get; set; }
        public short? ActivatedMode { get; set; }
        public int? DynMode { get; set; }
        public double? Weight { get; set; }
        public double? XParent { get; set; }
        public string EcParent { get; set; }
        public double? XChild { get; set; }
        public string EcChild { get; set; }
        public double? FactorChild { get; set; }
        public double? FactorParent { get; set; }
        public short? RoundMethod { get; set; }
        public double? Digits { get; set; }
        public long? PostId { get; set; }
        public bool IsDone { get; set; }
        public bool? IsLocked { get; set; }
        public bool? IsFiltered { get; set; }
        public int? VatCode { get; set; }
        public int? BtwRegime { get; set; }
        public byte[] Timestamp { get; set; }
        public string LastErrorFormula { get; set; }
        public bool? IsParent { get; set; }
        public int? StructOrder { get; set; }
        public int? CalcOrder { get; set; }
        public bool? IsIndirectArticle { get; set; }
        public int? ResultFormula { get; set; }
        public bool ReadyToCompile { get; set; }
        public string OldEcChild { get; set; }
        public string OldEcParent { get; set; }
        public int? AddedFromVordering { get; set; }
        public long? ActiviteitId { get; set; }
        public string PrintCode { get; set; }
        public string NotesFormula { get; set; }
        public bool? AppendNotesFormulaToOffer { get; set; }
        public double? BudgetVerlaging1 { get; set; }
        public double? BudgetVerlaging2 { get; set; }
        public double? Budget { get; private set; }
        public double? ExtraNum1 { get; set; }
        public double? ExtraNum2 { get; set; }
        public double? ExtraNum3 { get; set; }
        public double? ExtraNum4 { get; set; }
        public double? ExtraNum5 { get; set; }
        public double? ExtraNum6 { get; set; }
        public double? ExtraNum7 { get; set; }
        public double? ExtraNum8 { get; set; }
        public long? InkoopCatId { get; set; }
        public long? VerkoopCatId { get; set; }
        public long? CalcActiviteitId { get; set; }
        public bool? EvpLockedYn { get; set; }
        public double? LockedEvp { get; set; }
        public System.Guid? BaseCalcLineId { get; set; }
        public System.Guid? AntwoordGuid { get; set; }
        public string SimpleFormula { get; set; }
        public bool? UseSimpleFormula { get; set; }
        public string BimName { get; set; }
        public double? MarkupIk { get; set; }
        public double? MarkupAk { get; set; }
        public double? MarkupWr { get; set; }
        public double? MarkupBij { get; set; }
        public OpmetingFormulaEntity OpmetingFormula { get; set; }
        public System.Collections.Generic.ICollection<CalcDetailParameterValueEntity> CalcDetailParameterValues { get; set; }
        public System.Collections.Generic.ICollection<CalcTransactionPostArticleEntity> CalcTransactionPostArticles { get; set; }
        public System.Collections.Generic.ICollection<CalcTransactionPostEntity> CalcTransactionPosts { get; set; }
        public System.Collections.Generic.ICollection<CalcTransIndirectPostEntity> CalcTransIndirectPosts { get; set; }
        public CalcHcEntity CalcHc_CalcHc { get; set; }
        public CalcLineTypeEntity CalcLineType { get; set; }
        public CalculationEntity Calculation { get; set; }
             
        partial void InitializePartial();
    }
}
