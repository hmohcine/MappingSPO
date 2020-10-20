
namespace MappingSPO.Entities
{
    public partial class HcEntity
    {
		public HcEntity()
        {
            OverVorderenYn = -1;
            InitializePartial();
		}

        public string CalcHc { get; set; }
        public short OverVorderenYn { get; set; }
        public bool? AutoCreateOnCalc { get; set; }
        public string Description { get; set; }
             
        partial void InitializePartial();
    }
}
