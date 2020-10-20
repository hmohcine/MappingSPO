using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcDetailEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcDetailEntity>
    {
        public CalcDetailEntityConfiguration()
            : this("Project")
        {
        }

        public CalcDetailEntityConfiguration(string schema)
        {
            ToTable("tCalcDetail", schema);
            HasKey(x => new { x.CalcDetailId, x.CalcId });

            Property(x => x.CalcDetailId).HasColumnName(@"CalcDetailID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ParentId).HasColumnName(@"ParentID").HasColumnType("bigint").IsOptional();
            Property(x => x.Code1).HasColumnName(@"Code1").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code2).HasColumnName(@"Code2").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code3).HasColumnName(@"Code3").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code4).HasColumnName(@"Code4").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code5).HasColumnName(@"Code5").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code6).HasColumnName(@"Code6").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code7).HasColumnName(@"Code7").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code8).HasColumnName(@"Code8").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsOptional().HasMaxLength(2048);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.NotesExternal).HasColumnName(@"NotesExternal").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.NotesExternalOa).HasColumnName(@"NotesExternalOA").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.TakeNotesFromCustomer).HasColumnName(@"TakeNotesFromCustomer").HasColumnType("bit").IsOptional();
            Property(x => x.NotesInternal).HasColumnName(@"NotesInternal").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.NotesXml).HasColumnName(@"NotesXML").HasColumnType("xml").IsOptional();
            Property(x => x.CalcHc).HasColumnName(@"CalcHC").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.CalcLineTypeCode).HasColumnName(@"CalcLineTypeCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(2);
            Property(x => x.Ks).HasColumnName(@"KS").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.Uc).HasColumnName(@"UC").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.Aantal).HasColumnName(@"Aantal").HasColumnType("float").IsOptional();
            Property(x => x.BestelAantal).HasColumnName(@"BestelAantal").HasColumnType("float").IsOptional();
            Property(x => x.ArchitectAantal).HasColumnName(@"ArchitectAantal").HasColumnType("float").IsOptional();
            Property(x => x.Ekp).HasColumnName(@"EKP").HasColumnType("float").IsOptional();
            Property(x => x.Kp).HasColumnName(@"KP").HasColumnType("float").IsOptional();
            Property(x => x.Tkp).HasColumnName(@"TKP").HasColumnType("float").IsOptional();
            Property(x => x.PrizeRequestDetailId).HasColumnName(@"PrizeRequestDetailID").HasColumnType("bigint").IsOptional();
            Property(x => x.TotWinstpct).HasColumnName(@"TotWinstpct").HasColumnType("float").IsOptional();
            Property(x => x.Winstpct2).HasColumnName(@"Winstpct2").HasColumnType("float").IsOptional();
            Property(x => x.Winstpct3).HasColumnName(@"Winstpct3").HasColumnType("float").IsOptional();
            Property(x => x.Ewinst).HasColumnName(@"Ewinst").HasColumnType("float").IsOptional();
            Property(x => x.Evp).HasColumnName(@"EVP").HasColumnType("float").IsOptional();
            Property(x => x.Vp).HasColumnName(@"VP").HasColumnType("float").IsOptional();
            Property(x => x.DateUpdatedEkp).HasColumnName(@"DateUpdatedEKP").HasColumnType("datetime").IsOptional();
            Property(x => x.LineOrder).HasColumnName(@"LineOrder").HasColumnType("int").IsOptional();
            Property(x => x.LineLevel).HasColumnName(@"LineLevel").HasColumnType("int").IsOptional();
            Property(x => x.DigitsUnit).HasColumnName(@"DigitsUnit").HasColumnType("int").IsOptional();
            Property(x => x.DigitsTotal).HasColumnName(@"DigitsTotal").HasColumnType("int").IsOptional();
            Property(x => x.DigitsChild).HasColumnName(@"DigitsChild").HasColumnType("bit").IsOptional();
            Property(x => x.OldEkp).HasColumnName(@"OldEKP").HasColumnType("float").IsOptional();
            Property(x => x.OldDateUpdatedEkp).HasColumnName(@"OldDateUpdatedEKP").HasColumnType("datetime").IsOptional();
            Property(x => x.Formule).HasColumnName(@"Formule").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.IsImpactFormule).HasColumnName(@"IsImpactFormule").HasColumnType("bit").IsRequired();
            Property(x => x.ActivatedMode).HasColumnName(@"ActivatedMode").HasColumnType("smallint").IsOptional();
            Property(x => x.DynMode).HasColumnName(@"DynMode").HasColumnType("int").IsOptional();
            Property(x => x.Weight).HasColumnName(@"Weight").HasColumnType("float").IsOptional();
            Property(x => x.XParent).HasColumnName(@"XParent").HasColumnType("float").IsOptional();
            Property(x => x.EcParent).HasColumnName(@"ECParent").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.XChild).HasColumnName(@"XChild").HasColumnType("float").IsOptional();
            Property(x => x.EcChild).HasColumnName(@"ECChild").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.FactorChild).HasColumnName(@"FactorChild").HasColumnType("float").IsOptional();
            Property(x => x.FactorParent).HasColumnName(@"FactorParent").HasColumnType("float").IsOptional();
            Property(x => x.RoundMethod).HasColumnName(@"RoundMethod").HasColumnType("smallint").IsOptional();
            Property(x => x.Digits).HasColumnName(@"Digits").HasColumnType("float").IsOptional();
            Property(x => x.PostId).HasColumnName(@"PostID").HasColumnType("bigint").IsOptional();
            Property(x => x.IsDone).HasColumnName(@"IsDone").HasColumnType("bit").IsRequired();
            Property(x => x.IsLocked).HasColumnName(@"IsLocked").HasColumnType("bit").IsOptional();
            Property(x => x.IsFiltered).HasColumnName(@"IsFiltered").HasColumnType("bit").IsOptional();
            Property(x => x.VatCode).HasColumnName(@"VATCode").HasColumnType("int").IsOptional();
            Property(x => x.BtwRegime).HasColumnName(@"BTWRegime").HasColumnType("int").IsOptional();
            Property(x => x.Timestamp).HasColumnName(@"timestamp").HasColumnType("timestamp").IsRequired().IsFixedLength().HasMaxLength(8).IsRowVersion();
            Property(x => x.LastErrorFormula).HasColumnName(@"LastErrorFormula").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.IsParent).HasColumnName(@"IsParent").HasColumnType("bit").IsOptional();
            Property(x => x.StructOrder).HasColumnName(@"StructOrder").HasColumnType("int").IsOptional();
            Property(x => x.CalcOrder).HasColumnName(@"CalcOrder").HasColumnType("int").IsOptional();
            Property(x => x.IsIndirectArticle).HasColumnName(@"IsIndirectArticle").HasColumnType("bit").IsOptional();
            Property(x => x.ResultFormula).HasColumnName(@"ResultFormula").HasColumnType("int").IsOptional();
            Property(x => x.ReadyToCompile).HasColumnName(@"ReadyToCompile").HasColumnType("bit").IsRequired();
            Property(x => x.OldEcChild).HasColumnName(@"OldECChild").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.OldEcParent).HasColumnName(@"OldECParent").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.AddedFromVordering).HasColumnName(@"AddedFromVordering").HasColumnType("int").IsOptional();
            Property(x => x.ActiviteitId).HasColumnName(@"ActiviteitID").HasColumnType("bigint").IsOptional();
            Property(x => x.PrintCode).HasColumnName(@"PrintCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.NotesFormula).HasColumnName(@"NotesFormula").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.AppendNotesFormulaToOffer).HasColumnName(@"AppendNotesFormulaToOffer").HasColumnType("bit").IsOptional();
            Property(x => x.BudgetVerlaging1).HasColumnName(@"BudgetVerlaging1").HasColumnType("float").IsOptional();
            Property(x => x.BudgetVerlaging2).HasColumnName(@"BudgetVerlaging2").HasColumnType("float").IsOptional();
            Property(x => x.Budget).HasColumnName(@"Budget").HasColumnType("float").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.ExtraNum1).HasColumnName(@"ExtraNum1").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum2).HasColumnName(@"ExtraNum2").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum3).HasColumnName(@"ExtraNum3").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum4).HasColumnName(@"ExtraNum4").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum5).HasColumnName(@"ExtraNum5").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum6).HasColumnName(@"ExtraNum6").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum7).HasColumnName(@"ExtraNum7").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum8).HasColumnName(@"ExtraNum8").HasColumnType("float").IsOptional();
            Property(x => x.InkoopCatId).HasColumnName(@"InkoopCatID").HasColumnType("bigint").IsOptional();
            Property(x => x.VerkoopCatId).HasColumnName(@"VerkoopCatID").HasColumnType("bigint").IsOptional();
            Property(x => x.CalcActiviteitId).HasColumnName(@"CalcActiviteitID").HasColumnType("bigint").IsOptional();
            Property(x => x.EvpLockedYn).HasColumnName(@"EVPLockedYn").HasColumnType("bit").IsOptional();
            Property(x => x.LockedEvp).HasColumnName(@"LockedEVP").HasColumnType("float").IsOptional();
            Property(x => x.BaseCalcLineId).HasColumnName(@"BaseCalcLineID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.AntwoordGuid).HasColumnName(@"AntwoordGUID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.SimpleFormula).HasColumnName(@"SimpleFormula").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.UseSimpleFormula).HasColumnName(@"UseSimpleFormula").HasColumnType("bit").IsOptional();
            Property(x => x.BimName).HasColumnName(@"BimName").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.MarkupIk).HasColumnName(@"Markup_IK").HasColumnType("float").IsOptional();
            Property(x => x.MarkupAk).HasColumnName(@"Markup_AK").HasColumnType("float").IsOptional();
            Property(x => x.MarkupWr).HasColumnName(@"Markup_WR").HasColumnType("float").IsOptional();
            Property(x => x.MarkupBij).HasColumnName(@"Markup_BIJ").HasColumnType("float").IsOptional();

            HasOptional(a => a.CalcHc_CalcHc).WithMany(b => b.CalcDetails).HasForeignKey(c => new { c.CalcId, c.CalcHc }).WillCascadeOnDelete(false);
            HasRequired(a => a.CalcLineType).WithMany(b => b.CalcDetails).HasForeignKey(c => c.CalcLineTypeCode).WillCascadeOnDelete(false);
            HasRequired(a => a.Calculation).WithMany(b => b.CalcDetails).HasForeignKey(c => c.CalcId);
        }
    }
}
