
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalculationEntity
    {
		public CalculationEntity()
        {
            BColor = -16777216;
            XWinstpctCurrent = 0;
            XWinstpctRequested = 0;
            XWinstCurrent = 0;
            RecalcOnClose = true;
            MarkedForDeletion = false;
            CalcSoort = 0;
            Domain = "C";
            UiVersion = 0;
            ExtraBoolean1 = false;
            ExtraBoolean2 = false;
            ExtraBoolean3 = false;
            ExtraBoolean4 = false;
            ExtraBoolean5 = false;
            ExtraBoolean6 = false;
            ExtraBoolean7 = false;
            ExtraBoolean8 = false;
            BibUsers = new System.Collections.Generic.List<BibUserEntity>();
            CalcActiviteitens = new System.Collections.Generic.List<CalcActiviteitenEntity>();
            CalcDetails = new System.Collections.Generic.List<CalcDetailEntity>();
            CalcHcs = new System.Collections.Generic.List<CalcHcEntity>();
            CalcInkoopCategories = new System.Collections.Generic.List<CalcInkoopCategorieEntity>();
            CalcKs = new System.Collections.Generic.List<CalcKEntity>();
            CalcLibraries = new System.Collections.Generic.List<CalcLibraryEntity>();
            CalcLogbooks = new System.Collections.Generic.List<CalcLogbookEntity>();
            CalcOfferClients = new System.Collections.Generic.List<CalcOfferClientEntity>();
            CalcParameterValues = new System.Collections.Generic.List<CalcParameterValueEntity>();
            CalcProperties = new System.Collections.Generic.List<CalcPropertyEntity>();
            CalcRelations = new System.Collections.Generic.List<CalcRelationEntity>();
            CalcStatusHistorieks = new System.Collections.Generic.List<CalcStatusHistoriekEntity>();
            CalcTextens = new System.Collections.Generic.List<CalcTextenEntity>();
            CalcTransactions = new System.Collections.Generic.List<CalcTransactionEntity>();
            CalculationLogs = new System.Collections.Generic.List<CalculationLogEntity>();
            CalculationVersions = new System.Collections.Generic.List<CalculationVersionEntity>();
            ProjectCalculations = new System.Collections.Generic.List<ProjectCalculationEntity>();
            SupplierPrijsAntwoords = new System.Collections.Generic.List<SupplierPrijsAntwoordEntity>();
            Calculations_BaseCalcId = new System.Collections.Generic.List<CalculationEntity>();
            Calculations_PrijsVraagId = new System.Collections.Generic.List<CalculationEntity>();
            InitializePartial();
		}

        public long CalcId { get; set; }
        public string CalcTypeId { get; set; }
        public int? CalcYear { get; set; }
        public int? CalcNumber { get; set; }
        public string ExtNumber { get; set; }
        public int? CalcStatus { get; set; }
        public string CalcName { get; set; }
        public string NotesInternal { get; set; }
        public string NotesExternal { get; set; }
        public string NotesXml { get; set; }
        public int? DigitsUnit { get; set; }
        public int? DigitsTotal { get; set; }
        public byte[] Timestamp { get; set; }
        public double? Tkp { get; set; }
        public double? Tvp { get; set; }
        public System.DateTime? CreatedDate { get; set; }
        public System.DateTime? LastSaveData { get; set; }
        public int? Creator { get; set; }
        public int? Calculator { get; set; }
        public int? Code1 { get; set; }
        public int? Code2 { get; set; }
        public int? Code3 { get; set; }
        public int? Code4 { get; set; }
        public int? Code5 { get; set; }
        public int? Code6 { get; set; }
        public int? Code7 { get; set; }
        public int? Code8 { get; set; }
        public long? ProjectId { get; set; }
        public int? CurrentOwner { get; set; }
        public int? BColor { get; set; }
        public string BText { get; set; }
        public bool? BBold { get; set; }
        public string MText { get; set; }
        public byte[] BIcon { get; set; }
        public System.DateTime? Datum1 { get; set; }
        public System.DateTime? Datum2 { get; set; }
        public System.DateTime? OfferteDatum { get; set; }
        public int? ShowDigitsEkp { get; set; }
        public int? ShowDigitsKp { get; set; }
        public int? ShowDigitsEvp { get; set; }
        public int? ShowDigitsVp { get; set; }
        public double? XWinstpctCurrent { get; set; }
        public double? XWinstpctRequested { get; set; }
        public double? XWinstCurrent { get; set; }
        public int? SummaryMode { get; set; }
        public string OfferNotes1 { get; set; }
        public string OfferNotes2 { get; set; }
        public int? OfferClientRelation { get; set; }
        public int? OfferClientContact { get; set; }
        public int? OfferDeliveryRelation { get; set; }
        public int? OfferDeliveryContact { get; set; }
        public string OfferTitle { get; set; }
        public bool? Code1Visible { get; set; }
        public bool? Code2Visible { get; set; }
        public bool? Code3Visible { get; set; }
        public bool? Code4Visible { get; set; }
        public bool? Code5Visible { get; set; }
        public bool? Code6Visible { get; set; }
        public bool? Code7Visible { get; set; }
        public bool? Code8Visible { get; set; }
        public int? CompanyId { get; set; }
        public int? VatCode { get; set; }
        public int? BtwRegime { get; set; }
        public string ShowMgtParts { get; set; }
        public System.DateTime? VervalDatum { get; set; }
        public bool RecalcOnClose { get; set; }
        public string PathDocsFileSystem { get; set; }
        public System.DateTime? IndienDatum { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public int? ShowDigitsAantal { get; set; }
        public string UriWebSystem { get; set; }
        public bool? ExtendedIpVerdeling { get; set; }
        public System.DateTime? LastUpdatedEkpDate { get; set; }
        public string LastUpdatedEkpLog { get; set; }
        public double? Q1 { get; set; }
        public double? Q2 { get; set; }
        public string LoonEc { get; set; }
        public double? LoonAantal { get; set; }
        public int? ArticleLibraryType { get; set; }
        public long? ArticleLibraryId { get; set; }
        public int? ArticleLibrarySettings { get; set; }
        public int? PostLibraryType { get; set; }
        public long? PostLibraryId { get; set; }
        public int? PostLibrarySettings { get; set; }
        public bool? PostDontOverwrite { get; set; }
        public bool? PostLibraryIncludeQuantity { get; set; }
        public bool? ToonOpmetingen { get; set; }
        public int? ToonSamenvatting { get; set; }
        public bool? ToonLijnOnder { get; set; }
        public bool? HideTotalsOnHfst { get; set; }
        public bool? CanChangeParaYn { get; set; }
        public string CalcPassword { get; set; }
        public int? WinstMode { get; set; }
        public System.DateTime? ExtraDate1 { get; set; }
        public System.DateTime? ExtraDate2 { get; set; }
        public System.DateTime? ExtraDate3 { get; set; }
        public System.DateTime? ExtraDate4 { get; set; }
        public System.DateTime? ExtraDate5 { get; set; }
        public int? ExtendedWinstMode { get; set; }
        public double? Bw01Pct { get; set; }
        public double? Bw02Pct { get; set; }
        public double? Bw03Pct { get; set; }
        public double? Bw04Pct { get; set; }
        public bool? EnableExtWinstMode { get; set; }
        public double? BudgetVerlaging1Gevraagd { get; set; }
        public bool MarkedForDeletion { get; set; }
        public int? WhoMarkedForDeletion { get; set; }
        public string DeletionErrorRemark { get; set; }
        public int? DefaultBtwRegime { get; set; }
        public int? DefaultVatCode { get; set; }
        public bool? ApplyBtwOnNewPosts { get; set; }
        public double? ExtraNum1 { get; set; }
        public double? ExtraNum2 { get; set; }
        public double? ExtraNum3 { get; set; }
        public double? ExtraNum4 { get; set; }
        public double? ExtraNum5 { get; set; }
        public double? ExtraNum6 { get; set; }
        public double? ExtraNum7 { get; set; }
        public double? ExtraNum8 { get; set; }
        public int CalcSoort { get; set; }
        public string Domain { get; set; }
        public double? TvpIncl { get; set; }
        public long? TemplateCalcId { get; set; }
        public int? Verantwoordelijke1 { get; set; }
        public int? Verantwoordelijke2 { get; set; }
        public int? Verantwoordelijke3 { get; set; }
        public int UiVersion { get; set; }
        public string BimModelName { get; set; }
        public long? DefaultVerkoopCatId { get; set; }
        public bool? ApplyVerkoopCatOnNewPosts { get; set; }
        public int? WbsCodeIndex { get; set; }
        public bool? IsRaw { get; set; }
        public double? BijdrageRawPct { get; set; }
        public double? BijdrageFckctPct { get; set; }
        public double? AlgKostRawPct { get; set; }
        public double? WinstRisRawPct { get; set; }
        public bool ExtraBoolean1 { get; set; }
        public bool ExtraBoolean2 { get; set; }
        public bool ExtraBoolean3 { get; set; }
        public bool ExtraBoolean4 { get; set; }
        public bool ExtraBoolean5 { get; set; }
        public bool ExtraBoolean6 { get; set; }
        public bool ExtraBoolean7 { get; set; }
        public bool ExtraBoolean8 { get; set; }
        public int? VersieRaw { get; set; }
        public CalcAddTemplateEntity CalcAddTemplate { get; set; }
        public CalculationVersionEntity CalculationVersion { get; set; }
        public System.Collections.Generic.ICollection<BibUserEntity> BibUsers { get; set; }
        public System.Collections.Generic.ICollection<CalcActiviteitenEntity> CalcActiviteitens { get; set; }
        public System.Collections.Generic.ICollection<CalcDetailEntity> CalcDetails { get; set; }
        public System.Collections.Generic.ICollection<CalcHcEntity> CalcHcs { get; set; }
        public System.Collections.Generic.ICollection<CalcInkoopCategorieEntity> CalcInkoopCategories { get; set; }
        public System.Collections.Generic.ICollection<CalcKEntity> CalcKs { get; set; }
        public System.Collections.Generic.ICollection<CalcLibraryEntity> CalcLibraries { get; set; }
        public System.Collections.Generic.ICollection<CalcLogbookEntity> CalcLogbooks { get; set; }
        public System.Collections.Generic.ICollection<CalcOfferClientEntity> CalcOfferClients { get; set; }
        public System.Collections.Generic.ICollection<CalcParameterValueEntity> CalcParameterValues { get; set; }
        public System.Collections.Generic.ICollection<CalcPropertyEntity> CalcProperties { get; set; }
        public System.Collections.Generic.ICollection<CalcRelationEntity> CalcRelations { get; set; }
        public System.Collections.Generic.ICollection<CalcStatusHistoriekEntity> CalcStatusHistorieks { get; set; }
        public System.Collections.Generic.ICollection<CalcTextenEntity> CalcTextens { get; set; }
        public System.Collections.Generic.ICollection<CalcTransactionEntity> CalcTransactions { get; set; }
        public System.Collections.Generic.ICollection<CalculationEntity> Calculations_BaseCalcId { get; set; }
        public System.Collections.Generic.ICollection<CalculationEntity> Calculations_PrijsVraagId { get; set; }
        public System.Collections.Generic.ICollection<CalculationLogEntity> CalculationLogs { get; set; }
        public System.Collections.Generic.ICollection<CalculationVersionEntity> CalculationVersions { get; set; }
        public System.Collections.Generic.ICollection<ProjectCalculationEntity> ProjectCalculations { get; set; }
        public System.Collections.Generic.ICollection<SupplierPrijsAntwoordEntity> SupplierPrijsAntwoords { get; set; }
        public CalcCode1Entity CalcCode1 { get; set; }
        public CalcCode2Entity CalcCode2 { get; set; }
        public CalcCode3Entity CalcCode3 { get; set; }
        public CalcCode4Entity CalcCode4 { get; set; }
        public CalcCode5Entity CalcCode5 { get; set; }
        public CalcCode6Entity CalcCode6 { get; set; }
        public CalcCode7Entity CalcCode7 { get; set; }
        public CalcCode8Entity CalcCode8 { get; set; }
        public CalcTypeEntity CalcType { get; set; }
             
        partial void InitializePartial();
    }
}
