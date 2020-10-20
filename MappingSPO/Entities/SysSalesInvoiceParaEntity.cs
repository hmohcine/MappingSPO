
namespace MappingSPO.Entities
{
    public partial class SysSalesInvoiceParaEntity
    {
		public SysSalesInvoiceParaEntity()
        {
            InitializePartial();
		}

        public int Id { get; set; }
        public string SiteLeaderCaption { get; set; }
        public string ProjectLeiderCaption { get; set; }
             
        partial void InitializePartial();
    }
}
