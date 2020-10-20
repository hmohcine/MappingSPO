
namespace MappingSPO.Entities
{
    public partial class RelationEntity
    {
		public RelationEntity()
        {
            LoonCostFromParentYn = true;
            Companies = new System.Collections.Generic.List<CompanyEntity>();
            EmmaMagazijns_DeliveryAdressMagazijn = new System.Collections.Generic.List<EmmaMagazijnEntity>();
            EmmaMagazijns_OwnerArticles = new System.Collections.Generic.List<EmmaMagazijnEntity>();
            Invoices = new System.Collections.Generic.List<InvoiceEntity>();
            RelationsContacts = new System.Collections.Generic.List<RelationsContactEntity>();
            SysWerfParas = new System.Collections.Generic.List<SysWerfParaEntity>();
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
        public System.Collections.Generic.ICollection<CompanyEntity> Companies { get; set; }
        public System.Collections.Generic.ICollection<EmmaMagazijnEntity> EmmaMagazijns_DeliveryAdressMagazijn { get; set; }
        public System.Collections.Generic.ICollection<EmmaMagazijnEntity> EmmaMagazijns_OwnerArticles { get; set; }
        public System.Collections.Generic.ICollection<InvoiceEntity> Invoices { get; set; }
        public System.Collections.Generic.ICollection<RelationsContactEntity> RelationsContacts { get; set; }
        public System.Collections.Generic.ICollection<SysWerfParaEntity> SysWerfParas { get; set; }
        public BAnaCodeEntity BAnaCode { get; set; }
        public CashDiscountEntity CashDiscount { get; set; }
        public ClientDiscountEntity ClientDiscount { get; set; }
        public CountryEntity Country_CountryCode { get; set; }
        public KsEntity Ks { get; set; }
        public LanguageEntity Language_Language { get; set; }
        public PayConditionEntity PayCondition { get; set; }
        public RelationCode1Entity RelationCode1 { get; set; }
        public RelationCode2Entity RelationCode2 { get; set; }
        public RelationCode3Entity RelationCode3 { get; set; }
        public RelationCode4Entity RelationCode4 { get; set; }
        public RelationCode5Entity RelationCode5 { get; set; }
        public RelationCode6Entity RelationCode6 { get; set; }
        public RelationCode7Entity RelationCode7 { get; set; }
        public RelationCode8Entity RelationCode8 { get; set; }
        public UserEntity User { get; set; }
        public VatRegimeEntity VatRegime { get; set; }
             
        partial void InitializePartial();
    }
}
