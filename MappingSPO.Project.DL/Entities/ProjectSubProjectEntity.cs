
namespace MappingSPO.Project.DL.Entities
{
    public partial class ProjectSubProjectEntity
    {
		public ProjectSubProjectEntity()
        {
            InitializePartial();
		}

        public long MasterProjectId { get; set; }
        public string MasterProjectType { get; set; }
        public long SubProjectId { get; set; }
        public string SubProjectType { get; set; }
        public int LineOrder { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public ProjectEntity MasterProject { get; set; }
        public ProjectEntity SubProject { get; set; }
             
        partial void InitializePartial();
    }
}
