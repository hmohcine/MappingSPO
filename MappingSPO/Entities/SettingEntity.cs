
namespace MappingSPO.Entities
{
    public partial class SettingEntity
    {
		public SettingEntity()
        {
            Enabled = false;
            Settings = new System.Collections.Generic.List<SettingEntity>();
            UsersGroeps = new System.Collections.Generic.List<UsersGroepEntity>();
            InitializePartial();
		}

        public int Id { get; set; }
        public string Code { get; set; }
        public string Caption { get; set; }
        public int? ParentId { get; set; }
        public int OldSecurityLevel { get; set; }
        public int Sequence { get; set; }
        public string UserControlName { get; set; }
        public bool Enabled { get; set; }
        public System.Collections.Generic.ICollection<SettingEntity> Settings { get; set; }
        public System.Collections.Generic.ICollection<UsersGroepEntity> UsersGroeps { get; set; }
        public SettingEntity Parent { get; set; }
             
        partial void InitializePartial();
    }
}
