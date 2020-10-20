
namespace MappingSPO.Entities
{
    public partial class WinbooksCompanyTableEntity
    {
		public WinbooksCompanyTableEntity()
        {
            InitializePartial();
		}

        public long Wbid { get; set; }
        public long CompanyId { get; set; }
        public long TableId { get; set; }
        public string CompanyKey { get; set; }
        public string SourceFileName { get; set; }
        public string Memo { get; set; }
        public string TargetTable { get; set; }
             
        partial void InitializePartial();
    }
}
