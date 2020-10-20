
namespace MappingSPO.Project.DL.Entities
{
    public partial class WerfActiviteitenLinkDataEntity
    {
		public WerfActiviteitenLinkDataEntity()
        {
            InitializePartial();
		}

        public string Source { get; set; }
        public long WerfId { get; set; }
        public long ActiviteitId { get; set; }
        public string ExternalId { get; set; }
             
        partial void InitializePartial();
    }
}
