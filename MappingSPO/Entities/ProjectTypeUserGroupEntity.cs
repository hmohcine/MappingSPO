
namespace MappingSPO.Entities
{
    public partial class ProjectTypeUserGroupEntity
    {
		public ProjectTypeUserGroupEntity()
        {
            CanChangeItems = false;
            IsManager = false;
            InitializePartial();
		}

        public string ProjectType { get; set; }
        public int UserGroupId { get; set; }
        public bool CanChangeItems { get; set; }
        public bool IsManager { get; set; }
        public ProjectTypeEntity ProjectType_ProjectType { get; set; }
        public UsersGroepEntity UsersGroep { get; set; }
             
        partial void InitializePartial();
    }
}
