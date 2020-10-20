
namespace MappingSPO.Entities
{
    public partial class EmmaAddinContractEntity
    {
		public EmmaAddinContractEntity()
        {
            Number = 1;
            EmmaAddinContractsSecurities = new System.Collections.Generic.List<EmmaAddinContractsSecurityEntity>();
            InitializePartial();
		}

        public long AddinId { get; set; }
        public long ContractId { get; set; }
        public int Number { get; set; }
        public int SecurityMode { get; set; }
        public bool Enabled { get; set; }
        public System.Collections.Generic.ICollection<EmmaAddinContractsSecurityEntity> EmmaAddinContractsSecurities { get; set; }
        public EmmaAddinEntity EmmaAddin { get; set; }
             
        partial void InitializePartial();
    }
}
