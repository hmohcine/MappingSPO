
namespace MappingSPO.Entities
{
    public partial class ProjectCode7Entity
    {
		public ProjectCode7Entity()
        {
            InitializePartial();
		}

        public int CodeId { get; set; }
        public string Code { get; set; }
        public bool Disabled { get; set; }
             
        partial void InitializePartial();
    }
}
