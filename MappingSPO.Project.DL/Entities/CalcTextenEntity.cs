
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcTextenEntity
    {
		public CalcTextenEntity()
        {
            InitializePartial();
		}

        public long CalcId { get; set; }
        public long TextId { get; set; }
        public byte Location { get; set; }
        public byte Type { get; set; }
        public string ReferentieIntern { get; set; }
        public string RtfText { get; set; }
        public bool ShowOnOffer { get; set; }
        public int LinePosition { get; set; }
        public bool KeepToghether { get; set; }
        public long? LinkTextId { get; set; }
        public string NormalText { get; set; }
        public CalculationEntity Calculation { get; set; }
             
        partial void InitializePartial();
    }
}
