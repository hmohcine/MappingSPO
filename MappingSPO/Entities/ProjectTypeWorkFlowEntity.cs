
namespace MappingSPO.Entities
{
    public partial class ProjectTypeWorkFlowEntity
    {
		public ProjectTypeWorkFlowEntity()
        {
            InitializePartial();
		}

        public string ProjectType { get; set; }
        public long WorkflowId { get; set; }
        public bool InitialWorkflowYn { get; set; }
        public int WorkflowOrder { get; set; }
        public ProjectTypeEntity ProjectType_ProjectType { get; set; }
        public WorkFlowEntity WorkFlow { get; set; }
             
        partial void InitializePartial();
    }
}
