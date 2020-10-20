
namespace MappingSPO.Entities
{
    public partial class ReportLayoutsDxEntity
    {
		public ReportLayoutsDxEntity()
        {
            Version = 0;
            InitializePartial();
		}

        public System.Guid ReportId { get; set; }
        public string LangCode { get; set; }
        public byte[] Layout { get; set; }
        public long Version { get; set; }
        public LanguageEntity Language { get; set; }
        public ReportsDxEntity ReportsDx { get; set; }
             
        partial void InitializePartial();
    }
}
