
namespace MappingSPO.Entities
{
    public partial class RelActiviteitGroupEntity
    {
		public RelActiviteitGroupEntity()
        {
            ShowAsMode = 0;
            RelActiviteits = new System.Collections.Generic.List<RelActiviteitEntity>();
            InitializePartial();
		}

        public long ActGroupId { get; set; }
        public string ActGroup { get; set; }
        public string ShowAs { get; set; }
        public string Code { get; set; }
        public int ShowAsMode { get; set; }
        public int? CatType { get; set; }
        public System.Collections.Generic.ICollection<RelActiviteitEntity> RelActiviteits { get; set; }
             
        partial void InitializePartial();
    }
}
