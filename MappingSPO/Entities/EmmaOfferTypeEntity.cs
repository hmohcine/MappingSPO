
namespace MappingSPO.Entities
{
    public partial class EmmaOfferTypeEntity
    {
		public EmmaOfferTypeEntity()
        {
            Code1Required = false;
            Code2Required = false;
            Code3Required = false;
            Code4Required = false;
            DigitsUnit = 2;
            DigitsTotal = 2;
            Code1ErrorRequired = false;
            Code2ErrorRequired = false;
            Code3ErrorRequired = false;
            Code4ErrorRequired = false;
            CalculateIncl = false;
            EmmaOfferLabelValues = new System.Collections.Generic.List<EmmaOfferLabelValueEntity>();
            SalesDefaults = new System.Collections.Generic.List<SalesDefaultEntity>();
            InitializePartial();
		}

        public string OfferType { get; set; }
        public string Description { get; set; }
        public int OfferMasterType { get; set; }
        public int DigitsDocumentnummer { get; set; }
        public bool Disabled { get; set; }
        public bool CreateInvoiceYn { get; set; }
        public bool Code1Required { get; set; }
        public long? Code1Default { get; set; }
        public bool Code2Required { get; set; }
        public long? Code2Default { get; set; }
        public bool Code3Required { get; set; }
        public long? Code3Default { get; set; }
        public bool Code4Required { get; set; }
        public long? Code4Default { get; set; }
        public int ClientRelationTypeId { get; set; }
        public int DeliveryAdressRelationTypeId { get; set; }
        public int InvoiceAdressRelationTypeId { get; set; }
        public int DigitsUnit { get; set; }
        public int DigitsTotal { get; set; }
        public bool Code1ErrorRequired { get; set; }
        public bool Code2ErrorRequired { get; set; }
        public bool Code3ErrorRequired { get; set; }
        public bool Code4ErrorRequired { get; set; }
        public bool CalculateIncl { get; set; }
        public long? DefaultVerkoopCat { get; set; }
        public System.Collections.Generic.ICollection<EmmaOfferLabelValueEntity> EmmaOfferLabelValues { get; set; }
        public System.Collections.Generic.ICollection<SalesDefaultEntity> SalesDefaults { get; set; }
        public RelActiviteitEntity RelActiviteit { get; set; }
        public RelationTypeEntity ClientRelationType { get; set; }
        public RelationTypeEntity DeliveryAdressRelationType { get; set; }
        public RelationTypeEntity InvoiceAdressRelationType { get; set; }
             
        partial void InitializePartial();
    }
}
