
namespace MappingSPO.Entities
{
    public partial class CostHeaderTypeEntity
    {
		public CostHeaderTypeEntity()
        {
            AutoSelectWerfOnCreate = false;
            WerfOnHeader = true;
            SysWerfParas = new System.Collections.Generic.List<SysWerfParaEntity>();
            InitializePartial();
		}

        public string CostHeaderType_ { get; set; }
        public string Description { get; set; }
        public int MasterType { get; set; }
        public string LabelDocumentdatum { get; set; }
        public string DefaultKs { get; set; }
        public int? DigitsDocumentnummer { get; set; }
        public string PrefixDocumentnummer { get; set; }
        public bool? Disabled { get; set; }
        public bool AutoSelectWerfOnCreate { get; set; }
        public bool WerfOnHeader { get; set; }
        public string LabelReferentie { get; set; }
        public string LabelReferentieIntern { get; set; }
        public bool? GoedKeurenBijVerwerken { get; set; }
        public bool? VerwerkenBijBewaren { get; set; }
        public bool? WerfLijstAutoAdd { get; set; }
        public bool? WerfLijstSaldoOvernemen { get; set; }
        public bool? UseExtendedEmployeeShop { get; set; }
        public int? ExtendedEmployeeNumber { get; set; }
        public System.Collections.Generic.ICollection<SysWerfParaEntity> SysWerfParas { get; set; }
        public KsEntity Ks { get; set; }
             
        partial void InitializePartial();
    }
}
