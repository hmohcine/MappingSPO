
namespace MappingSPO.Entities
{
    public partial class ContactEntity
    {
		public ContactEntity()
        {
            PlaceOfBirth = "Ramsel";
            Invoices = new System.Collections.Generic.List<InvoiceEntity>();
            RelationsContacts = new System.Collections.Generic.List<RelationsContactEntity>();
            InitializePartial();
		}

        public int ContactId { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string AdressLine1 { get; set; }
        public string AdressLine2 { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string StreetCode { get; set; }
        public string CountryCode { get; set; }
        public string Notes { get; set; }
        public string Language { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public System.DateTime? LastUpdated { get; set; }
        public int? LastUpdatedBy { get; set; }
        public string Gsm { get; set; }
        public int? ExtId { get; set; }
        public string Aanhef { get; set; }
        public byte[] Foto { get; set; }
        public string SPhone { get; private set; }
        public string SFax { get; private set; }
        public string SGsm { get; private set; }
        public long? AccId { get; set; }
        public string AccType { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public string Code3 { get; set; }
        public string Code4 { get; set; }
        public string Code5 { get; set; }
        public string Code6 { get; set; }
        public string Code7 { get; set; }
        public string Code8 { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string NationalNumber { get; set; }
        public string IdNumber { get; set; }
        public string Nationality { get; set; }
        public int? Gender { get; set; }
        public string MaritalStatus { get; set; }
        public bool? ExtraBoolean1 { get; set; }
        public bool? ExtraBoolean2 { get; set; }
        public bool? ExtraBoolean3 { get; set; }
        public bool? ExtraBoolean4 { get; set; }
        public string ExtraRef1 { get; set; }
        public string ExtraRef2 { get; set; }
        public string ExtraRef3 { get; set; }
        public string ExtraRef4 { get; set; }
        public double? ExtraNum1 { get; set; }
        public double? ExtraNum2 { get; set; }
        public double? ExtraNum3 { get; set; }
        public double? ExtraNum4 { get; set; }
        public double? ExtraNum5 { get; set; }
        public double? ExtraNum6 { get; set; }
        public double? ExtraNum7 { get; set; }
        public double? ExtraNum8 { get; set; }
        public long? TranslatableCode1 { get; set; }
        public long? TranslatableCode2 { get; set; }
        public long? TranslatableCode3 { get; set; }
        public long? TranslatableCode4 { get; set; }
        public long? TranslatableCode5 { get; set; }
        public long? TranslatableCode6 { get; set; }
        public long? TranslatableCode7 { get; set; }
        public long? TranslatableCode8 { get; set; }
        public System.Collections.Generic.ICollection<InvoiceEntity> Invoices { get; set; }
        public System.Collections.Generic.ICollection<RelationsContactEntity> RelationsContacts { get; set; }
        public CountryEntity Country { get; set; }
        public LanguageEntity Language_Language { get; set; }
        public UserEntity User { get; set; }
             
        partial void InitializePartial();
    }
}
