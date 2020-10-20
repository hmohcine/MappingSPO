
namespace MappingSPO.Entities
{
    public partial class WerfCode5Entity
    {
		public WerfCode5Entity()
        {
            Disabled = false;
            Domain = "C";
            InitializePartial();
		}

        public int CodeId { get; set; }
        public string Code { get; set; }
        public bool? Disabled { get; set; }
        public string Domain { get; set; }
             
        partial void InitializePartial();
    }
}