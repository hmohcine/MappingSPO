
namespace MappingSPO.Entities
{
    public partial class EmailTypeTextEntity
    {
		public EmailTypeTextEntity()
        {
            InitializePartial();
		}

        public long EmailTypeTextId { get; set; }
        public long EmailTypeId { get; set; }
        public string LanguageCode { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string HtmlBody { get; set; }
        public EmailTypeEntity EmailType { get; set; }
        public LanguageEntity Language { get; set; }
             
        partial void InitializePartial();
    }
}
