
namespace MappingSPO.Entities
{
    public partial class ParitairComiteEntity
    {
		public ParitairComiteEntity()
        {
            ParitairComiteCounters = new System.Collections.Generic.List<ParitairComiteCounterEntity>();
            InitializePartial();
		}

        public long ParitairComiteId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public System.Collections.Generic.ICollection<ParitairComiteCounterEntity> ParitairComiteCounters { get; set; }
             
        partial void InitializePartial();
    }
}
