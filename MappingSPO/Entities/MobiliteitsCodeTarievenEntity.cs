
namespace MappingSPO.Entities
{
    public partial class MobiliteitsCodeTarievenEntity
    {
		public MobiliteitsCodeTarievenEntity()
        {
            InUse = false;
            InitializePartial();
		}

        public string Code { get; set; }
        public System.DateTime StartDate { get; set; }
        public decimal Tarief { get; set; }
        public System.DateTime? EndDate { get; set; }
        public bool InUse { get; set; }
        public MobiliteitsCodeEntity MobiliteitsCode { get; set; }
             
        partial void InitializePartial();
    }
}
