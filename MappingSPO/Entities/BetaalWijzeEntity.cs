
namespace MappingSPO.Entities
{
    public partial class BetaalWijzeEntity
    {
		public BetaalWijzeEntity()
        {
            InitializePartial();
		}

        public long BetaalwijzeId { get; set; }
        public string BetaalwijzeDescription { get; set; }
             
        partial void InitializePartial();
    }
}
