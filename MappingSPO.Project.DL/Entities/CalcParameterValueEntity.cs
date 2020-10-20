
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcParameterValueEntity
    {
		public CalcParameterValueEntity()
        {
            InitializePartial();
		}

        public long CalcId { get; set; }
        public string ParameterName { get; set; }
        public double? Value { get; set; }
        public CalculationEntity Calculation { get; set; }
        public ParameterDefinitionEntity ParameterDefinition { get; set; }
             
        partial void InitializePartial();
    }
}
