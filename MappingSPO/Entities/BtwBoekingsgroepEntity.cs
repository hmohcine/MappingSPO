
namespace MappingSPO.Entities
{
    public partial class BtwBoekingsgroepEntity
    {
		public BtwBoekingsgroepEntity()
        {
            InitializePartial();
		}

        public long BtwBoekingsgroepId { get; set; }
        public string Code { get; set; }
        public int BtwRegime { get; set; }
        public int VatCode { get; set; }
        public int CalcVatCode { get; set; }
        public VatEntity Vat_CalcVatCode { get; set; }
        public VatEntity Vat_VatCode { get; set; }
        public VatRegimeEntity VatRegime { get; set; }
             
        partial void InitializePartial();
    }
}
