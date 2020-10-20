
namespace MappingSPO.Entities
{
    public partial class ExternalInvoiceUserSettingEntity
    {
		public ExternalInvoiceUserSettingEntity()
        {
            InitializePartial();
		}

        public int UserId { get; set; }
        public string GroupByLevel0 { get; set; }
        public string GroupByLevel1 { get; set; }
        public string GroupByLevel2 { get; set; }
        public string GroupByLevel3 { get; set; }
        public int? OpenWithLineState { get; set; }
             
        partial void InitializePartial();
    }
}
