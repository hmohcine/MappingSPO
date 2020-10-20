
namespace MappingSPO.Entities
{
    public partial class WorkOrderTypeEntity
    {
		public WorkOrderTypeEntity()
        {
            WorkOrderTypeAfdelings = new System.Collections.Generic.List<WorkOrderTypeAfdelingEntity>();
            InitializePartial();
		}

        public long WorkOrderTypeId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Mastertype { get; set; }
        public long? DefaultWerfId { get; set; }
        public string DefaultWerkCode { get; set; }
        public byte[] Icon { get; set; }
        public System.Collections.Generic.ICollection<WorkOrderTypeAfdelingEntity> WorkOrderTypeAfdelings { get; set; }
        public WerkCodeEntity WerkCode { get; set; }
             
        partial void InitializePartial();
    }
}
