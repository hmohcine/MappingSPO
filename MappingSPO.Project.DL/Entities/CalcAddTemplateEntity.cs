
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcAddTemplateEntity
    {
		public CalcAddTemplateEntity()
        {
            Domain = "C";
            InitializePartial();
		}

        public long CalcId { get; set; }
        public int LineOrder { get; set; }
        public string Domain { get; set; }
        public CalculationEntity Calculation { get; set; }
             
        partial void InitializePartial();
    }
}
