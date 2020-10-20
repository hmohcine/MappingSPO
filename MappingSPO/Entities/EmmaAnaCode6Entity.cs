
namespace MappingSPO.Entities
{
    public partial class EmmaAnaCode6Entity
    {
		public EmmaAnaCode6Entity()
        {
            InitializePartial();
		}

        public long CodeId { get; set; }
        public string Description { get; set; }
        public double? CalcPct { get; set; }
        public bool Disabled { get; set; }
        public int? EmployeeId { get; set; }
        public EmployeeEntity Employee { get; set; }
             
        partial void InitializePartial();
    }
}
