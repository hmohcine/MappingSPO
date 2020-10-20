
namespace MappingSPO.Entities
{
    public partial class SysMasterProjectSettingEntity
    {
		public SysMasterProjectSettingEntity()
        {
            MasterProjectOn = false;
            CountOfCijfers = 0;
            InitializePartial();
		}

        public long MpId { get; set; }
        public bool MasterProjectOn { get; set; }
        public int CountOfCijfers { get; set; }
        public string MpNrLabelPart1 { get; set; }
        public string MpNrLabelPart2 { get; set; }
        public string MpNrLabelPart3 { get; set; }
        public string MpCodeLabel1 { get; set; }
        public string MpCodeLabel2 { get; set; }
        public string MpCodeLabel3 { get; set; }
        public string MpCodeLabel4 { get; set; }
        public string MpCodeLabel5 { get; set; }
        public string MpCodeLabel6 { get; set; }
        public string MpCodeLabel7 { get; set; }
        public string MpCodeLabel8 { get; set; }
        public string MpDateLabel1 { get; set; }
        public string MpDateLabel2 { get; set; }
        public string MpDateLabel3 { get; set; }
        public string MpDateLabel4 { get; set; }
        public string MpDateLabel5 { get; set; }
        public string MpDateLabel6 { get; set; }
        public string MpDateLabel7 { get; set; }
        public string MpDateLabel8 { get; set; }
        public int? MpDefaultVerValTermijnOptieDays { get; set; }
        public string MpRefLabel1 { get; set; }
        public string MpRefLabel2 { get; set; }
        public string MpRefLabel3 { get; set; }
        public string MpRefLabel4 { get; set; }
        public string MpExtraBooleanLabel1 { get; set; }
        public string MpExtraBooleanLabel2 { get; set; }
        public string MpExtraBooleanLabel3 { get; set; }
        public string MpExtraBooleanLabel4 { get; set; }
        public string MpExtraNumLabel1 { get; set; }
        public string MpExtraNumLabel2 { get; set; }
        public string MpExtraNumLabel3 { get; set; }
        public string MpExtraNumLabel4 { get; set; }
        public string MpExtraNumLabel5 { get; set; }
        public string MpExtraNumLabel6 { get; set; }
        public string MpExtraNumLabel7 { get; set; }
        public string MpExtraNumLabel8 { get; set; }
        public string MpMultiCodeLabel1 { get; set; }
        public string MpMultiCodeLabel2 { get; set; }
        public string MpMultiCodeLabel3 { get; set; }
        public string MpMultiCodeLabel4 { get; set; }
        public string MpMultiCodeLabel5 { get; set; }
        public string MpMultiCodeLabel6 { get; set; }
        public string MpMultiCodeLabel7 { get; set; }
        public string MpMultiCodeLabel8 { get; set; }
             
        partial void InitializePartial();
    }
}
