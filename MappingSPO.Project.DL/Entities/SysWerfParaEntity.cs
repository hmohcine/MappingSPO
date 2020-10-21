
namespace MappingSPO.Project.DL.Entities
{
    public partial class SysWerfParaEntity
    {
		public SysWerfParaEntity()
        {
            VordStructModeStaat1 = 0;
            VordStructModeStaat2 = 0;
            VordStructModeStaat3 = 0;
            VordPostMode1 = 0;
            VordDetailMode = 0;
            VordHerzieningMode = 0;
            VordSamenvattingMode = 0;
            VordSchuldVorderingMode = 0;
            VordPostMode2 = 0;
            VordPostMode3 = 0;
            WerfAnalyseMode = 0;
            VordShowSubTotalsOnHfst = false;
            SyncWerflijst = false;
            UseNewWerfScreen = false;
            InitializePartial();
		}

        public int Id1 { get; set; }
        public string WerfDefaultType { get; set; }
        public string WerfNumberFormat { get; set; }
        public string WerfDate1Label { get; set; }
        public string WerfDate2Label { get; set; }
        public string WerfCode1Caption { get; set; }
        public string WerfCode2Caption { get; set; }
        public string WerfCode3Caption { get; set; }
        public string WerfCode4Caption { get; set; }
        public string WerfCode5Caption { get; set; }
        public string WerfCode6Caption { get; set; }
        public string WerfCode7Caption { get; set; }
        public string WerfCode8Caption { get; set; }
        public int OfferShowOnPart { get; set; }
        public int OfferShowOverOnPart { get; set; }
        public int ExtentionShowOnPart { get; set; }
        public int ExtentionShowOverOnPart { get; set; }
        public int WerfCategory { get; set; }
        public int? FacturationMode { get; set; }
        public int VordStructModeStaat1 { get; set; }
        public int VordStructModeStaat2 { get; set; }
        public int VordStructModeStaat3 { get; set; }
        public int VordPostMode1 { get; set; }
        public int VordDetailMode { get; set; }
        public int VordHerzieningMode { get; set; }
        public int VordSamenvattingMode { get; set; }
        public int VordSchuldVorderingMode { get; set; }
        public int VordPostMode2 { get; set; }
        public int VordPostMode3 { get; set; }
        public int? InvoiceDefaultBtwRegime { get; set; }
        public int? InvoiceDefaultVatCode { get; set; }
        public bool? SysInvoiceAutoDirectState2 { get; set; }
        public string DefaultWerkCode { get; set; }
        public int? CostDigitsUnit { get; set; }
        public int? CostDigitsTotal { get; set; }
        public string Ref1Label { get; set; }
        public string Ref2Label { get; set; }
        public string Ref3Label { get; set; }
        public string Ref4Label { get; set; }
        public int? InvoiceDefaultCompanyId { get; set; }
        public long? DefaultMagazijnId { get; set; }
        public int? Cncekp { get; set; }
        public int? Cncevp { get; set; }
        public bool? ListReadOnly { get; set; }
        public int? AddPostenToVordMode { get; set; }
        public bool? AutoCreateCostYn { get; set; }
        public string AutoCreateCostTemplate { get; set; }
        public long? ExtraLeveradres1 { get; set; }
        public int? AssistDefaultDeliveryType { get; set; }
        public int WerfAnalyseMode { get; set; }
        public bool? AssistAutoCreateWerfLijst { get; set; }
        public bool? AssistAutoOkWerfLijst { get; set; }
        public string LabelProjectLeider { get; set; }
        public string LabelWerfLeider { get; set; }
        public int? AutoAssistOnNewWerfPartMode { get; set; }
        public bool? AutoAddRequiredRelations { get; set; }
        public int? AutoVatMode { get; set; }
        public bool? AutoAddProject { get; set; }
        public string CustomSpAddItemsToWerfLijst { get; set; }
        public int? DefaultDuurVerificatieTermijn { get; set; }
        public decimal? DefaultVerwijlIntrestRentevoet { get; set; }
        public string ExtNumberLabel { get; set; }
        public int? ExtNumberMode { get; set; }
        public bool? VordShowSubTotalsOnHfst { get; set; }
        public string ExtraNum1Label { get; set; }
        public string ExtraNum2Label { get; set; }
        public string ExtraNum3Label { get; set; }
        public string ExtraNum4Label { get; set; }
        public string ExtraNum5Label { get; set; }
        public string ExtraNum6Label { get; set; }
        public string ExtraNum7Label { get; set; }
        public string ExtraNum8Label { get; set; }
        public string ExtaNumShortLabel1 { get; set; }
        public string ExtaNumShortLabel2 { get; set; }
        public string ExtaNumShortLabel3 { get; set; }
        public string ExtaNumShortLabel4 { get; set; }
        public string ExtaNumShortLabel5 { get; set; }
        public string ExtaNumShortLabel6 { get; set; }
        public string ExtaNumShortLabel7 { get; set; }
        public string ExtaNumShortLabel8 { get; set; }
        public bool? SumExtraNum1 { get; set; }
        public bool? SumExtraNum2 { get; set; }
        public bool? SumExtraNum3 { get; set; }
        public bool? SumExtraNum4 { get; set; }
        public bool? SumExtraNum5 { get; set; }
        public bool? SumExtraNum6 { get; set; }
        public bool? SumExtraNum7 { get; set; }
        public bool? SumExtraNum8 { get; set; }
        public int? VordShowCncMode { get; set; }
        public int? VordShowDigitsUnits { get; set; }
        public int? VordShowDigitsEprijs { get; set; }
        public int? VordShowDigitsPrijs { get; set; }
        public string OaContractCode1Caption { get; set; }
        public string OaContractCode2Caption { get; set; }
        public string OaContractCode3Caption { get; set; }
        public string OaContractCode4Caption { get; set; }
        public string OaContractCode5Caption { get; set; }
        public string OaContractCode6Caption { get; set; }
        public string OaContractCode7Caption { get; set; }
        public string OaContractCode8Caption { get; set; }
        public string OaContractRef1Label { get; set; }
        public string OaContractRef2Label { get; set; }
        public string OaContractRef3Label { get; set; }
        public string OaContractRef4Label { get; set; }
        public string OaContractDate1Label { get; set; }
        public string OaContractDate2Label { get; set; }
        public string OaContractLabelVerantw1 { get; set; }
        public string OaContractLabelVerantw2 { get; set; }
        public string MultiAnaCode1Label { get; set; }
        public string MultiAnaCode2Label { get; set; }
        public string MultiAnaCode3Label { get; set; }
        public string MultiAnaCode4Label { get; set; }
        public string MultiAnaCode5Label { get; set; }
        public string MultiAnaCode6Label { get; set; }
        public string MultiAnaCode7Label { get; set; }
        public string MultiAnaCode8Label { get; set; }
        public string ContractOaDefaultType { get; set; }
        public string ExtraDateWerfLabel1 { get; set; }
        public string ExtraDateWerfLabel2 { get; set; }
        public string ExtraDateWerfLabel3 { get; set; }
        public string ExtraDateWerfLabel4 { get; set; }
        public string ExtraDateWerfLabel5 { get; set; }
        public string ExtraDateWerfLabel6 { get; set; }
        public string ExtraDateWerfLabel7 { get; set; }
        public string ExtraDateWerfLabel8 { get; set; }
        public string ExtraDateContractOaLabel1 { get; set; }
        public string ExtraDateContractOaLabel2 { get; set; }
        public string ExtraDateContractOaLabel3 { get; set; }
        public string ExtraDateContractOaLabel4 { get; set; }
        public string ExtraDateContractOaLabel5 { get; set; }
        public string ExtraDateContractOaLabel6 { get; set; }
        public string ExtraDateContractOaLabel7 { get; set; }
        public string ExtraDateContractOaLabel8 { get; set; }
        public long? DefaultVerkoopCat { get; set; }
        public long? DefaultInkoopCat { get; set; }
        public int? AutoAssistForVerkoopCatMode { get; set; }
        public int? AutoVerkoopCatMode { get; set; }
        public long? DefaultVerkoopCatHerziening { get; set; }
        public long? DefaultVerkoopCatRegie { get; set; }
        public bool SyncWerflijst { get; set; }
        public bool UseNewWerfScreen { get; set; }
        public string ExtraBoolean1Label { get; set; }
        public string ExtraBoolean2Label { get; set; }
        public string ExtraBoolean3Label { get; set; }
        public string ExtraBoolean4Label { get; set; }
        public CostHeaderTypeEntity CostHeaderType { get; set; }
        public RelationEntity Relation { get; set; }
             
        partial void InitializePartial();
    }
}
