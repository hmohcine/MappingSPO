
namespace MappingSPO.Entities
{
    public partial class BoekPeriodeEntity
    {
		public BoekPeriodeEntity()
        {
            Invoices = new System.Collections.Generic.List<InvoiceEntity>();
            InitializePartial();
		}

        public int CompanyId { get; set; }
        public int BoekPeriode_ { get; set; }
        public string Prefixperiode { get; set; }
        public string PrefixperiodeCn { get; set; }
        public System.DateTime? PeriodeStart { get; set; }
        public System.DateTime? PeriodeEnd { get; set; }
        public bool? CnAfzonderlijk { get; set; }
        public long? StartNr { get; set; }
        public long? StartNrCn { get; set; }
        public string FormatNr { get; set; }
        public bool? Activated { get; set; }
        public bool? Locked { get; set; }
        public long? NextNr { get; set; }
        public long? NextNrCn { get; set; }
        public int LastChangedBy { get; set; }
        public System.DateTime LastChangedDate { get; set; }
        public string DagBoek { get; set; }
        public System.Collections.Generic.ICollection<InvoiceEntity> Invoices { get; set; }
        public CompanyEntity Company { get; set; }
        public UserEntity User { get; set; }
             
        partial void InitializePartial();
    }
}
