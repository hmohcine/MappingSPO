
namespace MappingSPO.Entities
{
    public partial class WorkFlowEntity
    {
		public WorkFlowEntity()
        {
            Type = 1;
            WfGuid = System.Guid.NewGuid();
            ProjectWorkflow = false;
            ShowInSearchCombo = true;
            Disabled = false;
            ProjectTypeWorkFlows = new System.Collections.Generic.List<ProjectTypeWorkFlowEntity>();
            WorkFlows = new System.Collections.Generic.List<WorkFlowEntity>();
            InitializePartial();
		}

        public long WorkflowId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public int Type { get; set; }
        public int UpdatedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid WfGuid { get; set; }
        public bool ProjectWorkflow { get; set; }
        public long? OriginalWorkFlowId { get; set; }
        public bool ShowInSearchCombo { get; set; }
        public bool Disabled { get; set; }
        public System.Collections.Generic.ICollection<ProjectTypeWorkFlowEntity> ProjectTypeWorkFlows { get; set; }
        public System.Collections.Generic.ICollection<WorkFlowEntity> WorkFlows { get; set; }
        public UserEntity User_CreatedBy { get; set; }
        public UserEntity User_UpdatedBy { get; set; }
        public WorkFlowEntity OriginalWorkFlow { get; set; }
             
        partial void InitializePartial();
    }
}
