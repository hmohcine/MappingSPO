
namespace MappingSPO.Project.DL.Entities
{
    public partial class WerfInvoiceAdressEntity
    {
		public WerfInvoiceAdressEntity()
        {
            Werfs = new System.Collections.Generic.List<WerfEntity>();
            InitializePartial();
		}

        public long WerfId { get; set; }
        public long InvoiceAdressId { get; set; }
        public long RelationId { get; set; }
        public int? ContactId { get; set; }
        public int CompanyId { get; set; }
        public int RelationTypeId { get; set; }
        public string SchuldVorderingBody { get; set; }
        public string PayConditionId { get; set; }
        public int? DefaultCashDiscountId { get; set; }
        public string LanguageCode { get; set; }
        public int? TotalNumberOfPrints { get; set; }
        public System.DateTime? LastPrintDate { get; set; }
        public long? ReportId { get; set; }
        public System.Collections.Generic.ICollection<WerfEntity> Werfs { get; set; }
        public ContactEntity Contact { get; set; }
        public RelationEntity Relation { get; set; }
        public WerfEntity Werf { get; set; }
        public WerfRelationEntity WerfRelation { get; set; }
             
        partial void InitializePartial();
    }
}
