
namespace MappingSPO.Entities
{
    public partial class ArticleDefaultEntity
    {
		public ArticleDefaultEntity()
        {
            Id = 1;
            DiscountPermitted = true;
            WPrijsMode = 0;
            WPrijsVerdeelWijze = 0;
            BsStockBibMode = 0;
            IsToeslagActive = false;
            DefaultVkoLeveradresMode = 0;
            DefaultVkoStateForBssIntegratie = 1;
            InitializePartial();
		}

        public long Id { get; set; }
        public string DefaultEc { get; set; }
        public string DefaultKs { get; set; }
        public string DefaultCurrencyCode { get; set; }
        public int? DefaultVatCode { get; set; }
        public int? DefaultRoundPosition { get; set; }
        public string ArtLabel0 { get; set; }
        public string ArtLabel1 { get; set; }
        public string ArtLabel2 { get; set; }
        public string ArtLabel3 { get; set; }
        public string ArtLabel4 { get; set; }
        public string ArtLabel5 { get; set; }
        public string ArtLabel6 { get; set; }
        public string ArtLabel7 { get; set; }
        public string ArtLabel8 { get; set; }
        public bool? DiscountPermitted { get; set; }
        public double? MaxDiscountOnMarge { get; set; }
        public string ArtLanguage1 { get; set; }
        public string ArtLanguage2 { get; set; }
        public string ArtLanguage3 { get; set; }
        public string ArtLanguage4 { get; set; }
        public int? CalcLogicCode { get; set; }
        public double? TargetWinstpct { get; set; }
        public bool? ShowNotesExternOffer { get; set; }
        public bool? ShowNotesExternVko { get; set; }
        public bool? ShowNotesExternInvoice { get; set; }
        public bool? ShowNotesExternLeverbon { get; set; }
        public bool? ShowNotesExternBestelbon { get; set; }
        public int? ArtImageImportSize { get; set; }
        public string DefaultEcGewicht { get; set; }
        public string DefaultEcVolume { get; set; }
        public string DefaultArtLanguage { get; set; }
        public int WPrijsMode { get; set; }
        public int WPrijsVerdeelWijze { get; set; }
        public string DefaultDimEc { get; set; }
        public int BsStockBibMode { get; set; }
        public string BsDefaultLanguage { get; set; }
        public string InfoLabel01 { get; set; }
        public string InfoLabel02 { get; set; }
        public string InfoLabel03 { get; set; }
        public string InfoLabel04 { get; set; }
        public string SuplArtInfoLabel01 { get; set; }
        public string SuplArtInfoLabel02 { get; set; }
        public string SuplArtInfoLabel03 { get; set; }
        public string SuplArtInfoLabel04 { get; set; }
        public string NumLabel01 { get; set; }
        public string NumLabel02 { get; set; }
        public string NumLabel03 { get; set; }
        public string NumLabel04 { get; set; }
        public string RefLabel01 { get; set; }
        public string RefLabel02 { get; set; }
        public string RefLabel03 { get; set; }
        public string RefLabel04 { get; set; }
        public string SuplArtRefLabel01 { get; set; }
        public string SuplArtRefLabel02 { get; set; }
        public string SuplArtRefLabel03 { get; set; }
        public string SuplArtRefLabel04 { get; set; }
        public string CalcDetailSettingNum01 { get; set; }
        public string CalcDetailSettingNum02 { get; set; }
        public string CalcDetailSettingNum03 { get; set; }
        public string CalcDetailSettingNum04 { get; set; }
        public string CalcDetailSettingNum05 { get; set; }
        public string CalcDetailSettingNum06 { get; set; }
        public string CalcDetailSettingNum07 { get; set; }
        public string CalcDetailSettingNum08 { get; set; }
        public bool? IsToeslagActive { get; set; }
        public bool? WerflijstToVko { get; set; }
        public string DefaultVkoTypeForBssIntegratie { get; set; }
        public int? DefaultVkoCompanyIdForBssIntegratie { get; set; }
        public int? DefaultVkoCompanyIdStockForBssIntegratie { get; set; }
        public int? CreateSbLeveringOnEmmaLeverBonState { get; set; }
        public int? DefaultVkoLeveradresRelationType { get; set; }
        public int DefaultVkoLeveradresMode { get; set; }
        public int DefaultVkoStateForBssIntegratie { get; set; }
        public CurrencyEntity Currency { get; set; }
        public KsEntity Ks { get; set; }
        public LanguageEntity Language_ArtLanguage1 { get; set; }
        public LanguageEntity Language_ArtLanguage2 { get; set; }
        public LanguageEntity Language_ArtLanguage3 { get; set; }
        public LanguageEntity Language_ArtLanguage4 { get; set; }
        public LanguageEntity Language_DefaultArtLanguage { get; set; }
        public RelationTypeEntity RelationType { get; set; }
        public UcEntity Uc_DefaultEc { get; set; }
        public UcEntity Uc_DefaultEcGewicht { get; set; }
        public UcEntity Uc_DefaultEcVolume { get; set; }
        public VatEntity Vat { get; set; }
             
        partial void InitializePartial();
    }
}
