
namespace MappingSPO.Entities
{
    public partial class HerzieningTemplateEntity
    {
		public HerzieningTemplateEntity()
        {
            HerzieningTemplateTerms = new System.Collections.Generic.List<HerzieningTemplateTermEntity>();
            InitializePartial();
		}

        public long HerzieningTemplateId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string DescriptionExtern { get; set; }
        public int State { get; set; }
        public int CountOfTerms { get; set; }
        public long? WerfId { get; set; }
        public string FormuleInText { get; set; }
        public bool FormuleValid { get; set; }
        public string FormuleInText2 { get; set; }
        public System.Collections.Generic.ICollection<HerzieningTemplateTermEntity> HerzieningTemplateTerms { get; set; }
             
        partial void InitializePartial();
    }
}
