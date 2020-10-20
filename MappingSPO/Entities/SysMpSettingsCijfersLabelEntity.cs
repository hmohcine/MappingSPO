
namespace MappingSPO.Entities
{
    public partial class SysMpSettingsCijfersLabelEntity
    {
		public SysMpSettingsCijfersLabelEntity()
        {
            InitializePartial();
		}

        public int KolomId { get; set; }
        public string UiLanguageCode { get; set; }
        public string KolomLabel { get; set; }
        public SysMpSettingsCijferEntity SysMpSettingsCijfer { get; set; }
             
        partial void InitializePartial();
    }
}
