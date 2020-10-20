
namespace MappingSPO.Entities
{
    public partial class InvoiceEntity
    {
		public InvoiceEntity()
        {
            InvoiceState = 0;
            TvpExcl = 0m;
            VatAmount = 0m;
            TvpIncl = 0m;
            CashDiscount = 0m;
            InitializePartial();
		}

        public long InvoiceId { get; set; }
        public int? BoekPeriodeCompanyId { get; set; }
        public int? BoekPeriode { get; set; }
        public int InvoiceState { get; set; }
        public int? InvoiceType { get; set; }
        public string InvoiceNrTxt { get; set; }
        public System.DateTime? InvoiceDate { get; set; }
        public string PayConditionId { get; set; }
        public System.DateTime? VervalDate { get; set; }
        public string NotesExternal { get; set; }
        public string NotesInternal { get; set; }
        public System.DateTime? CreateDate { get; set; }
        public int CreatedBy { get; set; }
        public int? DigitsUnit { get; set; }
        public int? DigitsTotal { get; set; }
        public long? InvoiceNr { get; set; }
        public long? InvoiceAdressId { get; set; }
        public int? ContactId { get; set; }
        public long? RelationId { get; set; }
        public long? WerfId { get; set; }
        public System.DateTime? LastChangedDate { get; set; }
        public int LastChangedBy { get; set; }
        public int? CompanyId { get; set; }
        public decimal TvpExcl { get; set; }
        public decimal VatAmount { get; set; }
        public decimal TvpIncl { get; set; }
        public int? DefaultBtwRegime { get; set; }
        public int? DefaultVatCode { get; set; }
        public string InvoiceSoort { get; set; }
        public string NotesExternal2 { get; set; }
        public string ReferentieIntern { get; set; }
        public System.DateTime? DeliveryDate { get; set; }
        public string OgmNumber { get; set; }
        public string OgmNumberTxt { get; set; }
        public int? DefaultCashDiscountId { get; set; }
        public double? DefaultCashDiscountpct { get; set; }
        public int? DefaultCashDiscountDays { get; set; }
        public decimal CashDiscount { get; set; }
        public string CodaBoxId { get; set; }
        public System.DateTime? CodaboxCreateDate { get; set; }
        public string CodaBoxState { get; set; }
        public string LanguageCode { get; set; }
        public int? TotalNumberOfPrints { get; set; }
        public System.DateTime? LastPrintDate { get; set; }
        public System.DateTime? ExportBkhDate { get; set; }
        public string NumberBkh { get; set; }
        public long? DefaultVerkoopCatId { get; set; }
        public long? ActiviteitId { get; set; }
        public System.DateTime? DisplayInvoiceDate { get; private set; }
        public System.DateTime? DisplayVervalDate { get; private set; }
        public System.DateTime? BookDate { get; set; }
        public string CodaBoxTransmissionId { get; set; }
        public BoekPeriodeEntity BoekPeriode_BoekPeriode { get; set; }
        public CashDiscountEntity DefaultCashDiscount { get; set; }
        public CompanyEntity Company { get; set; }
        public ContactEntity Contact { get; set; }
        public LanguageEntity Language { get; set; }
        public PayConditionEntity PayCondition { get; set; }
        public RelActiviteitEntity RelActiviteit { get; set; }
        public RelationEntity Relation { get; set; }
        public UserEntity User_CreatedBy { get; set; }
        public UserEntity User_LastChangedBy { get; set; }
        public VatEntity Vat { get; set; }
        public VatRegimeEntity VatRegime { get; set; }
             
        partial void InitializePartial();
    }
}
