
namespace MappingSPO.Entities
{
    public partial class QueryEntity
    {
		public QueryEntity()
        {
            Enabled = true;
            UserGroupId = 1;
            InitializePartial();
		}

        public long Number { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public string SpCreateStatement { get; set; }
        public System.DateTime? DesignDate { get; set; }
        public string Copyright { get; set; }
        public bool Enabled { get; set; }
        public int UserGroupId { get; set; }
        public int Creator { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string TableNames { get; set; }
        public int? DefaultTimeoutInSec { get; set; }
        public UserEntity User { get; set; }
        public UsersGroepEntity UsersGroep { get; set; }
             
        partial void InitializePartial();
    }
}
