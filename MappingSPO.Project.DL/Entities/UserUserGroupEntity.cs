
namespace MappingSPO.Project.DL.Entities
{
    public partial class UserUserGroupEntity
    {
		public UserUserGroupEntity()
        {
            InitializePartial();
		}

        public int UserId { get; set; }
        public int UserGroupId { get; set; }
        public UsersGroepEntity UsersGroep { get; set; }
             
        partial void InitializePartial();
    }
}
