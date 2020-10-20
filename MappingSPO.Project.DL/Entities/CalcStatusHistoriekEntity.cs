
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcStatusHistoriekEntity
    {
		public CalcStatusHistoriekEntity()
        {
            InitializePartial();
		}

        public long CalcId { get; set; }
        public System.DateTime DateChanged { get; set; }
        public int? OldStatus { get; set; }
        public int? CalcStatus { get; set; }
        public int? WhoChanged { get; set; }
        public string Notes { get; set; }
        public CalculationEntity Calculation { get; set; }
             
        partial void InitializePartial();
    }
}
