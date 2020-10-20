
namespace MappingSPO.Entities
{
    public partial class SysUserSettingObjectEntity
    {
		public SysUserSettingObjectEntity()
        {
            SysUserSettingUserObjects = new System.Collections.Generic.List<SysUserSettingUserObjectEntity>();
            InitializePartial();
		}

        public long ObjectId { get; set; }
        public string ObjectName { get; set; }
        public string CompanyDefault { get; set; }
        public bool ViewsActive { get; set; }
        public string CompanyDefaultViews { get; set; }
        public System.Collections.Generic.ICollection<SysUserSettingUserObjectEntity> SysUserSettingUserObjects { get; set; }
             
        partial void InitializePartial();
    }
}
