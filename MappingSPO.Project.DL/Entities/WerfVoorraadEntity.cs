
namespace MappingSPO.Project.DL.Entities
{
    public partial class WerfVoorraadEntity
    {
		public WerfVoorraadEntity()
        {
            InitializePartial();
		}

        public long DetailId { get; set; }
        public long WerfId { get; set; }
        public long? Voorraad { get; set; }
        public string FullCode { get; set; }
        public WerfEntity Werf { get; set; }
             
        partial void InitializePartial();
    }
}
