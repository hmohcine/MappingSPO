
namespace MappingSPO.Entities
{
    public partial class WerfTypeEntity
    {
		public WerfTypeEntity()
        {
            Domain = "C";
            SysWerfParas_ContractOaDefaultType = new System.Collections.Generic.List<SysWerfParaEntity>();
            SysWerfParas_WerfDefaultType = new System.Collections.Generic.List<SysWerfParaEntity>();
            InitializePartial();
		}

        public string WerfTypeId { get; set; }
        public string WerfMayorTypeCode { get; set; }
        public string WerfType_ { get; set; }
        public string WerfTypeDescription { get; set; }
        public string Domain { get; set; }
        public System.Collections.Generic.ICollection<SysWerfParaEntity> SysWerfParas_ContractOaDefaultType { get; set; }
        public System.Collections.Generic.ICollection<SysWerfParaEntity> SysWerfParas_WerfDefaultType { get; set; }
             
        partial void InitializePartial();
    }
}
