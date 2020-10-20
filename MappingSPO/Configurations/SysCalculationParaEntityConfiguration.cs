using MappingSPO.Entities;

namespace MappingSPO
{
    public class SysCalculationParaEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SysCalculationParaEntity>
    {
        public SysCalculationParaEntityConfiguration()
            : this("Settings")
        {
        }

        public SysCalculationParaEntityConfiguration(string schema)
        {
            ToTable("tsysCalculationPara", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CalcCode1Caption).HasColumnName(@"CalcCode1Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.CalcCode2Caption).HasColumnName(@"CalcCode2Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.CalcCode3Caption).HasColumnName(@"CalcCode3Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.CalcCode4Caption).HasColumnName(@"CalcCode4Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.CalcCode5Caption).HasColumnName(@"CalcCode5Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.CalcCode6Caption).HasColumnName(@"CalcCode6Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.CalcCode7Caption).HasColumnName(@"CalcCode7Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.CalcCode8Caption).HasColumnName(@"CalcCode8Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.CalcDefaultType).HasColumnName(@"CalcDefaultType").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(x => x.CalcCodeAddMode).HasColumnName(@"CalcCodeAddMode").HasColumnType("int").IsOptional();
            Property(x => x.UcAddMode).HasColumnName(@"UCAddMode").HasColumnType("int").IsOptional();
            Property(x => x.CalcNumberFormat).HasColumnName(@"CalcNumberFormat").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CalcDate1Label).HasColumnName(@"CalcDate1Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.CalcDate2Label).HasColumnName(@"CalcDate2Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.DefaultDigitsUnit).HasColumnName(@"DefaultDigitsUnit").HasColumnType("int").IsOptional();
            Property(x => x.DefaultDigitsTotal).HasColumnName(@"DefaultDigitsTotal").HasColumnType("int").IsOptional();
            Property(x => x.WControlActivated).HasColumnName(@"WControlActivated").HasColumnType("bit").IsOptional();
            Property(x => x.WControlRedTriggerpct).HasColumnName(@"WControlRedTriggerpct").HasColumnType("real").IsOptional();
            Property(x => x.WControlRedOverruleNotPermitted).HasColumnName(@"WControlRedOverruleNotPermitted").HasColumnType("bit").IsOptional();
            Property(x => x.WControlRedOveruleExceptionGroup).HasColumnName(@"WControlRedOveruleExceptionGroup").HasColumnType("int").IsOptional();
            Property(x => x.WControlOrangeTriggerpct).HasColumnName(@"WControlOrangeTriggerpct").HasColumnType("real").IsOptional();
            Property(x => x.WControlOrangeOverruleNotPermitted).HasColumnName(@"WControlOrangeOverruleNotPermitted").HasColumnType("bit").IsOptional();
            Property(x => x.WControlOrangeOveruleExceptionGroup).HasColumnName(@"WControlOrangeOveruleExceptionGroup").HasColumnType("int").IsOptional();
            Property(x => x.DefaultOffetTitle).HasColumnName(@"DefaultOffetTitle").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code1Visible).HasColumnName(@"Code1Visible").HasColumnType("bit").IsOptional();
            Property(x => x.Code2Visible).HasColumnName(@"Code2Visible").HasColumnType("bit").IsOptional();
            Property(x => x.Code3Visible).HasColumnName(@"Code3Visible").HasColumnType("bit").IsOptional();
            Property(x => x.Code4Visible).HasColumnName(@"Code4Visible").HasColumnType("bit").IsOptional();
            Property(x => x.Code5Visible).HasColumnName(@"Code5Visible").HasColumnType("bit").IsOptional();
            Property(x => x.Code6Visible).HasColumnName(@"Code6Visible").HasColumnType("bit").IsOptional();
            Property(x => x.Code7Visible).HasColumnName(@"Code7Visible").HasColumnType("bit").IsOptional();
            Property(x => x.Code8Visible).HasColumnName(@"Code8Visible").HasColumnType("bit").IsOptional();
            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsOptional();
            Property(x => x.DefaultLanguage).HasColumnName(@"DefaultLanguage").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.Ref1Label).HasColumnName(@"Ref1Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Ref2Label).HasColumnName(@"Ref2Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Ref3Label).HasColumnName(@"Ref3Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Ref4Label).HasColumnName(@"Ref4Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtendedIpVerdeling).HasColumnName(@"ExtendedIPVerdeling").HasColumnType("bit").IsOptional();
            Property(x => x.AddonMgt).HasColumnName(@"AddonMGT").HasColumnType("int").IsOptional();
            Property(x => x.ShowDigitsEkp).HasColumnName(@"ShowDigitsEKP").HasColumnType("int").IsOptional();
            Property(x => x.ShowDigitsKp).HasColumnName(@"ShowDigitsKP").HasColumnType("int").IsOptional();
            Property(x => x.ShowDigitsEvp).HasColumnName(@"ShowDigitsEVP").HasColumnType("int").IsOptional();
            Property(x => x.ShowDigitsVp).HasColumnName(@"ShowDigitsVP").HasColumnType("int").IsOptional();
            Property(x => x.ShowDigitsAantal).HasColumnName(@"ShowDigitsAantal").HasColumnType("int").IsOptional();
            Property(x => x.DefaultCalcIdAddTemplates).HasColumnName(@"DefaultCalcIDAddTemplates").HasColumnType("bigint").IsOptional();
            Property(x => x.ToonOpmetingen).HasColumnName(@"ToonOpmetingen").HasColumnType("bit").IsOptional();
            Property(x => x.ToonSamenvatting).HasColumnName(@"ToonSamenvatting").HasColumnType("int").IsOptional();
            Property(x => x.ToonLijnOnder).HasColumnName(@"ToonLijnOnder").HasColumnType("bit").IsOptional();
            Property(x => x.HideTotalsOnHfst).HasColumnName(@"HideTotalsOnHfst").HasColumnType("bit").IsOptional();
            Property(x => x.AutoBackupCalculationMode).HasColumnName(@"AutoBackupCalculationMode").HasColumnType("int").IsOptional();
            Property(x => x.AutoBackupCalculationTimeInDays).HasColumnName(@"AutoBackupCalculationTimeInDays").HasColumnType("int").IsOptional();
            Property(x => x.AutoBackupCalculationMaxSizeMb).HasColumnName(@"AutoBackupCalculationMaxSizeMb").HasColumnType("int").IsOptional();
            Property(x => x.AutoBackupRestoreCalcTypeId).HasColumnName(@"AutoBackupRestoreCalcTypeID").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(x => x.ExtraDate1Caption).HasColumnName(@"ExtraDate1Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDate2Caption).HasColumnName(@"ExtraDate2Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDate3Caption).HasColumnName(@"ExtraDate3Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDate4Caption).HasColumnName(@"ExtraDate4Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDate5Caption).HasColumnName(@"ExtraDate5Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.EnableExtWinstMode).HasColumnName(@"EnableExtWinstMode").HasColumnType("bit").IsOptional();
            Property(x => x.ExtendedWinstMode).HasColumnName(@"ExtendedWinstMode").HasColumnType("int").IsOptional();
            Property(x => x.ShowCustomExtWinstMode).HasColumnName(@"ShowCustomExtWinstMode").HasColumnType("int").IsOptional();
            Property(x => x.Bw01Label).HasColumnName(@"BW01label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Bw02Label).HasColumnName(@"BW02label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Bw03Label).HasColumnName(@"BW03label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Bw04Label).HasColumnName(@"BW04label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.W01Label).HasColumnName(@"W01label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.W02Label).HasColumnName(@"W02label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.W03Label).HasColumnName(@"W03label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.W04Label).HasColumnName(@"W04label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Bw01Default).HasColumnName(@"BW01Default").HasColumnType("float").IsOptional();
            Property(x => x.Bw02Default).HasColumnName(@"BW02Default").HasColumnType("float").IsOptional();
            Property(x => x.Bw03Default).HasColumnName(@"BW03Default").HasColumnType("float").IsOptional();
            Property(x => x.Bw04Default).HasColumnName(@"BW04Default").HasColumnType("float").IsOptional();
            Property(x => x.CalculationDeleteWithMarking).HasColumnName(@"CalculationDeleteWithMarking").HasColumnType("bit").IsRequired();
            Property(x => x.CalcDefaultBtwRegime).HasColumnName(@"CalcDefaultBTWRegime").HasColumnType("int").IsOptional();
            Property(x => x.CalcDefaultVatCode).HasColumnName(@"CalcDefaultVatCode").HasColumnType("int").IsOptional();
            Property(x => x.UpSizeErr011ToError).HasColumnName(@"UpSizeErr_011ToError").HasColumnType("bit").IsRequired();
            Property(x => x.DatagridViewSaveLocation).HasColumnName(@"DatagridViewSaveLocation").HasColumnType("int").IsOptional();
            Property(x => x.ExtraNum1Label).HasColumnName(@"ExtraNum1Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraNum2Label).HasColumnName(@"ExtraNum2Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraNum3Label).HasColumnName(@"ExtraNum3Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraNum4Label).HasColumnName(@"ExtraNum4Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraNum5Label).HasColumnName(@"ExtraNum5Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraNum6Label).HasColumnName(@"ExtraNum6Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraNum7Label).HasColumnName(@"ExtraNum7Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraNum8Label).HasColumnName(@"ExtraNum8Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraNum1LabelDetail).HasColumnName(@"ExtraNum1LabelDetail").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraNum2LabelDetail).HasColumnName(@"ExtraNum2LabelDetail").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraNum3LabelDetail).HasColumnName(@"ExtraNum3LabelDetail").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraNum4LabelDetail).HasColumnName(@"ExtraNum4LabelDetail").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraNum5LabelDetail).HasColumnName(@"ExtraNum5LabelDetail").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraNum6LabelDetail).HasColumnName(@"ExtraNum6LabelDetail").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraNum7LabelDetail).HasColumnName(@"ExtraNum7LabelDetail").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraNum8LabelDetail).HasColumnName(@"ExtraNum8LabelDetail").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.CadCamDefaultType).HasColumnName(@"CadCamDefaultType").HasColumnType("int").IsRequired();
            Property(x => x.SubCalcCode1Caption).HasColumnName(@"SubCalcCode1Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubCalcCode2Caption).HasColumnName(@"SubCalcCode2Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubCalcCode3Caption).HasColumnName(@"SubCalcCode3Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubCalcCode4Caption).HasColumnName(@"SubCalcCode4Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubCalcCode5Caption).HasColumnName(@"SubCalcCode5Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubCalcCode6Caption).HasColumnName(@"SubCalcCode6Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubCalcCode7Caption).HasColumnName(@"SubCalcCode7Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubCalcCode8Caption).HasColumnName(@"SubCalcCode8Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubCalcDate1Label).HasColumnName(@"SubCalcDate1Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubCalcDate2Label).HasColumnName(@"SubCalcDate2Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubExtraDate1Caption).HasColumnName(@"SubExtraDate1Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubExtraDate2Caption).HasColumnName(@"SubExtraDate2Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubExtraDate3Caption).HasColumnName(@"SubExtraDate3Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubExtraDate4Caption).HasColumnName(@"SubExtraDate4Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubExtraDate5Caption).HasColumnName(@"SubExtraDate5Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubRef1Label).HasColumnName(@"SubRef1Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubRef2Label).HasColumnName(@"SubRef2Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubRef3Label).HasColumnName(@"SubRef3Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubRef4Label).HasColumnName(@"SubRef4Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubExtraNum1Label).HasColumnName(@"SubExtraNum1Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubExtraNum2Label).HasColumnName(@"SubExtraNum2Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubExtraNum3Label).HasColumnName(@"SubExtraNum3Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubExtraNum4Label).HasColumnName(@"SubExtraNum4Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubExtraNum5Label).HasColumnName(@"SubExtraNum5Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubExtraNum6Label).HasColumnName(@"SubExtraNum6Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubExtraNum7Label).HasColumnName(@"SubExtraNum7Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubExtraNum8Label).HasColumnName(@"SubExtraNum8Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SubVerantWoordelijke1Label).HasColumnName(@"SubVerantWoordelijke1Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.SubVerantWoordelijke2Label).HasColumnName(@"SubVerantWoordelijke2Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.SubVerantWoordelijke3Label).HasColumnName(@"SubVerantWoordelijke3Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.OaModuleMode).HasColumnName(@"OAModuleMode").HasColumnType("int").IsOptional();
            Property(x => x.KeepAddingOnPostMode).HasColumnName(@"KeepAddingOnPostMode").HasColumnType("bit").IsRequired();
            Property(x => x.DefaultPaCalcIdAddTemplates).HasColumnName(@"DefaultPACalcIDAddTemplates").HasColumnType("bigint").IsOptional();
            Property(x => x.NewCalcUIversion).HasColumnName(@"NewCalcUIversion").HasColumnType("int").IsRequired();
            Property(x => x.BimModelUrl).HasColumnName(@"BimModelURL").HasColumnType("nvarchar").IsOptional().HasMaxLength(4000);
            Property(x => x.ExtraBoolean1Label).HasColumnName(@"ExtraBoolean1Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraBoolean2Label).HasColumnName(@"ExtraBoolean2Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraBoolean3Label).HasColumnName(@"ExtraBoolean3Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraBoolean4Label).HasColumnName(@"ExtraBoolean4Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraBoolean5Label).HasColumnName(@"ExtraBoolean5Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraBoolean6Label).HasColumnName(@"ExtraBoolean6Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraBoolean7Label).HasColumnName(@"ExtraBoolean7Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraBoolean8Label).HasColumnName(@"ExtraBoolean8Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);

            HasOptional(a => a.AutoBackupRestoreCalcType).WithMany(b => b.SysCalculationParas_AutoBackupRestoreCalcTypeId).HasForeignKey(c => c.AutoBackupRestoreCalcTypeId).WillCascadeOnDelete(false);
            HasOptional(a => a.CalcType_CalcDefaultType).WithMany(b => b.SysCalculationParas_CalcDefaultType).HasForeignKey(c => c.CalcDefaultType).WillCascadeOnDelete(false);
            HasOptional(a => a.Company).WithMany(b => b.SysCalculationParas).HasForeignKey(c => c.CompanyId).WillCascadeOnDelete(false);
            HasOptional(a => a.Language).WithMany(b => b.SysCalculationParas).HasForeignKey(c => c.DefaultLanguage).WillCascadeOnDelete(false);
        }
    }
}
