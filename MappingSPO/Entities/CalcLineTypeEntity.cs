
namespace MappingSPO.Entities
{
    public partial class CalcLineTypeEntity
    {
		public CalcLineTypeEntity()
        {
            BColor = -16777216;
            AlternateColor = false;
            AltForeColor = -16777216;
            FullLineMode = false;
            IsDefaultForType = false;
            Code1Required = false;
            Code2Required = false;
            Code3Required = false;
            Code4Required = false;
            Code5Required = false;
            Code6Required = false;
            Code7Required = false;
            Code8Required = false;
            ShouldHaveChildern = false;
            InitializePartial();
		}

        public string CalcLineTypeCode { get; set; }
        public string CalcLineMayorTypeCode { get; set; }
        public string CalcLineTypeDescription { get; set; }
        public string CalcTypeType { get; set; }
        public int? BColor { get; set; }
        public bool? BBold { get; set; }
        public bool? BItalic { get; set; }
        public int? BBackColor { get; set; }
        public bool AlternateColor { get; set; }
        public int? AltForeColor { get; set; }
        public bool? AltBold { get; set; }
        public bool? AltItalic { get; set; }
        public int? AltBackColor { get; set; }
        public bool FullLineMode { get; set; }
        public bool IsDefaultForType { get; set; }
        public bool Code1Required { get; set; }
        public bool Code2Required { get; set; }
        public bool Code3Required { get; set; }
        public bool Code4Required { get; set; }
        public bool Code5Required { get; set; }
        public bool Code6Required { get; set; }
        public bool Code7Required { get; set; }
        public bool Code8Required { get; set; }
        public bool ShouldHaveChildern { get; set; }
             
        partial void InitializePartial();
    }
}
