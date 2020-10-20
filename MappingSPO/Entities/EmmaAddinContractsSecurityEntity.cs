
namespace MappingSPO.Entities
{
    public partial class EmmaAddinContractsSecurityEntity
    {
		public EmmaAddinContractsSecurityEntity()
        {
            InitializePartial();
		}

        public long ContractId { get; set; }
        public int Number { get; set; }
        public int UserGroupId { get; set; }
        public EmmaAddinContractEntity EmmaAddinContract { get; set; }
        public UsersGroepEntity UsersGroep { get; set; }
             
        partial void InitializePartial();
    }
}
