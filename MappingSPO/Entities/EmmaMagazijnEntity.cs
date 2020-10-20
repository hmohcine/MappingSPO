
namespace MappingSPO.Entities
{
    public partial class EmmaMagazijnEntity
    {
		public EmmaMagazijnEntity()
        {
            InitializePartial();
		}

        public long MagazijnId { get; set; }
        public byte MagazijnType { get; set; }
        public string MagazijnName { get; set; }
        public string AdressLine1 { get; set; }
        public string AdressLine2 { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string StreetCode { get; set; }
        public string CountryCode { get; set; }
        public string Country { get; set; }
        public string OpeningsUren { get; set; }
        public string Afkorting { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string Email1 { get; set; }
        public string MagazijnierName { get; set; }
        public string MagazijnierGsm { get; set; }
        public bool? IsKlantMagazijnYn { get; set; }
        public long? OwnerArticles { get; set; }
        public long? DeliveryAdressMagazijn { get; set; }
        public RelationEntity Relation_DeliveryAdressMagazijn { get; set; }
        public RelationEntity Relation_OwnerArticles { get; set; }
             
        partial void InitializePartial();
    }
}
