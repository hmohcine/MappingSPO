
namespace MappingSPO.Entities
{
    public partial class RelActiviteitEntity
    {
		public RelActiviteitEntity()
        {
            ShowAsMode = 0;
            CatType = 0;
            Companies = new System.Collections.Generic.List<CompanyEntity>();
            Documents_InkoopCatId = new System.Collections.Generic.List<DocumentEntity>();
            Documents_VerkoopCatId = new System.Collections.Generic.List<DocumentEntity>();
            EmmaOfferTypes = new System.Collections.Generic.List<EmmaOfferTypeEntity>();
            EmmaVkoTypes = new System.Collections.Generic.List<EmmaVkoTypeEntity>();
            Invoices = new System.Collections.Generic.List<InvoiceEntity>();
            SysMpSettingsCijfers = new System.Collections.Generic.List<SysMpSettingsCijferEntity>();
            SysWerfParas_DefaultInkoopCat = new System.Collections.Generic.List<SysWerfParaEntity>();
            SysWerfParas_DefaultVerkoopCat = new System.Collections.Generic.List<SysWerfParaEntity>();
            SysWerfParas_DefaultVerkoopCatRegie = new System.Collections.Generic.List<SysWerfParaEntity>();
            InitializePartial();
		}

        public long ActiviteitId { get; set; }
        public string Description { get; set; }
        public long? ActGroupId { get; set; }
        public string Code { get; set; }
        public int ShowAsMode { get; set; }
        public string ShowAs { get; set; }
        public string Notas { get; set; }
        public long? DefaultCbsActiviteitId { get; set; }
        public int CatType { get; set; }
        public string Rekening { get; set; }
        public string ProductGroup { get; set; }
        public string CostCenter { get; set; }
        public System.Collections.Generic.ICollection<CompanyEntity> Companies { get; set; }
        public System.Collections.Generic.ICollection<DocumentEntity> Documents_InkoopCatId { get; set; }
        public System.Collections.Generic.ICollection<DocumentEntity> Documents_VerkoopCatId { get; set; }
        public System.Collections.Generic.ICollection<EmmaOfferTypeEntity> EmmaOfferTypes { get; set; }
        public System.Collections.Generic.ICollection<EmmaVkoTypeEntity> EmmaVkoTypes { get; set; }
        public System.Collections.Generic.ICollection<InvoiceEntity> Invoices { get; set; }
        public System.Collections.Generic.ICollection<SysMpSettingsCijferEntity> SysMpSettingsCijfers { get; set; }
        public System.Collections.Generic.ICollection<SysWerfParaEntity> SysWerfParas_DefaultInkoopCat { get; set; }
        public System.Collections.Generic.ICollection<SysWerfParaEntity> SysWerfParas_DefaultVerkoopCat { get; set; }
        public System.Collections.Generic.ICollection<SysWerfParaEntity> SysWerfParas_DefaultVerkoopCatRegie { get; set; }
        public ActiviteitenEntity Activiteiten { get; set; }
        public RelActiviteitGroupEntity RelActiviteitGroup { get; set; }
             
        partial void InitializePartial();
    }
}
