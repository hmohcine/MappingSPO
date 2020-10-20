
namespace MappingSPO.Entities
{
    public partial class EmmaAnaCode9Entity
    {
		public EmmaAnaCode9Entity()
        {
            InitializePartial();
		}

        public long CodeId { get; set; }
        public string Description { get; set; }
        public bool Disabled { get; set; }
        public double? CalcPct { get; set; }
        public int? EmployeeId { get; set; }
             
        partial void InitializePartial();
    }
}
