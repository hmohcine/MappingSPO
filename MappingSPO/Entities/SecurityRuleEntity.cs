
namespace MappingSPO.Entities
{
    public partial class SecurityRuleEntity
    {
		public SecurityRuleEntity()
        {
            InitializePartial();
		}

        public long RuleId { get; set; }
        public string RuleNr { get; set; }
        public string RuleDomain { get; set; }
        public string RuleName { get; set; }
             
        partial void InitializePartial();
    }
}
