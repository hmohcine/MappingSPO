
namespace MappingSPO.Entities
{
    public partial class SysUserFilterEntity
    {
		public SysUserFilterEntity()
        {
            IsDefault = false;
            InitializePartial();
		}

        public long Id { get; set; }
        public long UserId { get; set; }
        public string ObjectName { get; set; }
        public string Description { get; set; }
        public string Filter { get; set; }
        public bool IsDefault { get; set; }
        public bool? IsShared { get; set; }
             
        partial void InitializePartial();
    }
}
