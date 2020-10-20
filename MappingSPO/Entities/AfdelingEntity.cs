
namespace MappingSPO.Entities
{
    public partial class AfdelingEntity
    {
		public AfdelingEntity()
        {
            WorkOrderTypeAfdelings = new System.Collections.Generic.List<WorkOrderTypeAfdelingEntity>();
            AfmeldingsPuntens = new System.Collections.Generic.List<AfmeldingsPuntenEntity>();
            InitializePartial();
		}

        public long AfdelingId { get; set; }
        public string AfdelingName { get; set; }
        public bool RefTonenYn { get; set; }
        public string DefaultRefLabel { get; set; }
        public int TimesheetType { get; set; }
        public System.Collections.Generic.ICollection<AfmeldingsPuntenEntity> AfmeldingsPuntens { get; set; }
        public System.Collections.Generic.ICollection<WorkOrderTypeAfdelingEntity> WorkOrderTypeAfdelings { get; set; }
             
        partial void InitializePartial();
    }
}
