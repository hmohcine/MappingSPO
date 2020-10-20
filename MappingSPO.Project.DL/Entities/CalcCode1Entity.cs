
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcCode1Entity
    {
		public CalcCode1Entity()
        {
            CalcDisabled = false;
            Domain = "C";
            Calculations = new System.Collections.Generic.List<CalculationEntity>();
            Projects = new System.Collections.Generic.List<ProjectEntity>();
            InitializePartial();
		}

        public int CalcCodeId { get; set; }
        public string CalcCode { get; set; }
        public bool CalcDisabled { get; set; }
        public string Domain { get; set; }
        public System.Collections.Generic.ICollection<CalculationEntity> Calculations { get; set; }
        public System.Collections.Generic.ICollection<ProjectEntity> Projects { get; set; }
             
        partial void InitializePartial();
    }
}
