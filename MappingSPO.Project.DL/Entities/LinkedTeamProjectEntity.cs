
namespace MappingSPO.Project.DL.Entities
{
    public partial class LinkedTeamProjectEntity
    {
		public LinkedTeamProjectEntity()
        {
            ProjectNumberText = "";
            SharePointUrl = "";
            TeamsUrl = "";
            TeamsStatus = "";
            SyncDate = System.DateTime.Now;
            CreationDate = System.DateTime.Now;
            ModificationDate = System.DateTime.Now;
            CreatedBy = "user_name(user_id())";
            ModifiedBy = "user_name(user_id())";
            ProjectTitle = "";
            InitializePartial();
		}

        public long LinkedTeamProjectId { get; set; }
        public long ProjectId { get; set; }
        public string ProjectType { get; set; }
        public string ProjectNumberText { get; set; }
        public string SharePointUrl { get; set; }
        public string TeamsUrl { get; set; }
        public string TeamsStatus { get; set; }
        public long LookupId { get; set; }
        public System.DateTime? SyncDate { get; set; }
        public System.DateTime? CreationDate { get; set; }
        public System.DateTime? ModificationDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string ProjectTitle { get; set; }
        public ProjectEntity Project { get; set; }
             
        partial void InitializePartial();
    }
}
