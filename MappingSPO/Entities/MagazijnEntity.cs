
namespace MappingSPO.Entities
{
    public partial class MagazijnEntity
    {
		public MagazijnEntity()
        {
            BColor = -16777216;
            ShowInGrid = false;
            IsWerfMagazijn = false;
            IsVirtualMagazijn = false;
            OverNemenVanWerfAdres = false;
            InitializePartial();
		}

        public long MagazijnId { get; set; }
        public string Magazijn_ { get; set; }
        public string AdressLine1 { get; set; }
        public string AdressLine2 { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string StreetCode { get; set; }
        public string CountryCode { get; set; }
        public string Country { get; set; }
        public string OpeningsUren { get; set; }
        public string Afkorting { get; set; }
        public int? GridPosition { get; set; }
        public int? BColor { get; set; }
        public bool ShowInGrid { get; set; }
        public int? MagazijnierId { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string Email1 { get; set; }
        public bool IsWerfMagazijn { get; set; }
        public bool IsVirtualMagazijn { get; set; }
        public long? RealMagazijnId { get; set; }
        public bool OverNemenVanWerfAdres { get; set; }
        public CountryEntity Country_CountryCode { get; set; }
        public EmployeeEntity Employee { get; set; }
             
        partial void InitializePartial();
    }
}
