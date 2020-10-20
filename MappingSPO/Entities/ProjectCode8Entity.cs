
namespace MappingSPO.Entities
{
    public partial class ProjectCode8Entity
    {
		public ProjectCode8Entity()
        {
            InitializePartial();
		}

        public int CodeId { get; set; }
        public string Code { get; set; }
        public bool Disabled { get; set; }
             
        partial void InitializePartial();
    }
}
