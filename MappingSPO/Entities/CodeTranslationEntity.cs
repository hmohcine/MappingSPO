
namespace MappingSPO.Entities
{
    public partial class CodeTranslationEntity
    {
		public CodeTranslationEntity()
        {
            InitializePartial();
		}

        public int Id { get; set; }
        public int Context { get; set; }
        public int CodeIndex { get; set; }
        public int CodeId { get; set; }
        public string LanguageCode { get; set; }
        public string Code { get; set; }
        public LanguageEntity Language { get; set; }
             
        partial void InitializePartial();
    }
}
