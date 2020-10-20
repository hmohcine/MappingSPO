
namespace MappingSPO.Entities
{
    public partial class AfmeldingspuntenGpsLinkDataEntity
    {
		public AfmeldingspuntenGpsLinkDataEntity()
        {
            InitializePartial();
		}

        public long AfmpuntId { get; set; }
        public string AfmpuntKey { get; set; }
        public string ExternalKey { get; set; }
        public System.DateTime LastUpdated { get; set; }
             
        partial void InitializePartial();
    }
}
