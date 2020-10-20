
namespace MappingSPO.Project.DL.Entities
{
    public partial class SupplierPrijsAntwoordEntity
    {
		public SupplierPrijsAntwoordEntity()
        {
            InitializePartial();
		}

        public long PrijsVraagId { get; set; }
        public long SupplierId { get; set; }
        public int RelationTypeId { get; set; }
        public long AntwoordId { get; set; }
        public int AntwoordType { get; set; }
        public long? AntwoordSoortId { get; set; }
        public CalculationEntity Calculation { get; set; }
             
        partial void InitializePartial();
    }
}
