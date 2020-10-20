
namespace MappingSPO.Entities
{
    public partial class CityEntity
    {
		public CityEntity()
        {
            InitializePartial();
		}

        public int Id { get; set; }
        public string ZipCode { get; set; }
        public string City_ { get; set; }
        public string CountryCode { get; set; }
        public long? RegioId { get; set; }
        public CountryEntity Country { get; set; }
        public RegionEntity Region { get; set; }
             
        partial void InitializePartial();
    }
}
