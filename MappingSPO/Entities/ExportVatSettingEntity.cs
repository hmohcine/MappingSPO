
namespace MappingSPO.Entities
{
    public partial class ExportVatSettingEntity
    {
		public ExportVatSettingEntity()
        {
            UseAsDefaultSettings = false;
            InitializePartial();
		}

        public int Id { get; set; }
        public int VatRegime { get; set; }
        public string CountryCode { get; set; }
        public string VatCode { get; set; }
        public int VatPctCode { get; set; }
        public string LedgerAccountVat { get; set; }
        public string VatExternalCode { get; set; }
        public string VatPctExternalCode { get; set; }
        public bool UseAsDefaultSettings { get; set; }
        public string CustGroup { get; set; }
        public string LedgerAccountOverride { get; set; }
        public int? VatFieldInVenice { get; set; }
        public int? RevenueFieldInVenice { get; set; }
        public CountryEntity Country { get; set; }
        public VatEntity Vat { get; set; }
        public VatRegimeEntity VatRegime_VatRegime { get; set; }
             
        partial void InitializePartial();
    }
}
