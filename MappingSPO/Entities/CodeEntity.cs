
namespace MappingSPO.Entities
{
    public partial class CodeEntity
    {
		public CodeEntity()
        {
            Visible = true;
            Required = false;
            InitializePartial();
		}

        public int Id { get; set; }
        public int Context { get; set; }
        public int CodeIndex { get; set; }
        public bool Visible { get; set; }
        public bool Required { get; set; }
             
        partial void InitializePartial();
    }
}
