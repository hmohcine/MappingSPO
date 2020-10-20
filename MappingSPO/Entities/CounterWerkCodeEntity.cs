
namespace MappingSPO.Entities
{
    public partial class CounterWerkCodeEntity
    {
		public CounterWerkCodeEntity()
        {
            InitializePartial();
		}

        public long CounterId { get; set; }
        public string WerkCode { get; set; }
        public int Mode { get; set; }
        public CounterDefinitionEntity CounterDefinition { get; set; }
        public WerkCodeEntity WerkCode_WerkCode { get; set; }
             
        partial void InitializePartial();
    }
}
