
namespace MappingSPO.Entities
{
    public partial class TodoTypeEntity
    {
		public TodoTypeEntity()
        {
            SyncToOutlookMode = 0;
            SysProjectUserSettings = new System.Collections.Generic.List<SysProjectUserSettingEntity>();
            TodoTypeItemStates = new System.Collections.Generic.List<TodoTypeItemStateEntity>();
            InitializePartial();
		}

        public long TodoTypeId { get; set; }
        public int DisplayNumber { get; set; }
        public string DisplayText { get; set; }
        public byte[] DisplayIcon { get; set; }
        public bool Disabled { get; set; }
        public int SyncToOutlookMode { get; set; }
        public int ToDoMasterType { get; set; }
        public System.Collections.Generic.ICollection<SysProjectUserSettingEntity> SysProjectUserSettings { get; set; }
        public System.Collections.Generic.ICollection<TodoTypeItemStateEntity> TodoTypeItemStates { get; set; }
             
        partial void InitializePartial();
    }
}
