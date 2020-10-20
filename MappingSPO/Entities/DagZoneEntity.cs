
namespace MappingSPO.Entities
{
    public partial class DagZoneEntity
    {
		public DagZoneEntity()
        {
            InitializePartial();
		}

        public string DagZone_ { get; set; }
        public string DagZoneDescription { get; set; }
        public int Volgorde { get; set; }
             
        partial void InitializePartial();
    }
}
