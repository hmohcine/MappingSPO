using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalculationEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalculationEntity>
    {
        public CalculationEntityConfiguration()
            : this("Project")
        {
        }

        public CalculationEntityConfiguration(string schema)
        {
            ToTable("tCalculation", schema);
            HasKey(x => x.CalcId);

            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CalcTypeId).HasColumnName(@"CalcTypeID").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(2);
            Property(x => x.CalcYear).HasColumnName(@"CalcYear").HasColumnType("int").IsOptional();
            Property(x => x.CalcNumber).HasColumnName(@"CalcNumber").HasColumnType("int").IsOptional();
            Property(x => x.ExtNumber).HasColumnName(@"ExtNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CalcStatus).HasColumnName(@"CalcStatus").HasColumnType("int").IsOptional();
            Property(x => x.CalcName).HasColumnName(@"CalcName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.NotesInternal).HasColumnName(@"NotesInternal").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.NotesExternal).HasColumnName(@"NotesExternal").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.NotesXml).HasColumnName(@"NotesXML").HasColumnType("xml").IsOptional();
            Property(x => x.DigitsUnit).HasColumnName(@"DigitsUnit").HasColumnType("int").IsOptional();
            Property(x => x.DigitsTotal).HasColumnName(@"DigitsTotal").HasColumnType("int").IsOptional();
            Property(x => x.Timestamp).HasColumnName(@"timestamp").HasColumnType("timestamp").IsRequired().IsFixedLength().HasMaxLength(8).IsRowVersion();
            Property(x => x.Tkp).HasColumnName(@"TKP").HasColumnType("float").IsOptional();
            Property(x => x.Tvp).HasColumnName(@"TVP").HasColumnType("float").IsOptional();
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.LastSaveData).HasColumnName(@"LastSaveData").HasColumnType("datetime").IsOptional();
            Property(x => x.Creator).HasColumnName(@"Creator").HasColumnType("int").IsOptional();
            Property(x => x.Calculator).HasColumnName(@"Calculator").HasColumnType("int").IsOptional();
            Property(x => x.Code1).HasColumnName(@"Code1").HasColumnType("int").IsOptional();
            Property(x => x.Code2).HasColumnName(@"Code2").HasColumnType("int").IsOptional();
            Property(x => x.Code3).HasColumnName(@"Code3").HasColumnType("int").IsOptional();
            Property(x => x.Code4).HasColumnName(@"Code4").HasColumnType("int").IsOptional();
            Property(x => x.Code5).HasColumnName(@"Code5").HasColumnType("int").IsOptional();
            Property(x => x.Code6).HasColumnName(@"Code6").HasColumnType("int").IsOptional();
            Property(x => x.Code7).HasColumnName(@"Code7").HasColumnType("int").IsOptional();
            Property(x => x.Code8).HasColumnName(@"Code8").HasColumnType("int").IsOptional();
            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.CurrentOwner).HasColumnName(@"CurrentOwner").HasColumnType("int").IsOptional();
            Property(x => x.BColor).HasColumnName(@"bColor").HasColumnType("int").IsOptional();
            Property(x => x.BText).HasColumnName(@"bText").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.BBold).HasColumnName(@"bBold").HasColumnType("bit").IsOptional();
            Property(x => x.MText).HasColumnName(@"mText").HasColumnType("nvarchar").IsOptional().HasMaxLength(500);
            Property(x => x.BIcon).HasColumnName(@"bIcon").HasColumnType("image").IsOptional().HasMaxLength(2147483647);
            Property(x => x.Datum1).HasColumnName(@"Datum1").HasColumnType("datetime").IsOptional();
            Property(x => x.Datum2).HasColumnName(@"Datum2").HasColumnType("datetime").IsOptional();
            Property(x => x.OfferteDatum).HasColumnName(@"OfferteDatum").HasColumnType("datetime").IsOptional();
            Property(x => x.ShowDigitsEkp).HasColumnName(@"ShowDigitsEKP").HasColumnType("int").IsOptional();
            Property(x => x.ShowDigitsKp).HasColumnName(@"ShowDigitsKP").HasColumnType("int").IsOptional();
            Property(x => x.ShowDigitsEvp).HasColumnName(@"ShowDigitsEVP").HasColumnType("int").IsOptional();
            Property(x => x.ShowDigitsVp).HasColumnName(@"ShowDigitsVP").HasColumnType("int").IsOptional();
            Property(x => x.XWinstpctCurrent).HasColumnName(@"XWinstpctCurrent").HasColumnType("float").IsOptional();
            Property(x => x.XWinstpctRequested).HasColumnName(@"XWinstpctRequested").HasColumnType("float").IsOptional();
            Property(x => x.XWinstCurrent).HasColumnName(@"XWinstCurrent").HasColumnType("float").IsOptional();
            Property(x => x.SummaryMode).HasColumnName(@"SummaryMode").HasColumnType("int").IsOptional();
            Property(x => x.OfferNotes1).HasColumnName(@"OfferNotes1").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.OfferNotes2).HasColumnName(@"OfferNotes2").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.OfferClientRelation).HasColumnName(@"OfferClientRelation").HasColumnType("int").IsOptional();
            Property(x => x.OfferClientContact).HasColumnName(@"OfferClientContact").HasColumnType("int").IsOptional();
            Property(x => x.OfferDeliveryRelation).HasColumnName(@"OfferDeliveryRelation").HasColumnType("int").IsOptional();
            Property(x => x.OfferDeliveryContact).HasColumnName(@"OfferDeliveryContact").HasColumnType("int").IsOptional();
            Property(x => x.OfferTitle).HasColumnName(@"OfferTitle").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code1Visible).HasColumnName(@"Code1Visible").HasColumnType("bit").IsOptional();
            Property(x => x.Code2Visible).HasColumnName(@"Code2Visible").HasColumnType("bit").IsOptional();
            Property(x => x.Code3Visible).HasColumnName(@"Code3Visible").HasColumnType("bit").IsOptional();
            Property(x => x.Code4Visible).HasColumnName(@"Code4Visible").HasColumnType("bit").IsOptional();
            Property(x => x.Code5Visible).HasColumnName(@"Code5Visible").HasColumnType("bit").IsOptional();
            Property(x => x.Code6Visible).HasColumnName(@"Code6Visible").HasColumnType("bit").IsOptional();
            Property(x => x.Code7Visible).HasColumnName(@"Code7Visible").HasColumnType("bit").IsOptional();
            Property(x => x.Code8Visible).HasColumnName(@"Code8Visible").HasColumnType("bit").IsOptional();
            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsOptional();
            Property(x => x.VatCode).HasColumnName(@"VATCode").HasColumnType("int").IsOptional();
            Property(x => x.BtwRegime).HasColumnName(@"BTWRegime").HasColumnType("int").IsOptional();
            Property(x => x.ShowMgtParts).HasColumnName(@"ShowMGTParts").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.VervalDatum).HasColumnName(@"VervalDatum").HasColumnType("datetime").IsOptional();
            Property(x => x.RecalcOnClose).HasColumnName(@"RecalcOnClose").HasColumnType("bit").IsRequired();
            Property(x => x.PathDocsFileSystem).HasColumnName(@"PathDocsFileSystem").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.IndienDatum).HasColumnName(@"IndienDatum").HasColumnType("datetime").IsOptional();
            Property(x => x.Ref1).HasColumnName(@"Ref1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref2).HasColumnName(@"Ref2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref3).HasColumnName(@"Ref3").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref4).HasColumnName(@"Ref4").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ShowDigitsAantal).HasColumnName(@"ShowDigitsAantal").HasColumnType("int").IsOptional();
            Property(x => x.UriWebSystem).HasColumnName(@"URIWebSystem").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ExtendedIpVerdeling).HasColumnName(@"ExtendedIPVerdeling").HasColumnType("bit").IsOptional();
            Property(x => x.LastUpdatedEkpDate).HasColumnName(@"LastUpdatedEKPDate").HasColumnType("datetime").IsOptional();
            Property(x => x.LastUpdatedEkpLog).HasColumnName(@"LastUpdatedEKPLog").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Q1).HasColumnName(@"Q1").HasColumnType("float").IsOptional();
            Property(x => x.Q2).HasColumnName(@"Q2").HasColumnType("float").IsOptional();
            Property(x => x.LoonEc).HasColumnName(@"LoonEC").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.LoonAantal).HasColumnName(@"LoonAantal").HasColumnType("float").IsOptional();
            Property(x => x.ArticleLibraryType).HasColumnName(@"ArticleLibraryType").HasColumnType("int").IsOptional();
            Property(x => x.ArticleLibraryId).HasColumnName(@"ArticleLibraryID").HasColumnType("bigint").IsOptional();
            Property(x => x.ArticleLibrarySettings).HasColumnName(@"ArticleLibrarySettings").HasColumnType("int").IsOptional();
            Property(x => x.PostLibraryType).HasColumnName(@"PostLibraryType").HasColumnType("int").IsOptional();
            Property(x => x.PostLibraryId).HasColumnName(@"PostLibraryID").HasColumnType("bigint").IsOptional();
            Property(x => x.PostLibrarySettings).HasColumnName(@"PostLibrarySettings").HasColumnType("int").IsOptional();
            Property(x => x.PostDontOverwrite).HasColumnName(@"PostDontOverwrite").HasColumnType("bit").IsOptional();
            Property(x => x.PostLibraryIncludeQuantity).HasColumnName(@"PostLibraryIncludeQuantity").HasColumnType("bit").IsOptional();
            Property(x => x.ToonOpmetingen).HasColumnName(@"ToonOpmetingen").HasColumnType("bit").IsOptional();
            Property(x => x.ToonSamenvatting).HasColumnName(@"ToonSamenvatting").HasColumnType("int").IsOptional();
            Property(x => x.ToonLijnOnder).HasColumnName(@"ToonLijnOnder").HasColumnType("bit").IsOptional();
            Property(x => x.HideTotalsOnHfst).HasColumnName(@"HideTotalsOnHfst").HasColumnType("bit").IsOptional();
            Property(x => x.CanChangeParaYn).HasColumnName(@"CanChangeParaYn").HasColumnType("bit").IsOptional();
            Property(x => x.CalcPassword).HasColumnName(@"CalcPassword").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WinstMode).HasColumnName(@"WinstMode").HasColumnType("int").IsOptional();
            Property(x => x.ExtraDate1).HasColumnName(@"ExtraDate1").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtraDate2).HasColumnName(@"ExtraDate2").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtraDate3).HasColumnName(@"ExtraDate3").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtraDate4).HasColumnName(@"ExtraDate4").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtraDate5).HasColumnName(@"ExtraDate5").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtendedWinstMode).HasColumnName(@"ExtendedWinstMode").HasColumnType("int").IsOptional();
            Property(x => x.Bw01Pct).HasColumnName(@"BW01pct").HasColumnType("float").IsOptional();
            Property(x => x.Bw02Pct).HasColumnName(@"BW02pct").HasColumnType("float").IsOptional();
            Property(x => x.Bw03Pct).HasColumnName(@"BW03pct").HasColumnType("float").IsOptional();
            Property(x => x.Bw04Pct).HasColumnName(@"BW04pct").HasColumnType("float").IsOptional();
            Property(x => x.EnableExtWinstMode).HasColumnName(@"EnableExtWinstMode").HasColumnType("bit").IsOptional();
            Property(x => x.BudgetVerlaging1Gevraagd).HasColumnName(@"BudgetVerlaging1Gevraagd").HasColumnType("float").IsOptional();
            Property(x => x.MarkedForDeletion).HasColumnName(@"MarkedForDeletion").HasColumnType("bit").IsRequired();
            Property(x => x.WhoMarkedForDeletion).HasColumnName(@"WhoMarkedForDeletion").HasColumnType("int").IsOptional();
            Property(x => x.DeletionErrorRemark).HasColumnName(@"DeletionErrorRemark").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.DefaultBtwRegime).HasColumnName(@"DefaultBTWRegime").HasColumnType("int").IsOptional();
            Property(x => x.DefaultVatCode).HasColumnName(@"DefaultVatCode").HasColumnType("int").IsOptional();
            Property(x => x.ApplyBtwOnNewPosts).HasColumnName(@"ApplyBTWOnNewPosts").HasColumnType("bit").IsOptional();
            Property(x => x.ExtraNum1).HasColumnName(@"ExtraNum1").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum2).HasColumnName(@"ExtraNum2").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum3).HasColumnName(@"ExtraNum3").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum4).HasColumnName(@"ExtraNum4").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum5).HasColumnName(@"ExtraNum5").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum6).HasColumnName(@"ExtraNum6").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum7).HasColumnName(@"ExtraNum7").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum8).HasColumnName(@"ExtraNum8").HasColumnType("float").IsOptional();
            Property(x => x.CalcSoort).HasColumnName(@"CalcSoort").HasColumnType("int").IsRequired();
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1);
            Property(x => x.TvpIncl).HasColumnName(@"TVPIncl").HasColumnType("float").IsOptional();
            Property(x => x.TemplateCalcId).HasColumnName(@"TemplateCalcID").HasColumnType("bigint").IsOptional();
            Property(x => x.Verantwoordelijke1).HasColumnName(@"Verantwoordelijke1").HasColumnType("int").IsOptional();
            Property(x => x.Verantwoordelijke2).HasColumnName(@"Verantwoordelijke2").HasColumnType("int").IsOptional();
            Property(x => x.Verantwoordelijke3).HasColumnName(@"Verantwoordelijke3").HasColumnType("int").IsOptional();
            Property(x => x.UiVersion).HasColumnName(@"UIVersion").HasColumnType("int").IsRequired();
            Property(x => x.BimModelName).HasColumnName(@"BimModelName").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.DefaultVerkoopCatId).HasColumnName(@"DefaultVerkoopCatID").HasColumnType("bigint").IsOptional();
            Property(x => x.ApplyVerkoopCatOnNewPosts).HasColumnName(@"ApplyVerkoopCatOnNewPosts").HasColumnType("bit").IsOptional();
            Property(x => x.WbsCodeIndex).HasColumnName(@"WBSCodeIndex").HasColumnType("int").IsOptional();
            Property(x => x.IsRaw).HasColumnName(@"IsRaw").HasColumnType("bit").IsOptional();
            Property(x => x.BijdrageRawPct).HasColumnName(@"BijdrageRawPct").HasColumnType("float").IsOptional();
            Property(x => x.BijdrageFckctPct).HasColumnName(@"BijdrageFckctPct").HasColumnType("float").IsOptional();
            Property(x => x.AlgKostRawPct).HasColumnName(@"AlgKostRawPct").HasColumnType("float").IsOptional();
            Property(x => x.WinstRisRawPct).HasColumnName(@"WinstRisRawPct").HasColumnType("float").IsOptional();
            Property(x => x.ExtraBoolean1).HasColumnName(@"ExtraBoolean1").HasColumnType("bit").IsRequired();
            Property(x => x.ExtraBoolean2).HasColumnName(@"ExtraBoolean2").HasColumnType("bit").IsRequired();
            Property(x => x.ExtraBoolean3).HasColumnName(@"ExtraBoolean3").HasColumnType("bit").IsRequired();
            Property(x => x.ExtraBoolean4).HasColumnName(@"ExtraBoolean4").HasColumnType("bit").IsRequired();
            Property(x => x.ExtraBoolean5).HasColumnName(@"ExtraBoolean5").HasColumnType("bit").IsRequired();
            Property(x => x.ExtraBoolean6).HasColumnName(@"ExtraBoolean6").HasColumnType("bit").IsRequired();
            Property(x => x.ExtraBoolean7).HasColumnName(@"ExtraBoolean7").HasColumnType("bit").IsRequired();
            Property(x => x.ExtraBoolean8).HasColumnName(@"ExtraBoolean8").HasColumnType("bit").IsRequired();
            Property(x => x.VersieRaw).HasColumnName(@"VersieRaw").HasColumnType("int").IsOptional();

            HasOptional(a => a.CalcCode1).WithMany(b => b.Calculations).HasForeignKey(c => c.Code1).WillCascadeOnDelete(false);
            HasOptional(a => a.CalcCode2).WithMany(b => b.Calculations).HasForeignKey(c => c.Code2).WillCascadeOnDelete(false);
            HasOptional(a => a.CalcCode3).WithMany(b => b.Calculations).HasForeignKey(c => c.Code3).WillCascadeOnDelete(false);
            HasOptional(a => a.CalcCode4).WithMany(b => b.Calculations).HasForeignKey(c => c.Code4).WillCascadeOnDelete(false);
            HasOptional(a => a.CalcCode5).WithMany(b => b.Calculations).HasForeignKey(c => c.Code5).WillCascadeOnDelete(false);
            HasOptional(a => a.CalcCode6).WithMany(b => b.Calculations).HasForeignKey(c => c.Code6).WillCascadeOnDelete(false);
            HasOptional(a => a.CalcCode7).WithMany(b => b.Calculations).HasForeignKey(c => c.Code7).WillCascadeOnDelete(false);
            HasOptional(a => a.CalcCode8).WithMany(b => b.Calculations).HasForeignKey(c => c.Code8).WillCascadeOnDelete(false);
            HasRequired(a => a.CalcType).WithMany(b => b.Calculations).HasForeignKey(c => c.CalcTypeId).WillCascadeOnDelete(false);
            HasMany(t => t.Calculations_PrijsVraagId).WithMany(t => t.Calculations_BaseCalcId).Map(m =>
            {
                m.ToTable("tOfferPrijsvraag", "Project");
                m.MapLeftKey("BaseCalcID");
                m.MapRightKey("PrijsVraagID");
            });
        }
    }
}
