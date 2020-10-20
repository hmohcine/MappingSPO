
namespace MappingSPO.Entities
{
    public partial class RekeningNrEntity
    {
		public RekeningNrEntity()
        {
            Priority = 0;
            CompanyRekeningens = new System.Collections.Generic.List<CompanyRekeningenEntity>();
            InitializePartial();
		}

        public long RekeningId { get; set; }
        public string BancName { get; set; }
        public string BancNr { get; set; }
        public string IbanNr { get; set; }
        public string BicNr { get; set; }
        public int Priority { get; set; }
        public System.Collections.Generic.ICollection<CompanyRekeningenEntity> CompanyRekeningens { get; set; }
             
        partial void InitializePartial();
    }
}
