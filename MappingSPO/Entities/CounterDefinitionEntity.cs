
namespace MappingSPO.Entities
{
    public partial class CounterDefinitionEntity
    {
		public CounterDefinitionEntity()
        {
            Disabled = false;
            CounterWerkCodes = new System.Collections.Generic.List<CounterWerkCodeEntity>();
            ParitairComiteCounters = new System.Collections.Generic.List<ParitairComiteCounterEntity>();
            WorkOrderTimeItemsCounters = new System.Collections.Generic.List<WorkOrderTimeItemsCounterEntity>();
            InitializePartial();
		}

        public long CounterId { get; set; }
        public string CounterName { get; set; }
        public System.DateTime? RestartDate { get; set; }
        public int? MaxOverTimeYear { get; set; }
        public int MasterType { get; set; }
        public bool Disabled { get; set; }
        public int? ValidDays { get; set; }
        public decimal? MaxPlusTimeOnDay { get; set; }
        public System.Collections.Generic.ICollection<CounterWerkCodeEntity> CounterWerkCodes { get; set; }
        public System.Collections.Generic.ICollection<ParitairComiteCounterEntity> ParitairComiteCounters { get; set; }
        public System.Collections.Generic.ICollection<WorkOrderTimeItemsCounterEntity> WorkOrderTimeItemsCounters { get; set; }
             
        partial void InitializePartial();
    }
}
