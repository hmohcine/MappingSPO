
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcActiviteitenEntity
    {
		public CalcActiviteitenEntity()
        {
            InitializePartial();
		}

        public long CalcId { get; set; }
        public long CalcActiviteitId { get; set; }
        public long? ActiviteitId { get; set; }
        public long? PostId { get; set; }
        public CalculationEntity Calculation { get; set; }
             
        partial void InitializePartial();
    }
}
