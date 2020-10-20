
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalculationVersionEntity
    {
		public CalculationVersionEntity()
        {
            InitializePartial();
		}

        public long OriginalCalcId { get; set; }
        public long VersionCalcId { get; set; }
        public int VersieNr { get; set; }
        public string Opmerking { get; set; }
        public string Notes { get; set; }
        public CalculationEntity OriginalCalc { get; set; }
        public CalculationEntity VersionCalc { get; set; }
             
        partial void InitializePartial();
    }
}
