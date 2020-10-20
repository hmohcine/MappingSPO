
namespace MappingSPO.Entities
{
    public partial class WinbooksCompanyEntity
    {
		public WinbooksCompanyEntity()
        {
            InitializePartial();
		}

        public long Wbid { get; set; }
        public long CompanyId { get; set; }
        public string CompanyKey { get; set; }
        public string SourceFolder { get; set; }
             
        partial void InitializePartial();
    }
}
