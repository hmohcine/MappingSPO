
namespace MappingSPO.Entities
{
    public partial class RelationsContactEntity
    {
		public RelationsContactEntity()
        {
            InitializePartial();
		}

        public long RelationId { get; set; }
        public int ContactId { get; set; }
        public string Notes { get; set; }
        public string Gsm { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public bool? Disabled { get; set; }
        public string SGsm { get; private set; }
        public string SPhone { get; private set; }
        public string SFax { get; private set; }
        public long? AccId { get; set; }
        public string AccType { get; set; }
        public ContactEntity Contact { get; set; }
        public RelationEntity Relation { get; set; }
             
        partial void InitializePartial();
    }
}
