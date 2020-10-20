
namespace MappingSPO.Entities
{
    public partial class CodeCaptionTranslationEntity
    {
		public CodeCaptionTranslationEntity()
        {
            InitializePartial();
		}

        public int Id { get; set; }
        public int Context { get; set; }
        public int CodeIndex { get; set; }
        public string LanguageCode { get; set; }
        public string Caption { get; set; }
        public LanguageEntity Language { get; set; }
             
        partial void InitializePartial();
    }
}
