
namespace MappingSPO.Entities
{
    public partial class EmailTypeEntity
    {
		public EmailTypeEntity()
        {
            EmailTypeTexts = new System.Collections.Generic.List<EmailTypeTextEntity>();
            InitializePartial();
		}

        public long EmailTypeId { get; set; }
        public string ApiKey { get; set; }
        public string FromEmail { get; set; }
        public string CcEmail { get; set; }
        public string BccEmail { get; set; }
        public System.Collections.Generic.ICollection<EmailTypeTextEntity> EmailTypeTexts { get; set; }
             
        partial void InitializePartial();
    }
}
