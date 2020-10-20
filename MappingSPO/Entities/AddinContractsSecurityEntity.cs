
namespace MappingSPO.Entities
{
    public partial class AddinContractsSecurityEntity
    {
		public AddinContractsSecurityEntity()
        {
            InitializePartial();
		}

        public long ContractId { get; set; }
        public int Number { get; set; }
        public int UserGroupId { get; set; }
        public AddinContractEntity AddinContract { get; set; }
        public UsersGroepEntity UsersGroep { get; set; }
             
        partial void InitializePartial();
    }
}
