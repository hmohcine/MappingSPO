
namespace MappingSPO.Entities
{
    public partial class SysProjectSettingEntity
    {
		public SysProjectSettingEntity()
        {
            InitializePartial();
		}

        public string Id { get; set; }
        public string LabelProjectVerantWoordelijke1 { get; set; }
        public string LabelProjectVerantWoordelijke2 { get; set; }
        public string LabelProjectVerantWoordelijke3 { get; set; }
        public long? ProjectMode { get; set; }
        public string Code1Caption { get; set; }
        public string Code2Caption { get; set; }
        public string Code3Caption { get; set; }
        public string Code4Caption { get; set; }
        public string Code5Caption { get; set; }
        public string Code6Caption { get; set; }
        public string Code7Caption { get; set; }
        public string Code8Caption { get; set; }
        public string Ref1Label { get; set; }
        public string Ref2Label { get; set; }
        public string Ref3Label { get; set; }
        public string Ref4Label { get; set; }
        public string SmtpServer { get; set; }
        public string ReplayAdress { get; set; }
        public string ExtraTextOnBody { get; set; }
        public string ExtraDate1Caption { get; set; }
        public string ExtraDate2Caption { get; set; }
        public string ExtraDate3Caption { get; set; }
        public string ExtraDate4Caption { get; set; }
        public string ExtraDate5Caption { get; set; }
        public string ExtraDate6Caption { get; set; }
        public string ExtraDate7Caption { get; set; }
        public string ExtaNumLabel1 { get; set; }
        public string ExtaNumLabel2 { get; set; }
        public string ExtaNumLabel3 { get; set; }
        public string ExtaNumLabel4 { get; set; }
        public string ExtaNumLabel5 { get; set; }
        public string ExtaNumLabel6 { get; set; }
        public string ExtaNumLabel7 { get; set; }
        public string ExtaNumLabel8 { get; set; }
        public string ExtaNumShortLabel1 { get; set; }
        public string ExtaNumShortLabel2 { get; set; }
        public string ExtaNumShortLabel3 { get; set; }
        public string ExtaNumShortLabel4 { get; set; }
        public string ExtaNumShortLabel5 { get; set; }
        public string ExtaNumShortLabel6 { get; set; }
        public string ExtaNumShortLabel7 { get; set; }
        public string ExtaNumShortLabel8 { get; set; }
        public bool? SumExtraNum1 { get; set; }
        public bool? SumExtraNum2 { get; set; }
        public bool? SumExtraNum3 { get; set; }
        public bool? SumExtraNum4 { get; set; }
        public bool? SumExtraNum5 { get; set; }
        public bool? SumExtraNum6 { get; set; }
        public bool? SumExtraNum7 { get; set; }
        public bool? SumExtraNum8 { get; set; }
             
        partial void InitializePartial();
    }
}
