
namespace MappingSPO.Project.DL.Entities
{
    public partial class WerfVorderingInvoiceEntity
    {
		public WerfVorderingInvoiceEntity()
        {
            InitializePartial();
		}

        public long WerfId { get; set; }
        public int VorderingNr { get; set; }
        public long InvoiceId { get; set; }
             
        partial void InitializePartial();
    }
}
