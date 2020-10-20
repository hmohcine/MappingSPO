
namespace MappingSPO.Project.DL.Entities
{
    public partial class ProjectWerfEntity
    {
		public ProjectWerfEntity()
        {
            TypeWerf = 0;
            InitializePartial();
		}

        public long ProjectId { get; set; }
        public string ProjectType { get; set; }
        public long WerfId { get; set; }
        public bool IncludeInSum { get; set; }
        public bool IncludeInXrm { get; set; }
        public string Notes { get; set; }
        public int LineOrder { get; set; }
        public int TypeWerf { get; set; }
        public ProjectEntity Project { get; set; }
        public WerfEntity Werf { get; set; }
             
        partial void InitializePartial();
    }
}
