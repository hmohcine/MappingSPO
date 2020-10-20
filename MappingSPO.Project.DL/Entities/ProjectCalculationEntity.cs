
namespace MappingSPO.Project.DL.Entities
{
    public partial class ProjectCalculationEntity
    {
		public ProjectCalculationEntity()
        {
            InitializePartial();
		}

        public long ProjectId { get; set; }
        public string ProjectType { get; set; }
        public long CalcId { get; set; }
        public bool IncludeInSum { get; set; }
        public bool IncludeInXrm { get; set; }
        public string Notes { get; set; }
        public int LineOrder { get; set; }
        public CalculationEntity Calculation { get; set; }
        public ProjectEntity Project { get; set; }
             
        partial void InitializePartial();
    }
}
