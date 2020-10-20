
namespace MappingSPO.Entities
{
    public partial class ExternalInvoiceBuildSettingEntity
    {
		public ExternalInvoiceBuildSettingEntity()
        {
            Id = 1;
            InitializePartial();
		}

        public long Id { get; set; }
        public bool? KoppelcentrumMasterSwitch { get; set; }
        public int? KoppelCenterRoleGroup { get; set; }
        public bool? WerfExtInvViewerMasterSwitch { get; set; }
        public int? WerfExtInvViewerReadRoleGroup { get; set; }
        public int? WerfExtInvViewerApproveRoleGroup { get; set; }
             
        partial void InitializePartial();
    }
}
