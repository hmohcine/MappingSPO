
namespace MappingSPO.Entities
{
    public partial class WorkOrderTypeAfdelingEntity
    {
		public WorkOrderTypeAfdelingEntity()
        {
            InitializePartial();
		}

        public long WorkOrderTypeId { get; set; }
        public long AfdelingId { get; set; }
        public int LastChangedBy { get; set; }
        public System.DateTime LastChangedDate { get; set; }
        public AfdelingEntity Afdeling { get; set; }
        public UserEntity User { get; set; }
        public WorkOrderTypeEntity WorkOrderType { get; set; }
             
        partial void InitializePartial();
    }
}
