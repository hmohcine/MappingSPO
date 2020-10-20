
namespace MappingSPO.Entities
{
    public partial class ReportEntity
    {
		public ReportEntity()
        {
            Disabled = false;
            InitializePartial();
		}

        public long ReportId { get; set; }
        public string ReportName { get; set; }
        public string ReportDescription { get; set; }
        public int ReportDomain { get; set; }
        public int ReportType { get; set; }
        public bool IsReportTaxIncl { get; set; }
        public string FileSubDirectory { get; set; }
        public string FileName { get; set; }
        public bool ShowAsStandardReport { get; set; }
        public bool Disabled { get; set; }
        public string LanguageCode { get; set; }
        public int? CompanyId { get; set; }
        public string DesignerName { get; set; }
        public long DesignerId { get; set; }
        public string DesignerNotes { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateLastModified { get; set; }
        public string SearchCode1 { get; set; }
        public string SearchCode2 { get; set; }
        public string SearchCode3 { get; set; }
        public string SearchCode4 { get; set; }
        public int? PriorityOrder { get; set; }
        public string Printer { get; set; }
        public int? DefaultReportId { get; set; }
        public int? VersionMajor { get; set; }
        public int? VersionMinor { get; set; }
        public int? VersionBuild { get; set; }
        public CompanyEntity Company { get; set; }
        public LanguageEntity Language { get; set; }
             
        partial void InitializePartial();
    }
}
