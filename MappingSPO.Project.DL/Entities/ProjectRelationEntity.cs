
namespace MappingSPO.Project.DL.Entities
{
    public partial class ProjectRelationEntity
    {
		public ProjectRelationEntity()
        {
            AddedFromHeader = false;
            ProjectRelationContacts = new System.Collections.Generic.List<ProjectRelationContactEntity>();
            InitializePartial();
		}

        public long ProjectId { get; set; }
        public string ProjectType { get; set; }
        public int RelationTypeId { get; set; }
        public long RelationId { get; set; }
        public int? DefaultContactId { get; set; }
        public string Notes { get; set; }
        public bool? AutoAddToNewCalcs { get; set; }
        public bool AddedFromHeader { get; set; }
        public System.Collections.Generic.ICollection<ProjectRelationContactEntity> ProjectRelationContacts { get; set; }
        public ProjectEntity Project { get; set; }
        public RelationEntity Relation { get; set; }
        public RelationTypeEntity RelationType { get; set; }
             
        partial void InitializePartial();
    }
}
