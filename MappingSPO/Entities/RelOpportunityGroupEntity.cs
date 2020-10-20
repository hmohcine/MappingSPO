
namespace MappingSPO.Entities
{
    public partial class RelOpportunityGroupEntity
    {
		public RelOpportunityGroupEntity()
        {
            RelOpportunities = new System.Collections.Generic.List<RelOpportunityEntity>();
            InitializePartial();
		}

        public long OppGroupId { get; set; }
        public string OppGroup { get; set; }
        public System.Collections.Generic.ICollection<RelOpportunityEntity> RelOpportunities { get; set; }
             
        partial void InitializePartial();
    }
}
