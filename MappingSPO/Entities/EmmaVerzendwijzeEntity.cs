
namespace MappingSPO.Entities
{
    public partial class EmmaVerzendwijzeEntity
    {
		public EmmaVerzendwijzeEntity()
        {
            InitializePartial();
		}

        public long VerzendWijzeId { get; set; }
        public string Verzendwijze { get; set; }
             
        partial void InitializePartial();
    }
}
