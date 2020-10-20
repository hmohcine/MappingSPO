
namespace MappingSPO.Entities
{
    public partial class EmmaVkoTypeEntity
    {
		public EmmaVkoTypeEntity()
        {
            Code1ErrorRequired = false;
            Code2ErrorRequired = false;
            Code3ErrorRequired = false;
            Code4ErrorRequired = false;
            CalculateIncl = false;
            StockModeFromParent = true;
            AutostockMode = 0;
            AutoStockBResBsMode = 0;
            AutoStockMinAantalInMagazijn = 0m;
            AutoStockMinAantalInToonzaal = 0m;
            AutoStockMaToMode = 0;
            AutoStockMaToVolgorde = 1;
            SalesDefaults = new System.Collections.Generic.List<SalesDefaultEntity>();
            InitializePartial();
		}

        public string VkoType { get; set; }
        public string Description { get; set; }
        public int VkoMasterType { get; set; }
        public int DigitsDocumentnummer { get; set; }
        public bool Disabled { get; set; }
        public bool CreateInvoiceYn { get; set; }
        public bool Code1Required { get; set; }
        public bool Code1ErrorRequired { get; set; }
        public long? Code1Default { get; set; }
        public bool Code2Required { get; set; }
        public bool Code2ErrorRequired { get; set; }
        public long? Code2Default { get; set; }
        public bool Code3Required { get; set; }
        public bool Code3ErrorRequired { get; set; }
        public long? Code3Default { get; set; }
        public bool Code4Required { get; set; }
        public bool Code4ErrorRequired { get; set; }
        public long? Code4Default { get; set; }
        public int ClientRelationTypeId { get; set; }
        public int DeliveryAdressRelationTypeId { get; set; }
        public int InvoiceAdressRelationTypeId { get; set; }
        public int DigitsUnit { get; set; }
        public int DigitsTotal { get; set; }
        public bool CalculateIncl { get; set; }
        public long? DefaultVerkoopCat { get; set; }
        public bool StockModeFromParent { get; set; }
        public int AutostockMode { get; set; }
        public int AutoStockBResBsMode { get; set; }
        public decimal AutoStockMinAantalInMagazijn { get; set; }
        public decimal AutoStockMinAantalInToonzaal { get; set; }
        public int AutoStockMaToMode { get; set; }
        public int AutoStockMaToVolgorde { get; set; }
        public System.Collections.Generic.ICollection<SalesDefaultEntity> SalesDefaults { get; set; }
        public RelActiviteitEntity RelActiviteit { get; set; }
        public RelationTypeEntity ClientRelationType { get; set; }
        public RelationTypeEntity DeliveryAdressRelationType { get; set; }
        public RelationTypeEntity InvoiceAdressRelationType { get; set; }
             
        partial void InitializePartial();
    }
}
