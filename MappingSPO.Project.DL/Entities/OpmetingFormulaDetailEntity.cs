
namespace MappingSPO.Project.DL.Entities
{
    public partial class OpmetingFormulaDetailEntity
    {
		public OpmetingFormulaDetailEntity()
        {
            InitializePartial();
		}

        public long CalcDetailId { get; set; }
        public long CalcId { get; set; }
        public int Line { get; set; }
        public double? P1 { get; set; }
        public double? P2 { get; set; }
        public double? P3 { get; set; }
        public double? P4 { get; set; }
        public double? P5 { get; set; }
        public double? P6 { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public int LineOrder { get; set; }
        public double? SubResult { get; set; }
        public string PrintCode { get; set; }
        public string BimName { get; set; }
        public double? SubResultNum1 { get; set; }
        public double? SubResultNum2 { get; set; }
        public double? SubResultNum3 { get; set; }
        public double? SubResultNum4 { get; set; }
        public double? SubResultNum5 { get; set; }
        public double? SubResultNum6 { get; set; }
        public double? SubResultNum7 { get; set; }
        public double? SubResultNum8 { get; set; }
        public OpmetingFormulaEntity OpmetingFormula { get; set; }
             
        partial void InitializePartial();
    }
}
