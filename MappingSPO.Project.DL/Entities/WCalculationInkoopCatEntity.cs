
namespace MappingSPO.Project.DL.Entities
{
    public partial class WCalculationInkoopCatEntity
    {
		public WCalculationInkoopCatEntity()
        {
            InitializePartial();
		}

        public long CalcId { get; set; }
        public string InkoopCats { get; set; }
             
        partial void InitializePartial();
    }
}
