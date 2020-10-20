
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcRelationContactEntity
    {
		public CalcRelationContactEntity()
        {
            InitializePartial();
		}

        public long CalcId { get; set; }
        public long RelationId { get; set; }
        public int ContactId { get; set; }
        public int RelationTypeId { get; set; }
        public int? ContactTypeId { get; set; }
        public string Notes { get; set; }
        public CalcRelationEntity CalcRelation { get; set; }
             
        partial void InitializePartial();
    }
}
