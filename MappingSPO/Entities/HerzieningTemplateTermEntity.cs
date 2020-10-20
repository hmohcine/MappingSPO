
namespace MappingSPO.Entities
{
    public partial class HerzieningTemplateTermEntity
    {
		public HerzieningTemplateTermEntity()
        {
            DefaultDigits = 5;
            InitializePartial();
		}

        public long HerzieningTemplateId { get; set; }
        public int TermId { get; set; }
        public int TermOrder { get; set; }
        public int TermType { get; set; }
        public string FractionLabel { get; set; }
        public decimal FractionValue { get; set; }
        public bool IsRestFraction { get; set; }
        public string IndexCode { get; set; }
        public string TermInText { get; set; }
        public int DefaultDigits { get; set; }
        public HerzieningIndexEntity HerzieningIndex { get; set; }
        public HerzieningTemplateEntity HerzieningTemplate { get; set; }
             
        partial void InitializePartial();
    }
}
