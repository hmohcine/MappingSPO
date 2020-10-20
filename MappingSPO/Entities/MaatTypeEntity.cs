
namespace MappingSPO.Entities
{
    public partial class MaatTypeEntity
    {
		public MaatTypeEntity()
        {
            OpmetingDefinitions_MaatType1 = new System.Collections.Generic.List<OpmetingDefinitionEntity>();
            OpmetingDefinitions_MaatType2 = new System.Collections.Generic.List<OpmetingDefinitionEntity>();
            OpmetingDefinitions_MaatType3 = new System.Collections.Generic.List<OpmetingDefinitionEntity>();
            OpmetingDefinitions_MaatType4 = new System.Collections.Generic.List<OpmetingDefinitionEntity>();
            OpmetingDefinitions_MaatType5 = new System.Collections.Generic.List<OpmetingDefinitionEntity>();
            OpmetingDefinitions_MaatType6 = new System.Collections.Generic.List<OpmetingDefinitionEntity>();
            InitializePartial();
		}

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string DefaultUc { get; set; }
        public System.Collections.Generic.ICollection<OpmetingDefinitionEntity> OpmetingDefinitions_MaatType1 { get; set; }
        public System.Collections.Generic.ICollection<OpmetingDefinitionEntity> OpmetingDefinitions_MaatType2 { get; set; }
        public System.Collections.Generic.ICollection<OpmetingDefinitionEntity> OpmetingDefinitions_MaatType3 { get; set; }
        public System.Collections.Generic.ICollection<OpmetingDefinitionEntity> OpmetingDefinitions_MaatType4 { get; set; }
        public System.Collections.Generic.ICollection<OpmetingDefinitionEntity> OpmetingDefinitions_MaatType5 { get; set; }
        public System.Collections.Generic.ICollection<OpmetingDefinitionEntity> OpmetingDefinitions_MaatType6 { get; set; }
             
        partial void InitializePartial();
    }
}
