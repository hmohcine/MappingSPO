
namespace MappingSPO.Entities
{
    public partial class ContactsMultiAnaCodeEntity
    {
		public ContactsMultiAnaCodeEntity()
        {
            InitializePartial();
		}

        public long MultiId { get; set; }
        public int MultiIndex { get; set; }
        public bool Disable { get; set; }
             
        partial void InitializePartial();
    }
}
