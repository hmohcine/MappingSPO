
namespace MappingSPO.Entities
{
    public partial class VatRegimeEntity
    {
		public VatRegimeEntity()
        {
            BtwBoekingsgroeps = new System.Collections.Generic.List<BtwBoekingsgroepEntity>();
            ExportVatSettings = new System.Collections.Generic.List<ExportVatSettingEntity>();
            Invoices = new System.Collections.Generic.List<InvoiceEntity>();
            InvoiceExports = new System.Collections.Generic.List<InvoiceExportEntity>();
            Relations = new System.Collections.Generic.List<RelationEntity>();
            SalesDefaults = new System.Collections.Generic.List<SalesDefaultEntity>();
            SysWerfParas = new System.Collections.Generic.List<SysWerfParaEntity>();
            VatRegimeNotes = new System.Collections.Generic.List<VatRegimeNoteEntity>();
            InitializePartial();
		}

        public int BtwRegime { get; set; }
        public string Code { get; set; }
        public string ExternalCode { get; set; }
        public string Description { get; set; }
        public bool? CalcWithOtherCode { get; set; }
        public int? OtherCode { get; set; }
        public System.Collections.Generic.ICollection<BtwBoekingsgroepEntity> BtwBoekingsgroeps { get; set; }
        public System.Collections.Generic.ICollection<ExportVatSettingEntity> ExportVatSettings { get; set; }
        public System.Collections.Generic.ICollection<InvoiceEntity> Invoices { get; set; }
        public System.Collections.Generic.ICollection<InvoiceExportEntity> InvoiceExports { get; set; }
        public System.Collections.Generic.ICollection<RelationEntity> Relations { get; set; }
        public System.Collections.Generic.ICollection<SalesDefaultEntity> SalesDefaults { get; set; }
        public System.Collections.Generic.ICollection<SysWerfParaEntity> SysWerfParas { get; set; }
        public System.Collections.Generic.ICollection<VatRegimeNoteEntity> VatRegimeNotes { get; set; }
        public VatEntity Vat { get; set; }
             
        partial void InitializePartial();
    }
}
