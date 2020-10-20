
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcRelationEntity
    {
		public CalcRelationEntity()
        {
            CalcRelationContacts = new System.Collections.Generic.List<CalcRelationContactEntity>();
            InitializePartial();
		}

        public long CalcId { get; set; }
        public long RelationId { get; set; }
        public int RelationTypeId { get; set; }
        public string Notes { get; set; }
        public int? DefaultContactId { get; set; }
        public System.DateTime? LastOfferPreview { get; set; }
        public System.DateTime? LastOfferPrint { get; set; }
        public string LanguageCode { get; set; }
        public System.Collections.Generic.ICollection<CalcRelationContactEntity> CalcRelationContacts { get; set; }
        public CalculationEntity Calculation { get; set; }
        public RelationEntity Relation { get; set; }
        public RelationTypeEntity RelationType { get; set; }
        public WCalculationExplorerDxEntity WCalculationExplorerDx { get; set; }
             
        partial void InitializePartial();
    }
}
