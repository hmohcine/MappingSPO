
namespace MappingSPO.Entities
{
    public partial class EmmaAnaCode8Entity
    {
		public EmmaAnaCode8Entity()
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