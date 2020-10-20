
namespace MappingSPO.Entities
{
    public partial class WerfPropertiesItemEntity
    {
		public WerfPropertiesItemEntity()
        {
            InitializePartial();
		}

        public string Name { get; set; }
        public int? PType { get; set; }
        public string PDefaultvalue { get; set; }
        public string PListXml { get; set; }
        public int? PUiType { get; set; }
        public bool? AutoAddOnNewWerf { get; set; }
             
        partial void InitializePartial();
    }
}
