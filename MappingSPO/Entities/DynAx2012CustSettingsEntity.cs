
namespace MappingSPO.Entities
{
    public partial class DynAx2012CustSettingsEntity
    {
		public DynAx2012CustSettingsEntity()
        {
            InitializePartial();
		}

        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string AxCodeSettlement { get; set; }
        public string AxCodeLegalEntity { get; set; }
        public string AxNameLegalEntity { get; set; }
        public string LocationSalesInvoice { get; set; }
        public string LocationSalesCreditNota { get; set; }
        public string ShareAtWorkOwner { get; set; }
        public string ShareAtWorkDepartment { get; set; }
        public int? MailRoomId { get; set; }
        public string LastUsedVoucher { get; set; }
        public CompanyEntity Company { get; set; }
             
        partial void InitializePartial();
    }
}
