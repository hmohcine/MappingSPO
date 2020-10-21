
namespace MappingSPO.Entities
{
    public partial class WerkCodeEntity
    {
		public WerkCodeEntity()
        {
            VoorschotBerekenenYn = false;
            WerkcodeType = 0;
            Companies = new System.Collections.Generic.List<CompanyEntity>();
            CounterWerkCodes = new System.Collections.Generic.List<CounterWerkCodeEntity>();
            MobiliteitsCodes = new System.Collections.Generic.List<MobiliteitsCodeEntity>();
            SysWerfParas = new System.Collections.Generic.List<SysWerfParaEntity>();
            WorkOrderTypes = new System.Collections.Generic.List<WorkOrderTypeEntity>();
            InitializePartial();
		}

        public string WerkCode_ { get; set; }
        public string Description { get; set; }
        public bool IsWerkend { get; set; }
        public decimal? DefaultLoonCostFactor { get; set; }
        public string ExternalCode { get; set; }
        public int? ExtVvAvailability { get; set; }
        public double? ExtVvFactor { get; set; }
        public string ExtVvGroepSCode { get; set; }
        public bool VoorschotBerekenenYn { get; set; }
        public int WerkcodeType { get; set; }
        public string Ks { get; set; }
        public System.Collections.Generic.ICollection<CompanyEntity> Companies { get; set; }
        public System.Collections.Generic.ICollection<CounterWerkCodeEntity> CounterWerkCodes { get; set; }
        public System.Collections.Generic.ICollection<MobiliteitsCodeEntity> MobiliteitsCodes { get; set; }
        public System.Collections.Generic.ICollection<SysWerfParaEntity> SysWerfParas { get; set; }
        public System.Collections.Generic.ICollection<WorkOrderTypeEntity> WorkOrderTypes { get; set; }
        public KsEntity Ks_Ks { get; set; }
             
        partial void InitializePartial();
    }
}
