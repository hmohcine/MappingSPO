
namespace MappingSPO.Entities
{
    public partial class WorkOrderTimeItemsCounterEntity
    {
		public WorkOrderTimeItemsCounterEntity()
        {
            InitializePartial();
		}

        public long TimeItemId { get; set; }
        public long CounterId { get; set; }
        public int ValidDays { get; set; }
        public System.DateTime ValidUntilDate { get; set; }
        public int Mode { get; set; }
        public string WerkCode { get; set; }
        public long Id { get; set; }
        public CounterDefinitionEntity CounterDefinition { get; set; }
             
        partial void InitializePartial();
    }
}
