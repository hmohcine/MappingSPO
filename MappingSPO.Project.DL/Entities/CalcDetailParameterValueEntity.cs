
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcDetailParameterValueEntity
    {
		public CalcDetailParameterValueEntity()
        {
            InitializePartial();
		}

        public long CalcDetailId { get; set; }
        public long CalcId { get; set; }
        public string ParameterName { get; set; }
        public double? Value { get; set; }
        public CalcDetailEntity CalcDetail { get; set; }
        public ParameterDefinitionEntity ParameterDefinition { get; set; }
             
        partial void InitializePartial();
    }
}
