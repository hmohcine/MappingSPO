
namespace MappingSPO.Entities
{
    public partial class InvoicePlanDefaultEntity
    {
		public InvoicePlanDefaultEntity()
        {
            InvoicePlanDefaultsSchijvens = new System.Collections.Generic.List<InvoicePlanDefaultsSchijvenEntity>();
            InitializePartial();
		}

        public long InvPlanId { get; set; }
        public string InvPlanName { get; set; }
        public bool IsDefault { get; set; }
        public int SchijfCount { get; set; }
        public string NotesInternal { get; set; }
        public string NotesExternal { get; set; }
        public long? DefaultVerkoopCatId { get; set; }
        public long? ActiviteitId { get; set; }
        public System.Collections.Generic.ICollection<InvoicePlanDefaultsSchijvenEntity> InvoicePlanDefaultsSchijvens { get; set; }
             
        partial void InitializePartial();
    }
}
