
namespace MappingSPO.Entities
{
    public partial class ProjectResultReasonEntity
    {
		public ProjectResultReasonEntity()
        {
            Disabled = false;
            InitializePartial();
		}

        public int ProjectResultReasonId { get; set; }
        public string ProjectResultReason_ { get; set; }
        public bool Disabled { get; set; }
             
        partial void InitializePartial();
    }
}
