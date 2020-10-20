
namespace MappingSPO.Entities
{
    public partial class ExternalDatabaseEntity
    {
		public ExternalDatabaseEntity()
        {
            InitializePartial();
		}

        public int ExternalDbid { get; set; }
        public string ExternalDbName { get; set; }
        public System.DateTime? StartLastSync { get; set; }
        public System.DateTime? EndLastSync { get; set; }
        public long SupplierId { get; set; }
             
        partial void InitializePartial();
    }
}
