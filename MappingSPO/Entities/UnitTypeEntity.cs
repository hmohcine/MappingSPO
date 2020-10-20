
namespace MappingSPO.Entities
{
    public partial class UnitTypeEntity
    {
		public UnitTypeEntity()
        {
            InitializePartial();
		}

        public long UnittypeId { get; set; }
        public string Unittype { get; set; }
        public string Afkorting { get; set; }
        public string DefaultFormat { get; set; }
             
        partial void InitializePartial();
    }
}
