
namespace MappingSPO.Entities
{
    public partial class DocCode1Entity
    {
		public DocCode1Entity()
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