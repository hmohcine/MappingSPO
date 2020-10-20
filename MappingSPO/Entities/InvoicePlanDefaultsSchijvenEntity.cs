
namespace MappingSPO.Entities
{
    public partial class InvoicePlanDefaultsSchijvenEntity
    {
		public InvoicePlanDefaultsSchijvenEntity()
        {
            IsSaldoSchijf = false;
            InitializePartial();
		}

        public long InvPlanId { get; set; }
        public int SchijfNr { get; set; }
        public double Pct { get; set; }
        public bool IsSaldoSchijf { get; set; }
        public string Description { get; set; }
        public long? VerkoopCatId { get; set; }
        public InvoicePlanDefaultEntity InvoicePlanDefault { get; set; }
             
        partial void InitializePartial();
    }
}
