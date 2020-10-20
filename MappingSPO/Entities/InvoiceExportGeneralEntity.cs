
namespace MappingSPO.Entities
{
    public partial class InvoiceExportGeneralEntity
    {
		public InvoiceExportGeneralEntity()
        {
            Id = 0;
            IncomingInvoiceAutoMatchingTolerance = 0m;
            InitializePartial();
		}

        public int? Exporter { get; set; }
        public int Id { get; set; }
        public decimal IncomingInvoiceAutoMatchingTolerance { get; set; }
             
        partial void InitializePartial();
    }
}
