
namespace MappingSPO.Entities
{
    public partial class SysUserSettingUserObjectEntity
    {
		public SysUserSettingUserObjectEntity()
        {
            InitializePartial();
		}

        public long ObjectId { get; set; }
        public int UserId { get; set; }
        public string UserDefault { get; set; }
        public bool ViewsActive { get; set; }
        public string UserDefaultViews { get; set; }
        public SysUserSettingObjectEntity SysUserSettingObject { get; set; }
        public UserEntity User { get; set; }
             
        partial void InitializePartial();
    }
}
