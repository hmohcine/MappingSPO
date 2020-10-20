
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcPropertyEntity
    {
		public CalcPropertyEntity()
        {
            InitializePartial();
		}

        public long CalcId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyValue { get; set; }
        public CalculationEntity Calculation { get; set; }
             
        partial void InitializePartial();
    }
}
