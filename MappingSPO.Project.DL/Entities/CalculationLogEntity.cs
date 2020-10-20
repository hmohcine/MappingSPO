
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalculationLogEntity
    {
		public CalculationLogEntity()
        {
            Domain = "C";
            InitializePartial();
		}

        public long LogId { get; set; }
        public long CalcId { get; set; }
        public int UserId { get; set; }
        public byte LogType { get; set; }
        public System.DateTime TimeEntry { get; set; }
        public System.DateTime? TimeClose { get; set; }
        public string Info { get; set; }
        public string Domain { get; set; }
        public CalculationEntity Calculation { get; set; }
             
        partial void InitializePartial();
    }
}
