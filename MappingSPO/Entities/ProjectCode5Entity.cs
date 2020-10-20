
namespace MappingSPO.Entities
{
    public partial class ProjectCode5Entity
    {
		public ProjectCode5Entity()
        {
            InitializePartial();
		}

        public int CodeId { get; set; }
        public string Code { get; set; }
        public bool Disabled { get; set; }
             
        partial void InitializePartial();
    }
}
