using MappingSPO.Entities;

namespace MappingSPO
{
    public class SalesDefaultEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SalesDefaultEntity>
    {
        public SalesDefaultEntityConfiguration()
            : this("Settings")
        {
        }

        public SalesDefaultEntityConfiguration(string schema)
        {
            ToTable("tSalesDefaults", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Code1Caption).HasColumnName(@"Code1Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Code2Caption).HasColumnName(@"Code2Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Code3Caption).HasColumnName(@"Code3Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Code4Caption).HasColumnName(@"Code4Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Code5Caption).HasColumnName(@"Code5Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Code6Caption).HasColumnName(@"Code6Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Code7Caption).HasColumnName(@"Code7Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Code8Caption).HasColumnName(@"Code8Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Ref1Caption).HasColumnName(@"Ref1Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Ref2Caption).HasColumnName(@"Ref2Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Ref3Caption).HasColumnName(@"Ref3Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Ref4Caption).HasColumnName(@"Ref4Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.AutoStockMinAantalInMagazijn).HasColumnName(@"AutoStockMinAantalInMagazijn").HasColumnType("decimal").IsRequired().HasPrecision(18,6);
            Property(x => x.AutoStockMinAantalInToonzaal).HasColumnName(@"AutoStockMinAantalInToonzaal").HasColumnType("decimal").IsRequired().HasPrecision(18,6);
            Property(x => x.AutoStockMaToMode).HasColumnName(@"AutoStockMaTOMode").HasColumnType("int").IsRequired();
            Property(x => x.AutoStockBResBsMode).HasColumnName(@"AutoStockBResBSMode").HasColumnType("int").IsRequired();
            Property(x => x.BestelWijzeDefault).HasColumnName(@"BestelWijzeDefault").HasColumnType("int").IsRequired();
            Property(x => x.AddDaysForDeliveryDateWhenNull).HasColumnName(@"AddDaysForDeliveryDateWhenNull").HasColumnType("bigint").IsOptional();
            Property(x => x.LeverWijzeDefault).HasColumnName(@"LeverWijzeDefault").HasColumnType("int").IsOptional();
            Property(x => x.DefaultInvoiceAdressType).HasColumnName(@"DefaultInvoiceAdressType").HasColumnType("int").IsOptional();
            Property(x => x.DefaultVatCode).HasColumnName(@"DefaultVatCode").HasColumnType("int").IsOptional();
            Property(x => x.DefaultVatRegime).HasColumnName(@"DefaultVATRegime").HasColumnType("int").IsOptional();
            Property(x => x.DefaultStepAfterCreateInvoice).HasColumnName(@"DefaultStepAfterCreateInvoice").HasColumnType("int").IsOptional();
            Property(x => x.IsReportTaxIncl).HasColumnName(@"IsReportTaxIncl").HasColumnType("bit").IsOptional();
            Property(x => x.LastRunAnalyse).HasColumnName(@"LastRunAnalyse").HasColumnType("datetime").IsOptional();
            Property(x => x.ManualUpdateDwEnabled).HasColumnName(@"ManualUpdateDWEnabled").HasColumnType("bit").IsOptional();
            Property(x => x.DefaultVkoType).HasColumnName(@"DefaultVKOType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.DefaultOfferType).HasColumnName(@"DefaultOfferType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.FontExtendedRichTextBox).HasColumnName(@"FontExtendedRichTextBox").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.AutoStockMaToVolgorde).HasColumnName(@"AutoStockMaToVolgorde").HasColumnType("int").IsOptional();
            Property(x => x.OtherBestelBonPrefix).HasColumnName(@"OtherBestelBonPrefix").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.FontExtraExtendedRtFbox).HasColumnName(@"FontExtraExtendedRTFbox").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.RtfZoomFactor).HasColumnName(@"RTFZoomFactor").HasColumnType("real").IsOptional();
            Property(x => x.TextColor1).HasColumnName(@"TextColor1").HasColumnType("int").IsOptional();
            Property(x => x.TextColor2).HasColumnName(@"TextColor2").HasColumnType("int").IsOptional();
            Property(x => x.TextColor3).HasColumnName(@"TextColor3").HasColumnType("int").IsOptional();
            Property(x => x.TextColor4).HasColumnName(@"TextColor4").HasColumnType("int").IsOptional();
            Property(x => x.TextColorName1).HasColumnName(@"TextColorName1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.TextColorName2).HasColumnName(@"TextColorName2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.TextColorName3).HasColumnName(@"TextColorName3").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.TextColorName4).HasColumnName(@"TextColorName4").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Bold).HasColumnName(@"Bold").HasColumnType("bit").IsOptional();
            Property(x => x.Italic).HasColumnName(@"Italic").HasColumnType("bit").IsOptional();
            Property(x => x.Underline).HasColumnName(@"Underline").HasColumnType("bit").IsOptional();
            Property(x => x.DefaultTextColor).HasColumnName(@"DefaultTextColor").HasColumnType("int").IsOptional();
            Property(x => x.Code9Caption).HasColumnName(@"Code9Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.BuildRef1Caption).HasColumnName(@"BuildRef1Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.BuildRef2Caption).HasColumnName(@"BuildRef2Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.BuildRef3Caption).HasColumnName(@"BuildRef3Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.BuildRef4Caption).HasColumnName(@"BuildRef4Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.AutostockMode).HasColumnName(@"AutostockMode").HasColumnType("int").IsRequired();
            Property(x => x.EnableOrColumn).HasColumnName(@"EnableORColumn").HasColumnType("bit").IsRequired();

            HasOptional(a => a.EmmaOfferType).WithMany(b => b.SalesDefaults).HasForeignKey(c => c.DefaultOfferType).WillCascadeOnDelete(false);
            HasOptional(a => a.EmmaVkoType).WithMany(b => b.SalesDefaults).HasForeignKey(c => c.DefaultVkoType).WillCascadeOnDelete(false);
            HasOptional(a => a.Vat).WithMany(b => b.SalesDefaults).HasForeignKey(c => c.DefaultVatCode).WillCascadeOnDelete(false);
            HasOptional(a => a.VatRegime).WithMany(b => b.SalesDefaults).HasForeignKey(c => c.DefaultVatRegime).WillCascadeOnDelete(false);
        }
    }
}
