
namespace MappingSPO.Entities
{
    public partial class TeamsIntegrationEntity
    {
		public TeamsIntegrationEntity()
        {
            CreationDate = System.DateTime.Now;
            ModificationDate = System.DateTime.Now;
            CreatedBy = "user_name(user_id())";
            ModifiedBy = "user_name(user_id())";
            AffectedUsers = "";
            InitializePartial();
		}

        public long TeamIntegrateId { get; set; }
        public string SharePointUrl { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public System.DateTime? CreationDate { get; set; }
        public System.DateTime? ModificationDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string AffectedUsers { get; set; }
             
        partial void InitializePartial();
    }
}
