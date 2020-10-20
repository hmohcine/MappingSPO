
namespace MappingSPO.Entities
{
    public partial class TransportMiddelEntity
    {
		public TransportMiddelEntity()
        {
            InitializePartial();
		}

        public string TransportMiddelId { get; set; }
        public string TransportDescription { get; set; }
        public string Bestuurder { get; set; }
        public string BestuurderGsm { get; set; }
        public int Volgorde { get; set; }
             
        partial void InitializePartial();
    }
}
