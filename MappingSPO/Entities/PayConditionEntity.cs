
namespace MappingSPO.Entities
{
    public partial class PayConditionEntity
    {
		public PayConditionEntity()
        {
            Invoices = new System.Collections.Generic.List<InvoiceEntity>();
            Relations = new System.Collections.Generic.List<RelationEntity>();
            InitializePartial();
		}

        public string PayConditionId { get; set; }
        public int Mode { get; set; }
        public int? Days { get; set; }
        public bool Disabled { get; set; }
        public string ExternalCode { get; set; }
        public string Description { get; set; }
        public System.Collections.Generic.ICollection<InvoiceEntity> Invoices { get; set; }
        public System.Collections.Generic.ICollection<RelationEntity> Relations { get; set; }
             
        partial void InitializePartial();
    }
}
