
namespace MappingSPO.Entities
{
    public partial class RelationTypeEntity
    {
		public RelationTypeEntity()
        {
            UseInWorkerContract = false;
            UseForShareAtWork = false;
            ArticleDefaults = new System.Collections.Generic.List<ArticleDefaultEntity>();
            EmmaOfferTypes_ClientRelationTypeId = new System.Collections.Generic.List<EmmaOfferTypeEntity>();
            EmmaOfferTypes_DeliveryAdressRelationTypeId = new System.Collections.Generic.List<EmmaOfferTypeEntity>();
            EmmaOfferTypes_InvoiceAdressRelationTypeId = new System.Collections.Generic.List<EmmaOfferTypeEntity>();
            EmmaVkoTypes_ClientRelationTypeId = new System.Collections.Generic.List<EmmaVkoTypeEntity>();
            EmmaVkoTypes_DeliveryAdressRelationTypeId = new System.Collections.Generic.List<EmmaVkoTypeEntity>();
            EmmaVkoTypes_InvoiceAdressRelationTypeId = new System.Collections.Generic.List<EmmaVkoTypeEntity>();
            InitializePartial();
		}

        public int RelationTypeId { get; set; }
        public string RelationType_ { get; set; }
        public int? MasterType { get; set; }
        public bool? RequiredForWerf { get; set; }
        public string ShortName { get; set; }
        public bool UseInWorkerContract { get; set; }
        public bool UseForShareAtWork { get; set; }
        public System.Collections.Generic.ICollection<ArticleDefaultEntity> ArticleDefaults { get; set; }
        public System.Collections.Generic.ICollection<EmmaOfferTypeEntity> EmmaOfferTypes_ClientRelationTypeId { get; set; }
        public System.Collections.Generic.ICollection<EmmaOfferTypeEntity> EmmaOfferTypes_DeliveryAdressRelationTypeId { get; set; }
        public System.Collections.Generic.ICollection<EmmaOfferTypeEntity> EmmaOfferTypes_InvoiceAdressRelationTypeId { get; set; }
        public System.Collections.Generic.ICollection<EmmaVkoTypeEntity> EmmaVkoTypes_ClientRelationTypeId { get; set; }
        public System.Collections.Generic.ICollection<EmmaVkoTypeEntity> EmmaVkoTypes_DeliveryAdressRelationTypeId { get; set; }
        public System.Collections.Generic.ICollection<EmmaVkoTypeEntity> EmmaVkoTypes_InvoiceAdressRelationTypeId { get; set; }
             
        partial void InitializePartial();
    }
}
