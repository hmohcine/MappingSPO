
namespace MappingSPO.Entities
{
    public partial class IncomingInvoiceSettingEntity
    {
		public IncomingInvoiceSettingEntity()
        {
            Id = 1;
            DigitsNumber = 5;
            DigitsYear = 4;
            PrefixInvoice = "IF";
            PrefixCreditNota = "IC";
            ModuleActive = false;
            InitializePartial();
		}

        public int Id { get; set; }
        public int DigitsNumber { get; set; }
        public int DigitsYear { get; set; }
        public string PrefixInvoice { get; set; }
        public string PrefixCreditNota { get; set; }
        public bool ModuleActive { get; set; }
        public double? MaxResiduPercent { get; set; }
        public double? MaxResiduValue { get; set; }
        public string DefaultEc { get; set; }
        public UcEntity Uc { get; set; }
             
        partial void InitializePartial();
    }
}
