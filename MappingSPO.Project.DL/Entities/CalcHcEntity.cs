
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcHcEntity
    {
		public CalcHcEntity()
        {
            OverVorderenYn = -1;
            CalcDetails = new System.Collections.Generic.List<CalcDetailEntity>();
            InitializePartial();
		}

        public long CalcId { get; set; }
        public string CalcHc_ { get; set; }
        public short OverVorderenYn { get; set; }
        public System.Collections.Generic.ICollection<CalcDetailEntity> CalcDetails { get; set; }
        public CalculationEntity Calculation { get; set; }
             
        partial void InitializePartial();
    }
}
