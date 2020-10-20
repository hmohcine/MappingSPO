
namespace MappingSPO.Entities
{
    public partial class CountryLanguageEntity
    {
		public CountryLanguageEntity()
        {
            InitializePartial();
		}

        public string CountryCode { get; set; }
        public string Code { get; set; }
        public string Country { get; set; }
        public CountryEntity Country_CountryCode { get; set; }
        public LanguageEntity Language { get; set; }
             
        partial void InitializePartial();
    }
}
