
namespace MappingSPO.Entities
{
    public partial class ProjectTypeUserEntity
    {
		public ProjectTypeUserEntity()
        {
            IsManager = false;
            CanChangeItems = false;
            InitializePartial();
		}

        public string ProjectType { get; set; }
        public int UserId { get; set; }
        public bool IsManager { get; set; }
        public bool CanChangeItems { get; set; }
        public ProjectTypeEntity ProjectType_ProjectType { get; set; }
        public UserEntity User { get; set; }
             
        partial void InitializePartial();
    }
}
