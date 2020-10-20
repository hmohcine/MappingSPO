
namespace MappingSPO.Project.DL.Entities
{
    public partial class ParameterBibEntity
    {
		public ParameterBibEntity()
        {
            ParameterDefinitions = new System.Collections.Generic.List<ParameterDefinitionEntity>();
            InitializePartial();
		}

        public long BibId { get; set; }
        public long? ParentId { get; set; }
        public string Naam { get; set; }
        public string Notes { get; set; }
        public System.Collections.Generic.ICollection<ParameterDefinitionEntity> ParameterDefinitions { get; set; }
             
        partial void InitializePartial();
    }
}
