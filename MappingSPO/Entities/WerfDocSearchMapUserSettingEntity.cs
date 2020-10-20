
namespace MappingSPO.Entities
{
    public partial class WerfDocSearchMapUserSettingEntity
    {
		public WerfDocSearchMapUserSettingEntity()
        {
            InitializePartial();
		}

        public int UserId { get; set; }
        public int MapNr { get; set; }
        public int DocMayorType { get; set; }
        public string MapName { get; set; }
        public string GroupByLevel0 { get; set; }
        public string GroupByLevel1 { get; set; }
        public string GroupByLevel2 { get; set; }
        public string GroupByLevel3 { get; set; }
        public string GroupByLevel4 { get; set; }
        public string GroupByLevel5 { get; set; }
             
        partial void InitializePartial();
    }
}