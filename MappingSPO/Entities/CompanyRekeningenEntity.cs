
namespace MappingSPO.Entities
{
    public partial class CompanyRekeningenEntity
    {
		public CompanyRekeningenEntity()
        {
            InitializePartial();
		}

        public int CompanyId { get; set; }
        public long RekeningId { get; set; }
        public int? Lineorder { get; set; }
        public CompanyEntity Company { get; set; }
        public RekeningNrEntity RekeningNr { get; set; }
             
        partial void InitializePartial();
    }
}
