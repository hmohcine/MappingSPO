
namespace MappingSPO.Entities
{
    public partial class HerzieningIndexEntity
    {
		public HerzieningIndexEntity()
        {
            DefaultDigits = 5;
            HerzieningTemplateTerms = new System.Collections.Generic.List<HerzieningTemplateTermEntity>();
            InitializePartial();
		}

        public string IndexCode { get; set; }
        public string Description { get; set; }
        public int DefaultDigits { get; set; }
        public string DateFormat { get; set; }
        public string IndexUpper { get; set; }
        public string IndexLower { get; set; }
        public System.Collections.Generic.ICollection<HerzieningTemplateTermEntity> HerzieningTemplateTerms { get; set; }
             
        partial void InitializePartial();
    }
}
