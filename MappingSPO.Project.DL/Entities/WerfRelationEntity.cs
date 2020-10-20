
namespace MappingSPO.Project.DL.Entities
{
    public partial class WerfRelationEntity
    {
		public WerfRelationEntity()
        {
            Werfs = new System.Collections.Generic.List<WerfEntity>();
            WerfInvoiceAdresses = new System.Collections.Generic.List<WerfInvoiceAdressEntity>();
            InitializePartial();
		}

        public long WerfId { get; set; }
        public long RelationId { get; set; }
        public int RelationTypeId { get; set; }
        public string Notes { get; set; }
        public int? DefaultContactId { get; set; }
        public System.Collections.Generic.ICollection<WerfEntity> Werfs { get; set; }
        public System.Collections.Generic.ICollection<WerfInvoiceAdressEntity> WerfInvoiceAdresses { get; set; }
        public RelationEntity Relation { get; set; }
        public RelationTypeEntity RelationType { get; set; }
        public WerfEntity Werf { get; set; }
        public WWerfExplorerDxEntity WWerfExplorerDx { get; set; }
             
        partial void InitializePartial();
    }
}
