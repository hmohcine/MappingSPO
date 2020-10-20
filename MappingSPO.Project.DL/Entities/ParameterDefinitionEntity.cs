
namespace MappingSPO.Project.DL.Entities
{
    public partial class ParameterDefinitionEntity
    {
		public ParameterDefinitionEntity()
        {
            CalcDetailParameterValues = new System.Collections.Generic.List<CalcDetailParameterValueEntity>();
            CalcParameterValues = new System.Collections.Generic.List<CalcParameterValueEntity>();
            InitializePartial();
		}

        public string ParameterName { get; set; }
        public string Uc { get; set; }
        public string Description { get; set; }
        public long? BibId { get; set; }
        public System.Collections.Generic.ICollection<CalcDetailParameterValueEntity> CalcDetailParameterValues { get; set; }
        public System.Collections.Generic.ICollection<CalcParameterValueEntity> CalcParameterValues { get; set; }
        public ParameterBibEntity ParameterBib { get; set; }
             
        partial void InitializePartial();
    }
}
