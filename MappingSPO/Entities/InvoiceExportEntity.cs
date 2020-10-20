
namespace MappingSPO.Entities
{
    public partial class InvoiceExportEntity
    {
		public InvoiceExportEntity()
        {
            InitializePartial();
		}

        public string CountryCode { get; set; }
        public int VatCode { get; set; }
        public int BtwRegime { get; set; }
        public string RekeningVerkoop { get; set; }
        public string RekeningVat { get; set; }
        public string VentilatieCode { get; set; }
        public string ExtraValue { get; set; }
        public string TaxCategoryCode { get; set; }
        public CountryEntity Country { get; set; }
        public VatEntity Vat { get; set; }
        public VatRegimeEntity VatRegime { get; set; }
             
        partial void InitializePartial();
    }
}
