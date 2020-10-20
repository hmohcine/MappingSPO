
namespace MappingSPO.Entities
{
    public partial class WinbookEntity
    {
		public WinbookEntity()
        {
            InitializePartial();
		}

        public long Wbid { get; set; }
        public string SourceConnectionString { get; set; }
        public string TargetConnectionString { get; set; }
        public string TargetDocumentLocation { get; set; }
        public string TempLocation { get; set; }
        public string PdfToolLocation { get; set; }
        public string RecognitionQualityFieldName { get; set; }
        public string RecognizedtextFieldName { get; set; }
        public int CommandTimeoutTimeInSeconds { get; set; }
             
        partial void InitializePartial();
    }
}
