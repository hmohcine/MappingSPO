
namespace MappingSPO.Entities
{
    public partial class BAnaCodeEntity
    {
		public BAnaCodeEntity()
        {
            Relations = new System.Collections.Generic.List<RelationEntity>();
            InitializePartial();
		}

        public long AnaCodeId { get; set; }
        public long SubGroupId { get; set; }
        public string Name { get; set; }
        public int AnaMode { get; set; }
        public System.Collections.Generic.ICollection<RelationEntity> Relations { get; set; }
        public BAnaSubGroupEntity BAnaSubGroup { get; set; }
             
        partial void InitializePartial();
    }
}
