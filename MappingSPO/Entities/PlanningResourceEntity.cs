
namespace MappingSPO.Entities
{
    public partial class PlanningResourceEntity
    {
		public PlanningResourceEntity()
        {
            Disabled = false;
            ShowTransportOnLeverbon = false;
            InitializePartial();
		}

        public long ResourceId { get; set; }
        public string Afkorting { get; set; }
        public string Resource { get; set; }
        public bool Disabled { get; set; }
        public int LineOrder { get; set; }
        public bool ShowTransportOnLeverbon { get; set; }
             
        partial void InitializePartial();
    }
}
