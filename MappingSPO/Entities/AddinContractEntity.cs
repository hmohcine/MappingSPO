
namespace MappingSPO.Entities
{
    public partial class AddinContractEntity
    {
		public AddinContractEntity()
        {
            Number = 1;
            AddinContractsSecurities = new System.Collections.Generic.List<AddinContractsSecurityEntity>();
            InitializePartial();
		}

        public long AddinId { get; set; }
        public long ContractId { get; set; }
        public int Number { get; set; }
        public int SecurityMode { get; set; }
        public bool Enabled { get; set; }
        public System.Collections.Generic.ICollection<AddinContractsSecurityEntity> AddinContractsSecurities { get; set; }
        public AddinEntity Addin { get; set; }
             
        partial void InitializePartial();
    }
}
