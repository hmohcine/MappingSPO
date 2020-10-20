
namespace MappingSPO.Entities
{
    public partial class AutomaticCalcLibraryEntity
    {
		public AutomaticCalcLibraryEntity()
        {
            InitializePartial();
		}

        public long Id { get; set; }
        public long CalcId { get; set; }
        public int Priority { get; set; }
        public AutomaticCalcSettingEntity AutomaticCalcSetting { get; set; }
             
        partial void InitializePartial();
    }
}
