
namespace MappingSPO.Project.DL.Entities
{
    public partial class WProjectRelationsDxEntity
    {
		public WProjectRelationsDxEntity()
        {
            InitializePartial();
		}

        public long ProjectId { get; set; }
        public string ProjectType { get; set; }
        public long RelationId { get; set; }
        public WMasterProjectExplorerDxEntity WMasterProjectExplorerDx { get; set; }
        public WProjectExplorerDxEntity WProjectExplorerDx { get; set; }
             
        partial void InitializePartial();
    }
}
