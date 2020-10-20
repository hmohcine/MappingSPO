
namespace MappingSPO.Entities
{
    public partial class CompanyUserRightEntity
    {
		public CompanyUserRightEntity()
        {
            InitializePartial();
		}

        public int CompanyId { get; set; }
        public int UserId { get; set; }
        public bool PayrollAdminYn { get; set; }
        public CompanyEntity Company { get; set; }
        public UserEntity User { get; set; }
             
        partial void InitializePartial();
    }
}
