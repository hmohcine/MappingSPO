
namespace MappingSPO.Entities
{
    public partial class RelOpportunityEntity
    {
		public RelOpportunityEntity()
        {
            Disabled = false;
            InitializePartial();
		}

        public long OpportunityId { get; set; }
        public string Description { get; set; }
        public long? OppGroupId { get; set; }
        public bool Disabled { get; set; }
        public RelOpportunityGroupEntity RelOpportunityGroup { get; set; }
             
        partial void InitializePartial();
    }
}
