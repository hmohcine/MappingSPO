
namespace MappingSPO.Entities
{
    public partial class SalesDefaultEntity
    {
		public SalesDefaultEntity()
        {
            Id = 1;
            AutoStockMaToMode = 0;
            AutoStockBResBsMode = 0;
            BestelWijzeDefault = 0;
            IsReportTaxIncl = false;
            Bold = false;
            Italic = false;
            Underline = false;
            AutostockMode = 0;
            EnableOrColumn = false;
            InitializePartial();
		}

        public long Id { get; set; }
        public string Code1Caption { get; set; }
        public string Code2Caption { get; set; }
        public string Code3Caption { get; set; }
        public string Code4Caption { get; set; }
        public string Code5Caption { get; set; }
        public string Code6Caption { get; set; }
        public string Code7Caption { get; set; }
        public string Code8Caption { get; set; }
        public string Ref1Caption { get; set; }
        public string Ref2Caption { get; set; }
        public string Ref3Caption { get; set; }
        public string Ref4Caption { get; set; }
        public decimal AutoStockMinAantalInMagazijn { get; set; }
        public decimal AutoStockMinAantalInToonzaal { get; set; }
        public int AutoStockMaToMode { get; set; }
        public int AutoStockBResBsMode { get; set; }
        public int BestelWijzeDefault { get; set; }
        public long? AddDaysForDeliveryDateWhenNull { get; set; }
        public int? LeverWijzeDefault { get; set; }
        public int? DefaultInvoiceAdressType { get; set; }
        public int? DefaultVatCode { get; set; }
        public int? DefaultVatRegime { get; set; }
        public int? DefaultStepAfterCreateInvoice { get; set; }
        public bool? IsReportTaxIncl { get; set; }
        public System.DateTime? LastRunAnalyse { get; set; }
        public bool? ManualUpdateDwEnabled { get; set; }
        public string DefaultVkoType { get; set; }
        public string DefaultOfferType { get; set; }
        public string FontExtendedRichTextBox { get; set; }
        public int? AutoStockMaToVolgorde { get; set; }
        public string OtherBestelBonPrefix { get; set; }
        public string FontExtraExtendedRtFbox { get; set; }
        public float? RtfZoomFactor { get; set; }
        public int? TextColor1 { get; set; }
        public int? TextColor2 { get; set; }
        public int? TextColor3 { get; set; }
        public int? TextColor4 { get; set; }
        public string TextColorName1 { get; set; }
        public string TextColorName2 { get; set; }
        public string TextColorName3 { get; set; }
        public string TextColorName4 { get; set; }
        public bool? Bold { get; set; }
        public bool? Italic { get; set; }
        public bool? Underline { get; set; }
        public int? DefaultTextColor { get; set; }
        public string Code9Caption { get; set; }
        public string BuildRef1Caption { get; set; }
        public string BuildRef2Caption { get; set; }
        public string BuildRef3Caption { get; set; }
        public string BuildRef4Caption { get; set; }
        public int AutostockMode { get; set; }
        public bool EnableOrColumn { get; set; }
        public EmmaOfferTypeEntity EmmaOfferType { get; set; }
        public EmmaVkoTypeEntity EmmaVkoType { get; set; }
        public VatEntity Vat { get; set; }
        public VatRegimeEntity VatRegime { get; set; }
             
        partial void InitializePartial();
    }
}
