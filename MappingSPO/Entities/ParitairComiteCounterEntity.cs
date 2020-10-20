
namespace MappingSPO.Entities
{
    public partial class ParitairComiteCounterEntity
    {
		public ParitairComiteCounterEntity()
        {
            InitializePartial();
		}

        public long ParitairComiteId { get; set; }
        public long CounterId { get; set; }
        public long PcCounterId { get; set; }
        public CounterDefinitionEntity CounterDefinition { get; set; }
        public ParitairComiteEntity ParitairComite { get; set; }
             
        partial void InitializePartial();
    }
}
