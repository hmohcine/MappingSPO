
namespace MappingSPO.Entities
{
    public partial class EmmaAddinEntity
    {
		public EmmaAddinEntity()
        {
            EmmaAddinContracts = new System.Collections.Generic.List<EmmaAddinContractEntity>();
            InitializePartial();
		}

        public long AddinId { get; set; }
        public string AddinName { get; set; }
        public string FullPath { get; set; }
        public bool Trusted { get; set; }
        public bool Enabled { get; set; }
        public System.Collections.Generic.ICollection<EmmaAddinContractEntity> EmmaAddinContracts { get; set; }
             
        partial void InitializePartial();
    }
}
