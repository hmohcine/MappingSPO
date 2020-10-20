
namespace MappingSPO.Entities
{
    public partial class SysRelationsParaEntity
    {
		public SysRelationsParaEntity()
        {
            AdsGuid = System.Guid.NewGuid();
            TranslationMasterSwitch = false;
            UseNewRelationScreen = false;
            InitializePartial();
		}

        public int Id { get; set; }
        public string RelationType { get; set; }
        public int? MasterType { get; set; }
        public int? ContactTypeId { get; set; }
        public int? RelationTypeId { get; set; }
        public string Code1Caption { get; set; }
        public string Code2Caption { get; set; }
        public string Code3Caption { get; set; }
        public string Code4Caption { get; set; }
        public string Code5Caption { get; set; }
        public string Code6Caption { get; set; }
        public string Code7Caption { get; set; }
        public string Code8Caption { get; set; }
        public string AdsCode1Caption { get; set; }
        public string AdsCode2Caption { get; set; }
        public string AdsCode3Caption { get; set; }
        public string AdsCode4Caption { get; set; }
        public string AdsRef1Caption { get; set; }
        public string AdsRef2Caption { get; set; }
        public string AdsRef3Caption { get; set; }
        public string AdsRef4Caption { get; set; }
        public System.Guid AdsGuid { get; set; }
        public string Ref1Caption { get; set; }
        public string Ref2Caption { get; set; }
        public string Ref3Caption { get; set; }
        public string Ref4Caption { get; set; }
        public string EmmaAdsCode1Caption1 { get; set; }
        public string EmmaAdsCode2Caption1 { get; set; }
        public string EmmaAdsCode3Caption1 { get; set; }
        public string EmmaAdsCode4Caption1 { get; set; }
        public string EmmaAdsRef1Caption1 { get; set; }
        public string EmmaAdsRef2Caption1 { get; set; }
        public string EmmaAdsRef3Caption1 { get; set; }
        public string EmmaAdsRef4Caption1 { get; set; }
        public string ExtraPropText01Label { get; set; }
        public string ExtraPropText02Label { get; set; }
        public string ExtraPropText03Label { get; set; }
        public string ExtraPropText04Label { get; set; }
        public string ExtraPropNum01Label { get; set; }
        public string ExtraPropNum02Label { get; set; }
        public string ExtraPropNum03Label { get; set; }
        public string ExtraPropNum04Label { get; set; }
        public bool? TranslationMasterSwitch { get; set; }
        public bool? StockmanagedbyEmma { get; set; }
        public bool? ShowBAnacode1 { get; set; }
        public string LabelBAnaCode1 { get; set; }
        public string AnaModeValues { get; set; }
        public int? AnaModeDefaultValue { get; set; }
        public string ActiviteitDelimeterChar { get; set; }
        public string CompanyWebUrl { get; set; }
        public string CompanyWebLogon { get; set; }
        public string CompanyWebPassword { get; set; }
        public bool UseNewRelationScreen { get; set; }
             
        partial void InitializePartial();
    }
}
