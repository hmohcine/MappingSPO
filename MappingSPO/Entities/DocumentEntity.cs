
namespace MappingSPO.Entities
{
    public partial class DocumentEntity
    {
		public DocumentEntity()
        {
            DocumentMasterType = 0;
            InitializePartial();
		}

        public long DocumentId { get; set; }
        public string Name { get; set; }
        public string ExtentionId { get; set; }
        public string Alias { get; set; }
        public string SubPath { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
        public string Notes { get; set; }
        public long? Code1 { get; set; }
        public long? Code2 { get; set; }
        public long? Code3 { get; set; }
        public long? Code4 { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public long? ArchiveId { get; set; }
        public int DocumentMasterType { get; set; }
        public int? MasterOwnerUserId { get; set; }
        public int? Location { get; set; }
        public int? Direction { get; set; }
        public string MailBcc { get; set; }
        public string MailCc { get; set; }
        public string MailTo { get; set; }
        public int? MailImportence { get; set; }
        public string MailSenderName { get; set; }
        public string MailSenderEmail { get; set; }
        public int? MailType { get; set; }
        public long? DocStateId { get; set; }
        public int? OldCreatedById { get; set; }
        public string FullAlias { get; private set; }
        public long? ActiviteitId { get; set; }
        public long? InkoopCatId { get; set; }
        public long? VerkoopCatId { get; set; }
        public ActiviteitenEntity Activiteiten { get; set; }
        public DocCode1Entity DocCode1 { get; set; }
        public DocCode2Entity DocCode2 { get; set; }
        public DocCode3Entity DocCode3 { get; set; }
        public DocCode4Entity DocCode4 { get; set; }
        public RelActiviteitEntity InkoopCat { get; set; }
        public RelActiviteitEntity VerkoopCat { get; set; }
        public UserEntity User { get; set; }
             
        partial void InitializePartial();
    }
}
