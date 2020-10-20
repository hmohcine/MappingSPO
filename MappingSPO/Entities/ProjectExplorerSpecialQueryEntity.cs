
namespace MappingSPO.Entities
{
    public partial class ProjectExplorerSpecialQueryEntity
    {
		public ProjectExplorerSpecialQueryEntity()
        {
            LineOrder = 0;
            Disabled = false;
            Domain = 1;
            InitializePartial();
		}

        public string Code { get; set; }
        public string Displayname { get; set; }
        public string Notes { get; set; }
        public string SqlStatement { get; set; }
        public long LineOrder { get; set; }
        public bool Disabled { get; set; }
        public int? UserGroupId { get; set; }
        public int Domain { get; set; }
             
        partial void InitializePartial();
    }
}
