
namespace MappingSPO.Entities
{
    public partial class KsEntity
    {
		public KsEntity()
        {
            DefWinstPct = 0;
            ArticleDefaults = new System.Collections.Generic.List<ArticleDefaultEntity>();
            AutomaticCalcSettings = new System.Collections.Generic.List<AutomaticCalcSettingEntity>();
            CostHeaderTypes = new System.Collections.Generic.List<CostHeaderTypeEntity>();
            Employees = new System.Collections.Generic.List<EmployeeEntity>();
            Relations = new System.Collections.Generic.List<RelationEntity>();
            WerkCodes = new System.Collections.Generic.List<WerkCodeEntity>();
            InitializePartial();
		}

        public string Ks_ { get; set; }
        public string Description { get; set; }
        public double? DefWinstPct { get; set; }
        public int? Kg { get; set; }
        public int? BColor { get; set; }
        public string ExternalCode { get; set; }
        public double? W01Default { get; set; }
        public double? W02Default { get; set; }
        public double? W03Default { get; set; }
        public double? W04Default { get; set; }
        public long? DefaultCbsActiviteitId { get; set; }
        public System.Collections.Generic.ICollection<ArticleDefaultEntity> ArticleDefaults { get; set; }
        public System.Collections.Generic.ICollection<AutomaticCalcSettingEntity> AutomaticCalcSettings { get; set; }
        public System.Collections.Generic.ICollection<CostHeaderTypeEntity> CostHeaderTypes { get; set; }
        public System.Collections.Generic.ICollection<EmployeeEntity> Employees { get; set; }
        public System.Collections.Generic.ICollection<RelationEntity> Relations { get; set; }
        public System.Collections.Generic.ICollection<WerkCodeEntity> WerkCodes { get; set; }
        public ActiviteitenEntity Activiteiten { get; set; }
             
        partial void InitializePartial();
    }
}
