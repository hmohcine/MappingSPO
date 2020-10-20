
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcInkoopCategorieEntity
    {
		public CalcInkoopCategorieEntity()
        {
            CatType = 0;
            InitializePartial();
		}

        public long CalcId { get; set; }
        public int ImpactType { get; set; }
        public long CalcInkoopCatId { get; set; }
        public double Tkp { get; set; }
        public decimal Btw { get; set; }
        public decimal TvPex { get; set; }
        public int CatType { get; set; }
        public CalculationEntity Calculation { get; set; }
             
        partial void InitializePartial();
    }
}
