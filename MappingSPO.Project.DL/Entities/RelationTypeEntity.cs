
namespace MappingSPO.Project.DL.Entities
{
    public partial class RelationTypeEntity
    {
		public RelationTypeEntity()
        {
            UseInWorkerContract = false;
            UseForShareAtWork = false;
            CalcRelations = new System.Collections.Generic.List<CalcRelationEntity>();
            Projects = new System.Collections.Generic.List<ProjectEntity>();
            ProjectRelations = new System.Collections.Generic.List<ProjectRelationEntity>();
            WerfRelations = new System.Collections.Generic.List<WerfRelationEntity>();
            InitializePartial();
		}

        public int RelationTypeId { get; set; }
        public string RelationType_ { get; set; }
        public int? MasterType { get; set; }
        public byte[] Timestamp { get; set; }
        public bool? RequiredForWerf { get; set; }
        public string ShortName { get; set; }
        public bool UseInWorkerContract { get; set; }
        public bool UseForShareAtWork { get; set; }
        public System.Collections.Generic.ICollection<CalcRelationEntity> CalcRelations { get; set; }
        public System.Collections.Generic.ICollection<ProjectEntity> Projects { get; set; }
        public System.Collections.Generic.ICollection<ProjectRelationEntity> ProjectRelations { get; set; }
        public System.Collections.Generic.ICollection<WerfRelationEntity> WerfRelations { get; set; }
             
        partial void InitializePartial();
    }
}
