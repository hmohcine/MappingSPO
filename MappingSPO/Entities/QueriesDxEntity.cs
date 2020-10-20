
namespace MappingSPO.Entities
{
    public partial class QueriesDxEntity
    {
		public QueriesDxEntity()
        {
            IsLocked = false;
            Version = 0;
            ReportsDxes = new System.Collections.Generic.List<ReportsDxEntity>();
            InitializePartial();
		}

        public System.Guid QueryId { get; set; }
        public string XmlQuery { get; set; }
        public bool IsLocked { get; set; }
        public long Version { get; set; }
        public string Name { get; set; }
        public System.Collections.Generic.ICollection<ReportsDxEntity> ReportsDxes { get; set; }
             
        partial void InitializePartial();
    }
}
