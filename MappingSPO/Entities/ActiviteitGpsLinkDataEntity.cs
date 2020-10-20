
namespace MappingSPO.Entities
{
    public partial class ActiviteitGpsLinkDataEntity
    {
		public ActiviteitGpsLinkDataEntity()
        {
            InitializePartial();
		}

        public long ActiviteitId { get; set; }
        public string ActiviteitKey { get; set; }
        public string ExternalKey { get; set; }
        public System.DateTime LastUpdated { get; set; }
             
        partial void InitializePartial();
    }
}
