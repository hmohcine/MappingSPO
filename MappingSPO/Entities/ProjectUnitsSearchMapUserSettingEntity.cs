
namespace MappingSPO.Entities
{
    public partial class ProjectUnitsSearchMapUserSettingEntity
    {
		public ProjectUnitsSearchMapUserSettingEntity()
        {
            InitializePartial();
		}

        public int UserId { get; set; }
        public int MapNr { get; set; }
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
