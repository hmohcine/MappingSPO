
namespace MappingSPO.Entities
{
    public partial class DocumentTypeEntity
    {
		public DocumentTypeEntity()
        {
            InitializePartial();
		}

        public long DocTypeId { get; set; }
        public string DocType { get; set; }
             
        partial void InitializePartial();
    }
}
