
namespace MappingSPO.Entities
{
    public partial class WorkerContractTypeEntity
    {
		public WorkerContractTypeEntity()
        {
            VoorschotBerekenenYn = false;
            InitializePartial();
		}

        public long ContractTypeId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool DefaultExportSocSecYn { get; set; }
        public bool DefaultExportPlanningYn { get; set; }
        public bool DefaultExportTrackAndTraceYn { get; set; }
        public bool DefaultExportBuildMobileYn { get; set; }
        public bool VoorschotBerekenenYn { get; set; }
             
        partial void InitializePartial();
    }
}
