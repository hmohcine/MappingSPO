
namespace MappingSPO.Entities
{
    public partial class ProjectCode2Entity
    {
		public ProjectCode2Entity()
        {
            InitializePartial();
		}

        public int CodeId { get; set; }
        public string Code { get; set; }
        public bool Disabled { get; set; }
             
        partial void InitializePartial();
    }
}
