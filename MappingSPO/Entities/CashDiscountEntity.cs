
namespace MappingSPO.Entities
{
    public partial class CashDiscountEntity
    {
		public CashDiscountEntity()
        {
            WhereToUseMode = 2;
            Invoices = new System.Collections.Generic.List<InvoiceEntity>();
            Relations = new System.Collections.Generic.List<RelationEntity>();
            InitializePartial();
		}

        public int CashDiscountId { get; set; }
        public double Discountpct { get; set; }
        public int Days { get; set; }
        public string Description { get; set; }
        public bool Disabled { get; set; }
        public int WhereToUseMode { get; set; }
        public string ExternalCode { get; set; }
        public System.Collections.Generic.ICollection<InvoiceEntity> Invoices { get; set; }
        public System.Collections.Generic.ICollection<RelationEntity> Relations { get; set; }
             
        partial void InitializePartial();
    }
}
