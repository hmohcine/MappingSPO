
namespace MappingSPO.Entities
{
    public partial class BatchJobEntity
    {
		public BatchJobEntity()
        {
            JobId = 0;
            RecurrencyType = 1;
            Enabled = false;
            IsRunning = false;
            BatchJobParameters = new System.Collections.Generic.List<BatchJobParameterEntity>();
            InitializePartial();
		}

        public long BatchJobId { get; set; }
        public int JobId { get; set; }
        public string Description { get; set; }
        public System.DateTime? StartTime { get; set; }
        public System.DateTime? EndTime { get; set; }
        public int? RecurrencyType { get; set; }
        public string WhichDays { get; set; }
        public int? IntervalMinutes { get; set; }
        public System.DateTime? LastRunDate { get; set; }
        public System.DateTime? NextRunDate { get; set; }
        public int? LastRunDuration { get; set; }
        public bool Enabled { get; set; }
        public bool IsRunning { get; set; }
        public System.Collections.Generic.ICollection<BatchJobParameterEntity> BatchJobParameters { get; set; }
             
        partial void InitializePartial();
    }
}
