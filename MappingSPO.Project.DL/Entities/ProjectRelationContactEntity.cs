
namespace MappingSPO.Project.DL.Entities
{
    public partial class ProjectRelationContactEntity
    {
		public ProjectRelationContactEntity()
        {
            AddedFromHeader = false;
            InitializePartial();
		}

        public long ProjectId { get; set; }
        public string ProjectType { get; set; }
        public int RelationTypeId { get; set; }
        public long RelationId { get; set; }
        public int ContactId { get; set; }
        public int? ContactTypeId { get; set; }
        public string Notes { get; set; }
        public bool? AutoAddToNewCalcs { get; set; }
        public bool AddedFromHeader { get; set; }
        public ProjectEntity Project { get; set; }
        public ProjectRelationEntity ProjectRelation { get; set; }
             
        partial void InitializePartial();
    }
}
