
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcLogbookEntity
    {
		public CalcLogbookEntity()
        {
            InitializePartial();
		}

        public long CalcId { get; set; }
        public int VolgNr { get; set; }
        public System.DateTime Date { get; set; }
        public int UserId { get; set; }
        public string AppLog { get; set; }
        public string CustomLog { get; set; }
        public CalculationEntity Calculation { get; set; }
             
        partial void InitializePartial();
    }
}
