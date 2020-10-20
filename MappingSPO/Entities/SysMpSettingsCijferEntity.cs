
namespace MappingSPO.Entities
{
    public partial class SysMpSettingsCijferEntity
    {
		public SysMpSettingsCijferEntity()
        {
            FieldOrder = 0;
            UiKolom = 0;
            SysMpSettingsCijfersLabels = new System.Collections.Generic.List<SysMpSettingsCijfersLabelEntity>();
            InitializePartial();
		}

        public int KolomId { get; set; }
        public string DefaultUiLanguageCode { get; set; }
        public long InkoopCatId { get; set; }
        public int KolomValue { get; set; }
        public int FieldOrder { get; set; }
        public int UiKolom { get; set; }
        public System.Collections.Generic.ICollection<SysMpSettingsCijfersLabelEntity> SysMpSettingsCijfersLabels { get; set; }
        public RelActiviteitEntity RelActiviteit { get; set; }
             
        partial void InitializePartial();
    }
}
