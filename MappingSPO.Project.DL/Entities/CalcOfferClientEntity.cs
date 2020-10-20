
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcOfferClientEntity
    {
		public CalcOfferClientEntity()
        {
            InitializePartial();
		}

        public long CalcId { get; set; }
        public int RelationTypeId { get; set; }
        public long RelationId { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string AdressLine1 { get; set; }
        public string AdressLine2 { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string StreetCode { get; set; }
        public string CountryCode { get; set; }
        public string Language { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Website { get; set; }
        public System.DateTime? LastUpdated { get; set; }
        public string OnNumber { get; set; }
        public string Rpr { get; set; }
        public string RegNr { get; set; }
        public string ContactTitle { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public System.DateTime? ContactLastUpdated { get; set; }
        public string ContactGsm { get; set; }
        public string ContactAanhef { get; set; }
        public CalculationEntity Calculation { get; set; }
             
        partial void InitializePartial();
    }
}
