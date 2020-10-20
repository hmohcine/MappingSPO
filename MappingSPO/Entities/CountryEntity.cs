
namespace MappingSPO.Entities
{
    public partial class CountryEntity
    {
		public CountryEntity()
        {
            Cities = new System.Collections.Generic.List<CityEntity>();
            Companies = new System.Collections.Generic.List<CompanyEntity>();
            Contacts = new System.Collections.Generic.List<ContactEntity>();
            CountriesLinkDatas = new System.Collections.Generic.List<CountriesLinkDataEntity>();
            CountryLanguages = new System.Collections.Generic.List<CountryLanguageEntity>();
            Employees = new System.Collections.Generic.List<EmployeeEntity>();
            ExportVatSettings = new System.Collections.Generic.List<ExportVatSettingEntity>();
            InvoiceExports = new System.Collections.Generic.List<InvoiceExportEntity>();
            Magazijns = new System.Collections.Generic.List<MagazijnEntity>();
            Relations = new System.Collections.Generic.List<RelationEntity>();
            InitializePartial();
		}

        public string CountryCode { get; set; }
        public string Country_ { get; set; }
        public bool? Activated { get; set; }
        public string Nationality { get; set; }
        public string ExterneCode1 { get; set; }
        public string ExterneCode2 { get; set; }
        public string IsoCode2 { get; set; }
        public string IsoCode3 { get; set; }
        public System.Collections.Generic.ICollection<CityEntity> Cities { get; set; }
        public System.Collections.Generic.ICollection<CompanyEntity> Companies { get; set; }
        public System.Collections.Generic.ICollection<ContactEntity> Contacts { get; set; }
        public System.Collections.Generic.ICollection<CountriesLinkDataEntity> CountriesLinkDatas { get; set; }
        public System.Collections.Generic.ICollection<CountryLanguageEntity> CountryLanguages { get; set; }
        public System.Collections.Generic.ICollection<EmployeeEntity> Employees { get; set; }
        public System.Collections.Generic.ICollection<ExportVatSettingEntity> ExportVatSettings { get; set; }
        public System.Collections.Generic.ICollection<InvoiceExportEntity> InvoiceExports { get; set; }
        public System.Collections.Generic.ICollection<MagazijnEntity> Magazijns { get; set; }
        public System.Collections.Generic.ICollection<RelationEntity> Relations { get; set; }
             
        partial void InitializePartial();
    }
}
