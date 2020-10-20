
namespace MappingSPO.Entities
{
    public partial class EmployeeEntity
    {
		public EmployeeEntity()
        {
            LoonCostFromParentYn = true;
            EmmaAnaCode1 = new System.Collections.Generic.List<EmmaAnaCode1Entity>();
            EmmaAnaCode2 = new System.Collections.Generic.List<EmmaAnaCode2Entity>();
            EmmaAnaCode3 = new System.Collections.Generic.List<EmmaAnaCode3Entity>();
            EmmaAnaCode4 = new System.Collections.Generic.List<EmmaAnaCode4Entity>();
            EmmaAnaCode5 = new System.Collections.Generic.List<EmmaAnaCode5Entity>();
            EmmaAnaCode6 = new System.Collections.Generic.List<EmmaAnaCode6Entity>();
            EmmaAnaCode7 = new System.Collections.Generic.List<EmmaAnaCode7Entity>();
            EmmaAnaCode8 = new System.Collections.Generic.List<EmmaAnaCode8Entity>();
            Magazijns = new System.Collections.Generic.List<MagazijnEntity>();
            InitializePartial();
		}

        public int EmployeeId { get; set; }
        public long EmployeeNumber { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Initials { get; set; }
        public string AdressLine1 { get; set; }
        public string AdressLine2 { get; set; }
        public string StreetCode { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string CountryCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }
        public System.DateTime? Birthday { get; set; }
        public string Language { get; set; }
        public string Notes { get; set; }
        public int? ParentEmployeeId { get; set; }
        public string Gender { get; set; }
        public System.DateTime? HireDate { get; set; }
        public System.DateTime? StartDate { get; set; }
        public System.DateTime? EndDate { get; set; }
        public int? CompanyId { get; set; }
        public double? BasisLoon { get; set; }
        public string BasisLoonEc { get; set; }
        public double? LoonCost { get; set; }
        public string LoonCostEc { get; set; }
        public string LoonCostKs { get; set; }
        public double? NormAantal { get; set; }
        public string OnNumber { get; set; }
        public string RijksregNr { get; set; }
        public bool? IsCalculator { get; set; }
        public bool? IsVeranwoordelijke { get; set; }
        public bool? IsArbeider { get; set; }
        public bool? IsBediende { get; set; }
        public byte[] Foto { get; set; }
        public string FullName { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public string Code3 { get; set; }
        public string Code4 { get; set; }
        public string Code5 { get; set; }
        public string Code6 { get; set; }
        public string Code7 { get; set; }
        public string Code8 { get; set; }
        public string Description { get; set; }
        public string GeboortePlaats { get; set; }
        public string Nationality { get; set; }
        public string IdentiteitskaartNummer { get; set; }
        public string SisKaartNummer { get; set; }
        public System.DateTime? SisVervalDatum { get; set; }
        public string PersoneelsNummer { get; set; }
        public string PersoneelsRegisterNummer { get; set; }
        public string EmailPrive { get; set; }
        public string PhonePrive { get; set; }
        public string GsmPrive { get; set; }
        public string ParitairComiteNummer { get; set; }
        public string Functie { get; set; }
        public double? UurPerWeek { get; set; }
        public int? DaysPerWeek { get; set; }
        public double? KmThuisWerk { get; set; }
        public string Loonstelsel { get; set; }
        public string BurgelijkeStand { get; set; }
        public string NameSpouse { get; set; }
        public System.DateTime? BirtDaySpouse { get; set; }
        public bool? EchtgenoteTenLaste { get; set; }
        public int? KinderenTenLaste { get; set; }
        public int? KinderenTenLasteInvalid { get; set; }
        public int? AndereTenLaste { get; set; }
        public int? AndereTenLasteInvalid { get; set; }
        public string BetalingsWijze { get; set; }
        public string IbanNr { get; set; }
        public string BicNr { get; set; }
        public string RekeningHouder { get; set; }
        public string RekeningHouderStraat { get; set; }
        public string RekeningHouderZipCode { get; set; }
        public string RekeningHouderCity { get; set; }
        public string DefaultMobiliteitsCode { get; set; }
        public string OldEmployeeNumber { get; set; }
        public bool LoonCostFromParentYn { get; set; }
        public System.Collections.Generic.ICollection<EmmaAnaCode1Entity> EmmaAnaCode1 { get; set; }
        public System.Collections.Generic.ICollection<EmmaAnaCode2Entity> EmmaAnaCode2 { get; set; }
        public System.Collections.Generic.ICollection<EmmaAnaCode3Entity> EmmaAnaCode3 { get; set; }
        public System.Collections.Generic.ICollection<EmmaAnaCode4Entity> EmmaAnaCode4 { get; set; }
        public System.Collections.Generic.ICollection<EmmaAnaCode5Entity> EmmaAnaCode5 { get; set; }
        public System.Collections.Generic.ICollection<EmmaAnaCode6Entity> EmmaAnaCode6 { get; set; }
        public System.Collections.Generic.ICollection<EmmaAnaCode7Entity> EmmaAnaCode7 { get; set; }
        public System.Collections.Generic.ICollection<EmmaAnaCode8Entity> EmmaAnaCode8 { get; set; }
        public System.Collections.Generic.ICollection<MagazijnEntity> Magazijns { get; set; }
        public CompanyEntity Company { get; set; }
        public CountryEntity Country { get; set; }
        public KsEntity Ks { get; set; }
        public LanguageEntity Language_Language { get; set; }
        public MobiliteitsCodeEntity MobiliteitsCode { get; set; }
        public UcEntity Uc_BasisLoonEc { get; set; }
        public UcEntity Uc_LoonCostEc { get; set; }
             
        partial void InitializePartial();
    }
}
