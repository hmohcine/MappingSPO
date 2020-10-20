
namespace MappingSPO.Entities
{
    public partial class BAnaGroup1Entity
    {
		public BAnaGroup1Entity()
        {
            BAnaSubGroups = new System.Collections.Generic.List<BAnaSubGroupEntity>();
            InitializePartial();
		}

        public long GroupId { get; set; }
        public string GroupName { get; set; }
        public System.Collections.Generic.ICollection<BAnaSubGroupEntity> BAnaSubGroups { get; set; }
             
        partial void InitializePartial();
    }
}
