
namespace MappingSPO.Entities
{
    public partial class SysCalculationParaEntity
    {
		public SysCalculationParaEntity()
        {
            CalculationDeleteWithMarking = true;
            UpSizeErr011ToError = false;
            CadCamDefaultType = 0;
            KeepAddingOnPostMode = false;
            NewCalcUIversion = 0;
            EnablePocs = false;
            InitializePartial();
		}

        public int Id { get; set; }
        public string CalcCode1Caption { get; set; }
        public string CalcCode2Caption { get; set; }
        public string CalcCode3Caption { get; set; }
        public string CalcCode4Caption { get; set; }
        public string CalcCode5Caption { get; set; }
        public string CalcCode6Caption { get; set; }
        public string CalcCode7Caption { get; set; }
        public string CalcCode8Caption { get; set; }
        public string CalcDefaultType { get; set; }
        public int? CalcCodeAddMode { get; set; }
        public int? UcAddMode { get; set; }
        public string CalcNumberFormat { get; set; }
        public string CalcDate1Label { get; set; }
        public string CalcDate2Label { get; set; }
        public int? DefaultDigitsUnit { get; set; }
        public int? DefaultDigitsTotal { get; set; }
        public bool? WControlActivated { get; set; }
        public float? WControlRedTriggerpct { get; set; }
        public bool? WControlRedOverruleNotPermitted { get; set; }
        public int? WControlRedOveruleExceptionGroup { get; set; }
        public float? WControlOrangeTriggerpct { get; set; }
        public bool? WControlOrangeOverruleNotPermitted { get; set; }
        public int? WControlOrangeOveruleExceptionGroup { get; set; }
        public string DefaultOffetTitle { get; set; }
        public bool? Code1Visible { get; set; }
        public bool? Code2Visible { get; set; }
        public bool? Code3Visible { get; set; }
        public bool? Code4Visible { get; set; }
        public bool? Code5Visible { get; set; }
        public bool? Code6Visible { get; set; }
        public bool? Code7Visible { get; set; }
        public bool? Code8Visible { get; set; }
        public int? CompanyId { get; set; }
        public string DefaultLanguage { get; set; }
        public string Ref1Label { get; set; }
        public string Ref2Label { get; set; }
        public string Ref3Label { get; set; }
        public string Ref4Label { get; set; }
        public bool? ExtendedIpVerdeling { get; set; }
        public int? AddonMgt { get; set; }
        public int? ShowDigitsEkp { get; set; }
        public int? ShowDigitsKp { get; set; }
        public int? ShowDigitsEvp { get; set; }
        public int? ShowDigitsVp { get; set; }
        public int? ShowDigitsAantal { get; set; }
        public long? DefaultCalcIdAddTemplates { get; set; }
        public bool? ToonOpmetingen { get; set; }
        public int? ToonSamenvatting { get; set; }
        public bool? ToonLijnOnder { get; set; }
        public bool? HideTotalsOnHfst { get; set; }
        public int? AutoBackupCalculationMode { get; set; }
        public int? AutoBackupCalculationTimeInDays { get; set; }
        public int? AutoBackupCalculationMaxSizeMb { get; set; }
        public string AutoBackupRestoreCalcTypeId { get; set; }
        public string ExtraDate1Caption { get; set; }
        public string ExtraDate2Caption { get; set; }
        public string ExtraDate3Caption { get; set; }
        public string ExtraDate4Caption { get; set; }
        public string ExtraDate5Caption { get; set; }
        public bool? EnableExtWinstMode { get; set; }
        public int? ExtendedWinstMode { get; set; }
        public int? ShowCustomExtWinstMode { get; set; }
        public string Bw01Label { get; set; }
        public string Bw02Label { get; set; }
        public string Bw03Label { get; set; }
        public string Bw04Label { get; set; }
        public string W01Label { get; set; }
        public string W02Label { get; set; }
        public string W03Label { get; set; }
        public string W04Label { get; set; }
        public double? Bw01Default { get; set; }
        public double? Bw02Default { get; set; }
        public double? Bw03Default { get; set; }
        public double? Bw04Default { get; set; }
        public bool CalculationDeleteWithMarking { get; set; }
        public int? CalcDefaultBtwRegime { get; set; }
        public int? CalcDefaultVatCode { get; set; }
        public bool UpSizeErr011ToError { get; set; }
        public int? DatagridViewSaveLocation { get; set; }
        public string ExtraNum1Label { get; set; }
        public string ExtraNum2Label { get; set; }
        public string ExtraNum3Label { get; set; }
        public string ExtraNum4Label { get; set; }
        public string ExtraNum5Label { get; set; }
        public string ExtraNum6Label { get; set; }
        public string ExtraNum7Label { get; set; }
        public string ExtraNum8Label { get; set; }
        public string ExtraNum1LabelDetail { get; set; }
        public string ExtraNum2LabelDetail { get; set; }
        public string ExtraNum3LabelDetail { get; set; }
        public string ExtraNum4LabelDetail { get; set; }
        public string ExtraNum5LabelDetail { get; set; }
        public string ExtraNum6LabelDetail { get; set; }
        public string ExtraNum7LabelDetail { get; set; }
        public string ExtraNum8LabelDetail { get; set; }
        public int CadCamDefaultType { get; set; }
        public string SubCalcCode1Caption { get; set; }
        public string SubCalcCode2Caption { get; set; }
        public string SubCalcCode3Caption { get; set; }
        public string SubCalcCode4Caption { get; set; }
        public string SubCalcCode5Caption { get; set; }
        public string SubCalcCode6Caption { get; set; }
        public string SubCalcCode7Caption { get; set; }
        public string SubCalcCode8Caption { get; set; }
        public string SubCalcDate1Label { get; set; }
        public string SubCalcDate2Label { get; set; }
        public string SubExtraDate1Caption { get; set; }
        public string SubExtraDate2Caption { get; set; }
        public string SubExtraDate3Caption { get; set; }
        public string SubExtraDate4Caption { get; set; }
        public string SubExtraDate5Caption { get; set; }
        public string SubRef1Label { get; set; }
        public string SubRef2Label { get; set; }
        public string SubRef3Label { get; set; }
        public string SubRef4Label { get; set; }
        public string SubExtraNum1Label { get; set; }
        public string SubExtraNum2Label { get; set; }
        public string SubExtraNum3Label { get; set; }
        public string SubExtraNum4Label { get; set; }
        public string SubExtraNum5Label { get; set; }
        public string SubExtraNum6Label { get; set; }
        public string SubExtraNum7Label { get; set; }
        public string SubExtraNum8Label { get; set; }
        public string SubVerantWoordelijke1Label { get; set; }
        public string SubVerantWoordelijke2Label { get; set; }
        public string SubVerantWoordelijke3Label { get; set; }
        public int? OaModuleMode { get; set; }
        public bool KeepAddingOnPostMode { get; set; }
        public long? DefaultPaCalcIdAddTemplates { get; set; }
        public int NewCalcUIversion { get; set; }
        public string BimModelUrl { get; set; }
        public string ExtraBoolean1Label { get; set; }
        public string ExtraBoolean2Label { get; set; }
        public string ExtraBoolean3Label { get; set; }
        public string ExtraBoolean4Label { get; set; }
        public string ExtraBoolean5Label { get; set; }
        public string ExtraBoolean6Label { get; set; }
        public string ExtraBoolean7Label { get; set; }
        public string ExtraBoolean8Label { get; set; }
        public bool EnablePocs { get; set; }
        public CalcTypeEntity AutoBackupRestoreCalcType { get; set; }
        public CalcTypeEntity CalcType_CalcDefaultType { get; set; }
        public CompanyEntity Company { get; set; }
        public LanguageEntity Language { get; set; }
             
        partial void InitializePartial();
    }
}
