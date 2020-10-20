using MappingSPO.Entities;

namespace MappingSPO
{
    public class SysWerfParaEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SysWerfParaEntity>
    {
        public SysWerfParaEntityConfiguration()
            : this("Settings")
        {
        }

        public SysWerfParaEntityConfiguration(string schema)
        {
            ToTable("tsysWerfPara", schema);
            HasKey(x => x.Id1);

            Property(x => x.Id1).HasColumnName(@"ID1").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.WerfDefaultType).HasColumnName(@"WerfDefaultType").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(x => x.WerfNumberFormat).HasColumnName(@"WerfNumberFormat").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WerfDate1Label).HasColumnName(@"WerfDate1Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.WerfDate2Label).HasColumnName(@"WerfDate2Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.WerfCode1Caption).HasColumnName(@"WerfCode1Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.WerfCode2Caption).HasColumnName(@"WerfCode2Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.WerfCode3Caption).HasColumnName(@"WerfCode3Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.WerfCode4Caption).HasColumnName(@"WerfCode4Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.WerfCode5Caption).HasColumnName(@"WerfCode5Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.WerfCode6Caption).HasColumnName(@"WerfCode6Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.WerfCode7Caption).HasColumnName(@"WerfCode7Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.WerfCode8Caption).HasColumnName(@"WerfCode8Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.OfferShowOnPart).HasColumnName(@"OfferShowOnPart").HasColumnType("int").IsRequired();
            Property(x => x.OfferShowOverOnPart).HasColumnName(@"OfferShowOverOnPart").HasColumnType("int").IsRequired();
            Property(x => x.ExtentionShowOnPart).HasColumnName(@"ExtentionShowOnPart").HasColumnType("int").IsRequired();
            Property(x => x.ExtentionShowOverOnPart).HasColumnName(@"ExtentionShowOverOnPart").HasColumnType("int").IsRequired();
            Property(x => x.WerfCategory).HasColumnName(@"WerfCategory").HasColumnType("int").IsRequired();
            Property(x => x.FacturationMode).HasColumnName(@"FacturationMode").HasColumnType("int").IsOptional();
            Property(x => x.VordStructModeStaat1).HasColumnName(@"VordStructModeStaat1").HasColumnType("int").IsRequired();
            Property(x => x.VordStructModeStaat2).HasColumnName(@"VordStructModeStaat2").HasColumnType("int").IsRequired();
            Property(x => x.VordStructModeStaat3).HasColumnName(@"VordStructModeStaat3").HasColumnType("int").IsRequired();
            Property(x => x.VordPostMode1).HasColumnName(@"VordPostMode1").HasColumnType("int").IsRequired();
            Property(x => x.VordDetailMode).HasColumnName(@"VordDetailMode").HasColumnType("int").IsRequired();
            Property(x => x.VordHerzieningMode).HasColumnName(@"VordHerzieningMode").HasColumnType("int").IsRequired();
            Property(x => x.VordSamenvattingMode).HasColumnName(@"VordSamenvattingMode").HasColumnType("int").IsRequired();
            Property(x => x.VordSchuldVorderingMode).HasColumnName(@"VordSchuldVorderingMode").HasColumnType("int").IsRequired();
            Property(x => x.VordPostMode2).HasColumnName(@"VordPostMode2").HasColumnType("int").IsRequired();
            Property(x => x.VordPostMode3).HasColumnName(@"VordPostMode3").HasColumnType("int").IsRequired();
            Property(x => x.InvoiceDefaultBtwRegime).HasColumnName(@"InvoiceDefaultBTWRegime").HasColumnType("int").IsOptional();
            Property(x => x.InvoiceDefaultVatCode).HasColumnName(@"InvoiceDefaultVatCode").HasColumnType("int").IsOptional();
            Property(x => x.SysInvoiceAutoDirectState2).HasColumnName(@"SysInvoiceAutoDirectState2").HasColumnType("bit").IsOptional();
            Property(x => x.DefaultWerkCode).HasColumnName(@"DefaultWerkCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.CostDigitsUnit).HasColumnName(@"CostDigitsUnit").HasColumnType("int").IsOptional();
            Property(x => x.CostDigitsTotal).HasColumnName(@"CostDigitsTotal").HasColumnType("int").IsOptional();
            Property(x => x.Ref1Label).HasColumnName(@"Ref1Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Ref2Label).HasColumnName(@"Ref2Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Ref3Label).HasColumnName(@"Ref3Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Ref4Label).HasColumnName(@"Ref4Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.InvoiceDefaultCompanyId).HasColumnName(@"InvoiceDefaultCompanyID").HasColumnType("int").IsOptional();
            Property(x => x.DefaultMagazijnId).HasColumnName(@"DefaultMagazijnID").HasColumnType("bigint").IsOptional();
            Property(x => x.Cncekp).HasColumnName(@"CNCEKP").HasColumnType("int").IsOptional();
            Property(x => x.Cncevp).HasColumnName(@"CNCEVP").HasColumnType("int").IsOptional();
            Property(x => x.ListReadOnly).HasColumnName(@"ListReadOnly").HasColumnType("bit").IsOptional();
            Property(x => x.AddPostenToVordMode).HasColumnName(@"AddPostenToVordMode").HasColumnType("int").IsOptional();
            Property(x => x.AutoCreateCostYn).HasColumnName(@"AutoCreateCostYn").HasColumnType("bit").IsOptional();
            Property(x => x.AutoCreateCostTemplate).HasColumnName(@"AutoCreateCostTemplate").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.ExtraLeveradres1).HasColumnName(@"ExtraLeveradres1").HasColumnType("bigint").IsOptional();
            Property(x => x.AssistDefaultDeliveryType).HasColumnName(@"AssistDefaultDeliveryType").HasColumnType("int").IsOptional();
            Property(x => x.WerfAnalyseMode).HasColumnName(@"WerfAnalyseMode").HasColumnType("int").IsRequired();
            Property(x => x.AssistAutoCreateWerfLijst).HasColumnName(@"AssistAutoCreateWerfLijst").HasColumnType("bit").IsOptional();
            Property(x => x.AssistAutoOkWerfLijst).HasColumnName(@"AssistAutoOKWerfLijst").HasColumnType("bit").IsOptional();
            Property(x => x.LabelProjectLeider).HasColumnName(@"LabelProjectLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.LabelWerfLeider).HasColumnName(@"LabelWerfLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.AutoAssistOnNewWerfPartMode).HasColumnName(@"AutoAssistOnNewWerfPartMode").HasColumnType("int").IsOptional();
            Property(x => x.AutoAddRequiredRelations).HasColumnName(@"AutoAddRequiredRelations").HasColumnType("bit").IsOptional();
            Property(x => x.AutoVatMode).HasColumnName(@"AutoVatMode").HasColumnType("int").IsOptional();
            Property(x => x.AutoAddProject).HasColumnName(@"AutoAddProject").HasColumnType("bit").IsOptional();
            Property(x => x.CustomSpAddItemsToWerfLijst).HasColumnName(@"CustomSPAddItemsToWerfLijst").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.DefaultDuurVerificatieTermijn).HasColumnName(@"DefaultDuurVerificatieTermijn").HasColumnType("int").IsOptional();
            Property(x => x.DefaultVerwijlIntrestRentevoet).HasColumnName(@"DefaultVerwijlIntrestRentevoet").HasColumnType("decimal").IsOptional().HasPrecision(18,6);
            Property(x => x.ExtNumberLabel).HasColumnName(@"ExtNumberLabel").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtNumberMode).HasColumnName(@"ExtNumberMode").HasColumnType("int").IsOptional();
            Property(x => x.VordShowSubTotalsOnHfst).HasColumnName(@"VordShowSubTotalsOnHfst").HasColumnType("bit").IsOptional();
            Property(x => x.ExtraNum1Label).HasColumnName(@"ExtraNum1Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraNum2Label).HasColumnName(@"ExtraNum2Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraNum3Label).HasColumnName(@"ExtraNum3Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraNum4Label).HasColumnName(@"ExtraNum4Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraNum5Label).HasColumnName(@"ExtraNum5Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraNum6Label).HasColumnName(@"ExtraNum6Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraNum7Label).HasColumnName(@"ExtraNum7Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraNum8Label).HasColumnName(@"ExtraNum8Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtaNumShortLabel1).HasColumnName(@"ExtaNumShortLabel1").HasColumnType("nvarchar").IsOptional().HasMaxLength(8);
            Property(x => x.ExtaNumShortLabel2).HasColumnName(@"ExtaNumShortLabel2").HasColumnType("nvarchar").IsOptional().HasMaxLength(8);
            Property(x => x.ExtaNumShortLabel3).HasColumnName(@"ExtaNumShortLabel3").HasColumnType("nvarchar").IsOptional().HasMaxLength(8);
            Property(x => x.ExtaNumShortLabel4).HasColumnName(@"ExtaNumShortLabel4").HasColumnType("nvarchar").IsOptional().HasMaxLength(8);
            Property(x => x.ExtaNumShortLabel5).HasColumnName(@"ExtaNumShortLabel5").HasColumnType("nvarchar").IsOptional().HasMaxLength(8);
            Property(x => x.ExtaNumShortLabel6).HasColumnName(@"ExtaNumShortLabel6").HasColumnType("nvarchar").IsOptional().HasMaxLength(8);
            Property(x => x.ExtaNumShortLabel7).HasColumnName(@"ExtaNumShortLabel7").HasColumnType("nvarchar").IsOptional().HasMaxLength(8);
            Property(x => x.ExtaNumShortLabel8).HasColumnName(@"ExtaNumShortLabel8").HasColumnType("nvarchar").IsOptional().HasMaxLength(8);
            Property(x => x.SumExtraNum1).HasColumnName(@"SumExtraNum1").HasColumnType("bit").IsOptional();
            Property(x => x.SumExtraNum2).HasColumnName(@"SumExtraNum2").HasColumnType("bit").IsOptional();
            Property(x => x.SumExtraNum3).HasColumnName(@"SumExtraNum3").HasColumnType("bit").IsOptional();
            Property(x => x.SumExtraNum4).HasColumnName(@"SumExtraNum4").HasColumnType("bit").IsOptional();
            Property(x => x.SumExtraNum5).HasColumnName(@"SumExtraNum5").HasColumnType("bit").IsOptional();
            Property(x => x.SumExtraNum6).HasColumnName(@"SumExtraNum6").HasColumnType("bit").IsOptional();
            Property(x => x.SumExtraNum7).HasColumnName(@"SumExtraNum7").HasColumnType("bit").IsOptional();
            Property(x => x.SumExtraNum8).HasColumnName(@"SumExtraNum8").HasColumnType("bit").IsOptional();
            Property(x => x.VordShowCncMode).HasColumnName(@"VordShowCNCMode").HasColumnType("int").IsOptional();
            Property(x => x.VordShowDigitsUnits).HasColumnName(@"VordShowDigitsUnits").HasColumnType("int").IsOptional();
            Property(x => x.VordShowDigitsEprijs).HasColumnName(@"VordShowDigitsEprijs").HasColumnType("int").IsOptional();
            Property(x => x.VordShowDigitsPrijs).HasColumnName(@"VordShowDigitsPrijs").HasColumnType("int").IsOptional();
            Property(x => x.OaContractCode1Caption).HasColumnName(@"OAContractCode1Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.OaContractCode2Caption).HasColumnName(@"OAContractCode2Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.OaContractCode3Caption).HasColumnName(@"OAContractCode3Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.OaContractCode4Caption).HasColumnName(@"OAContractCode4Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.OaContractCode5Caption).HasColumnName(@"OAContractCode5Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.OaContractCode6Caption).HasColumnName(@"OAContractCode6Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.OaContractCode7Caption).HasColumnName(@"OAContractCode7Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.OaContractCode8Caption).HasColumnName(@"OAContractCode8Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.OaContractRef1Label).HasColumnName(@"OAContractRef1Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.OaContractRef2Label).HasColumnName(@"OAContractRef2Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.OaContractRef3Label).HasColumnName(@"OAContractRef3Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.OaContractRef4Label).HasColumnName(@"OAContractRef4Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.OaContractDate1Label).HasColumnName(@"OAContractDate1Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.OaContractDate2Label).HasColumnName(@"OAContractDate2Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.OaContractLabelVerantw1).HasColumnName(@"OAContractLabelVerantw1").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.OaContractLabelVerantw2).HasColumnName(@"OAContractLabelVerantw2").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.MultiAnaCode1Label).HasColumnName(@"MultiAnaCode1Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.MultiAnaCode2Label).HasColumnName(@"MultiAnaCode2Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.MultiAnaCode3Label).HasColumnName(@"MultiAnaCode3Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.MultiAnaCode4Label).HasColumnName(@"MultiAnaCode4Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.MultiAnaCode5Label).HasColumnName(@"MultiAnaCode5Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.MultiAnaCode6Label).HasColumnName(@"MultiAnaCode6Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.MultiAnaCode7Label).HasColumnName(@"MultiAnaCode7Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.MultiAnaCode8Label).HasColumnName(@"MultiAnaCode8Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ContractOaDefaultType).HasColumnName(@"ContractOADefaultType").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(x => x.ExtraDateWerfLabel1).HasColumnName(@"ExtraDateWerfLabel1").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDateWerfLabel2).HasColumnName(@"ExtraDateWerfLabel2").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDateWerfLabel3).HasColumnName(@"ExtraDateWerfLabel3").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDateWerfLabel4).HasColumnName(@"ExtraDateWerfLabel4").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDateWerfLabel5).HasColumnName(@"ExtraDateWerfLabel5").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDateWerfLabel6).HasColumnName(@"ExtraDateWerfLabel6").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDateWerfLabel7).HasColumnName(@"ExtraDateWerfLabel7").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDateWerfLabel8).HasColumnName(@"ExtraDateWerfLabel8").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDateContractOaLabel1).HasColumnName(@"ExtraDateContractOALabel1").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDateContractOaLabel2).HasColumnName(@"ExtraDateContractOALabel2").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDateContractOaLabel3).HasColumnName(@"ExtraDateContractOALabel3").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDateContractOaLabel4).HasColumnName(@"ExtraDateContractOALabel4").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDateContractOaLabel5).HasColumnName(@"ExtraDateContractOALabel5").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDateContractOaLabel6).HasColumnName(@"ExtraDateContractOALabel6").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDateContractOaLabel7).HasColumnName(@"ExtraDateContractOALabel7").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDateContractOaLabel8).HasColumnName(@"ExtraDateContractOALabel8").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.DefaultVerkoopCat).HasColumnName(@"DefaultVerkoopCat").HasColumnType("bigint").IsOptional();
            Property(x => x.DefaultInkoopCat).HasColumnName(@"DefaultInkoopCat").HasColumnType("bigint").IsOptional();
            Property(x => x.AutoAssistForVerkoopCatMode).HasColumnName(@"AutoAssistForVerkoopCatMode").HasColumnType("int").IsOptional();
            Property(x => x.AutoVerkoopCatMode).HasColumnName(@"AutoVerkoopCatMode").HasColumnType("int").IsOptional();
            Property(x => x.DefaultVerkoopCatHerziening).HasColumnName(@"DefaultVerkoopCatHerziening").HasColumnType("bigint").IsOptional();
            Property(x => x.DefaultVerkoopCatRegie).HasColumnName(@"DefaultVerkoopCatRegie").HasColumnType("bigint").IsOptional();
            Property(x => x.SyncWerflijst).HasColumnName(@"SyncWerflijst").HasColumnType("bit").IsRequired();

            HasOptional(a => a.CostHeaderType).WithMany(b => b.SysWerfParas).HasForeignKey(c => c.AutoCreateCostTemplate).WillCascadeOnDelete(false);
            HasOptional(a => a.RelActiviteit_DefaultInkoopCat).WithMany(b => b.SysWerfParas_DefaultInkoopCat).HasForeignKey(c => c.DefaultInkoopCat).WillCascadeOnDelete(false);
            HasOptional(a => a.RelActiviteit_DefaultVerkoopCat).WithMany(b => b.SysWerfParas_DefaultVerkoopCat).HasForeignKey(c => c.DefaultVerkoopCat).WillCascadeOnDelete(false);
            HasOptional(a => a.RelActiviteit_DefaultVerkoopCatRegie).WithMany(b => b.SysWerfParas_DefaultVerkoopCatRegie).HasForeignKey(c => c.DefaultVerkoopCatRegie).WillCascadeOnDelete(false);
            HasOptional(a => a.Relation).WithMany(b => b.SysWerfParas).HasForeignKey(c => c.ExtraLeveradres1).WillCascadeOnDelete(false);
            HasOptional(a => a.Vat).WithMany(b => b.SysWerfParas).HasForeignKey(c => c.InvoiceDefaultVatCode).WillCascadeOnDelete(false);
            HasOptional(a => a.VatRegime).WithMany(b => b.SysWerfParas).HasForeignKey(c => c.InvoiceDefaultBtwRegime).WillCascadeOnDelete(false);
            HasOptional(a => a.WerfType_ContractOaDefaultType).WithMany(b => b.SysWerfParas_ContractOaDefaultType).HasForeignKey(c => c.ContractOaDefaultType).WillCascadeOnDelete(false);
            HasOptional(a => a.WerfType_WerfDefaultType).WithMany(b => b.SysWerfParas_WerfDefaultType).HasForeignKey(c => c.WerfDefaultType).WillCascadeOnDelete(false);
            HasOptional(a => a.WerkCode).WithMany(b => b.SysWerfParas).HasForeignKey(c => c.DefaultWerkCode).WillCascadeOnDelete(false);
        }
    }
}
