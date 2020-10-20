
namespace MappingSPO.Entities
{
    public partial class CountriesLinkDataEntity
    {
		public CountriesLinkDataEntity()
        {
            InitializePartial();
		}

        public string Source { get; set; }
        public string CountryCode { get; set; }
        public long? ExternalId { get; set; }
        public CountryEntity Country { get; set; }
             
        partial void InitializePartial();
    }
}
