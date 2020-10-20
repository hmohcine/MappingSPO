
namespace MappingSPO.Entities
{
    public partial class WholesalerUnitcodeEntity
    {
		public WholesalerUnitcodeEntity()
        {
            InitializePartial();
		}

        public string Wholesalerkey { get; set; }
        public string Environment { get; set; }
        public string UcWholesaler { get; set; }
        public string UcBuild { get; set; }
        public UcEntity Uc { get; set; }
        public WholesalerEntity Wholesaler { get; set; }
             
        partial void InitializePartial();
    }
}
