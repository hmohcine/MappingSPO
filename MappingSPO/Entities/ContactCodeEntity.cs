
namespace MappingSPO.Entities
{
    public partial class ContactCodeEntity
    {
		public ContactCodeEntity()
        {
            Disabled = false;
            InitializePartial();
		}

        public long CodeId { get; set; }
        public int CodeIndex { get; set; }
        public bool Disabled { get; set; }
             
        partial void InitializePartial();
    }
}
