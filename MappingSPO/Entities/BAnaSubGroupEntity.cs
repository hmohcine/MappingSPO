
namespace MappingSPO.Entities
{
    public partial class BAnaSubGroupEntity
    {
		public BAnaSubGroupEntity()
        {
            BAnaCodes = new System.Collections.Generic.List<BAnaCodeEntity>();
            InitializePartial();
		}

        public long SubGroupId { get; set; }
        public long GroupId { get; set; }
        public string SubGroupName { get; set; }
        public System.Collections.Generic.ICollection<BAnaCodeEntity> BAnaCodes { get; set; }
        public BAnaGroup1Entity BAnaGroup1 { get; set; }
             
        partial void InitializePartial();
    }
}
