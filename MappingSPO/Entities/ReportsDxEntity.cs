
namespace MappingSPO.Entities
{
    public partial class ReportsDxEntity
    {
		public ReportsDxEntity()
        {
            IsSystemReport = false;
            ReportType = 0;
            ReportLayoutsDxes = new System.Collections.Generic.List<ReportLayoutsDxEntity>();
            ReportsDxFormLinks = new System.Collections.Generic.List<ReportsDxFormLinkEntity>();
            QueriesDxes = new System.Collections.Generic.List<QueriesDxEntity>();
            InitializePartial();
		}

        public System.Guid ReportId { get; set; }
        public string Name { get; set; }
        public bool IsSystemReport { get; set; }
        public int ReportType { get; set; }
        public System.Collections.Generic.ICollection<QueriesDxEntity> QueriesDxes { get; set; }
        public System.Collections.Generic.ICollection<ReportLayoutsDxEntity> ReportLayoutsDxes { get; set; }
        public System.Collections.Generic.ICollection<ReportsDxFormLinkEntity> ReportsDxFormLinks { get; set; }
             
        partial void InitializePartial();
    }
}
