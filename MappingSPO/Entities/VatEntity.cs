
namespace MappingSPO.Entities
{
    public partial class VatEntity
    {
		public VatEntity()
        {
            ArticleDefaults = new System.Collections.Generic.List<ArticleDefaultEntity>();
            BtwBoekingsgroeps_CalcVatCode = new System.Collections.Generic.List<BtwBoekingsgroepEntity>();
            BtwBoekingsgroeps_VatCode = new System.Collections.Generic.List<BtwBoekingsgroepEntity>();
            ExportVatSettings = new System.Collections.Generic.List<ExportVatSettingEntity>();
            Invoices = new System.Collections.Generic.List<InvoiceEntity>();
            InvoiceExports = new System.Collections.Generic.List<InvoiceExportEntity>();
            SalesDefaults = new System.Collections.Generic.List<SalesDefaultEntity>();
            SysWerfParas = new System.Collections.Generic.List<SysWerfParaEntity>();
            VatRegimes = new System.Collections.Generic.List<VatRegimeEntity>();
            InitializePartial();
		}

        public int VatCode { get; set; }
        public double? VatPct { get; set; }
        public string ExternalCode { get; set; }
        public string Description { get; set; }
        public System.Collections.Generic.ICollection<ArticleDefaultEntity> ArticleDefaults { get; set; }
        public System.Collections.Generic.ICollection<BtwBoekingsgroepEntity> BtwBoekingsgroeps_CalcVatCode { get; set; }
        public System.Collections.Generic.ICollection<BtwBoekingsgroepEntity> BtwBoekingsgroeps_VatCode { get; set; }
        public System.Collections.Generic.ICollection<ExportVatSettingEntity> ExportVatSettings { get; set; }
        public System.Collections.Generic.ICollection<InvoiceEntity> Invoices { get; set; }
        public System.Collections.Generic.ICollection<InvoiceExportEntity> InvoiceExports { get; set; }
        public System.Collections.Generic.ICollection<SalesDefaultEntity> SalesDefaults { get; set; }
        public System.Collections.Generic.ICollection<SysWerfParaEntity> SysWerfParas { get; set; }
        public System.Collections.Generic.ICollection<VatRegimeEntity> VatRegimes { get; set; }
             
        partial void InitializePartial();
    }
}
