
namespace MappingSPO.Entities
{
    public partial class AddinEntity
    {
		public AddinEntity()
        {
            AddinContracts = new System.Collections.Generic.List<AddinContractEntity>();
            InitializePartial();
		}

        public long AddinId { get; set; }
        public string AddinName { get; set; }
        public string FullPath { get; set; }
        public bool Trusted { get; set; }
        public bool Enabled { get; set; }
        public System.Collections.Generic.ICollection<AddinContractEntity> AddinContracts { get; set; }
             
        partial void InitializePartial();
    }
}
