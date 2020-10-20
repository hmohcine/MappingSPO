
namespace MappingSPO.Entities
{
    public partial class ContactTypeEntity
    {
		public ContactTypeEntity()
        {
            InitializePartial();
		}

        public int ContactTypeId { get; set; }
        public string ContactType_ { get; set; }
        public int? MasterType { get; set; }
             
        partial void InitializePartial();
    }
}
