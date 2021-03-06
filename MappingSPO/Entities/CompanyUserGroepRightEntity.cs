
namespace MappingSPO.Entities
{
    public partial class CompanyUserGroepRightEntity
    {
		public CompanyUserGroepRightEntity()
        {
            InitializePartial();
		}

        public int CompanyId { get; set; }
        public int UserGroupId { get; set; }
        public bool PayrollAdminYn { get; set; }
        public CompanyEntity Company { get; set; }
        public UsersGroepEntity UsersGroep { get; set; }
             
        partial void InitializePartial();
    }
}
