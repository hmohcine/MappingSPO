
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcKEntity
    {
		public CalcKEntity()
        {
            InitializePartial();
		}

        public long CalcId { get; set; }
        public short MayorTypeCode { get; set; }
        public string CalcKs { get; set; }
        public short TypeLine { get; set; }
        public double? Tkp { get; set; }
        public double? Tvp { get; set; }
        public double? TWinst { get; set; }
        public double? TWinstpct { get; set; }
        public long? CountLines { get; set; }
        public double? EcAantal { get; set; }
        public string Ec { get; set; }
        public bool? EcValid { get; set; }
        public double? W01Pct { get; set; }
        public double? W02Pct { get; set; }
        public double? W03Pct { get; set; }
        public double? W04Pct { get; set; }
        public double? BudgetVerlaging1Pct { get; set; }
        public double? BudgetVerlaging2Pct { get; set; }
        public double? BudgetVerlaging1 { get; set; }
        public double? BudgetVerlaging2 { get; set; }
        public double? TvpLocked { get; set; }
        public double? TkpLocked { get; set; }
        public double? TWinstLocked { get; set; }
        public double? TWinstpctLocked { get; set; }
        public CalculationEntity Calculation { get; set; }
             
        partial void InitializePartial();
    }
}
