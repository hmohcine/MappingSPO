
namespace MappingSPO.Project.DL.Entities
{
    public partial class ProjectDocumentEntity
    {
		public ProjectDocumentEntity()
        {
            InitializePartial();
		}

        public long ProjectId { get; set; }
        public string ProjectType { get; set; }
        public long DocumentId { get; set; }
        public ProjectEntity Project { get; set; }
             
        partial void InitializePartial();
    }
}
