
namespace MappingSPO.Entities
{
    public partial class DocCode3Entity
    {
		public DocCode3Entity()
        {
            CalcDisabled = false;
            Documents = new System.Collections.Generic.List<DocumentEntity>();
            InitializePartial();
		}

        public long CodeId { get; set; }
        public string CalcCode { get; set; }
        public bool CalcDisabled { get; set; }
        public System.Collections.Generic.ICollection<DocumentEntity> Documents { get; set; }
             
        partial void InitializePartial();
    }
}
