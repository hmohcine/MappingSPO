
namespace MappingSPO.Entities
{
    public partial class EmmaTextGroupEntity
    {
		public EmmaTextGroupEntity()
        {
            GroupType = 0;
            EmmaTextens = new System.Collections.Generic.List<EmmaTextenEntity>();
            InitializePartial();
		}

        public long GroupId { get; set; }
        public string GroupName { get; set; }
        public byte GroupType { get; set; }
        public System.Collections.Generic.ICollection<EmmaTextenEntity> EmmaTextens { get; set; }
             
        partial void InitializePartial();
    }
}
