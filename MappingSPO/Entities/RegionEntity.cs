
namespace MappingSPO.Entities
{
    public partial class RegionEntity
    {
		public RegionEntity()
        {
            Cities = new System.Collections.Generic.List<CityEntity>();
            InitializePartial();
		}

        public long RegioId { get; set; }
        public string Regio { get; set; }
        public System.Collections.Generic.ICollection<CityEntity> Cities { get; set; }
             
        partial void InitializePartial();
    }
}
