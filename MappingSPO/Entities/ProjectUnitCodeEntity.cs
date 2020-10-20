
namespace MappingSPO.Entities
{
    public partial class ProjectUnitCodeEntity
    {
		public ProjectUnitCodeEntity()
        {
            Disabled = false;
            InitializePartial();
		}

        public long CodeId { get; set; }
        public int CodeIndex { get; set; }
        public string CodeDescription { get; set; }
        public bool Disabled { get; set; }
             
        partial void InitializePartial();
    }
}
