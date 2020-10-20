using MappingSPO.Entities;

namespace MappingSPO
{
    public class RelationEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RelationEntity>
    {
        public RelationEntityConfiguration()
            : this("Relations")
        {
        }

        public RelationEntityConfiguration(string schema)
        {
            ToTable("tRelations", schema);
            HasKey(x => x.RelationId);

            Property(x => x.RelationId).HasColumnName(@"RelationID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Number).HasColumnName(@"Number").HasColumnType("int").IsRequired();
            Property(x => x.Title).HasColumnName(@"Title").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.AdressLine1).HasColumnName(@"AdressLine1").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.AdressLine2).HasColumnName(@"AdressLine2").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.ZipCode).HasColumnName(@"ZipCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.City).HasColumnName(@"City").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.StreetCode).HasColumnName(@"StreetCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(10);
            Property(x => x.CountryCode).HasColumnName(@"CountryCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.Language).HasColumnName(@"Language").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.PayConditionId).HasColumnName(@"PayConditionID").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.NotesInternal).HasColumnName(@"NotesInternal").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.NotesExternal).HasColumnName(@"NotesExternal").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Phone1).HasColumnName(@"Phone1").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Phone2).HasColumnName(@"Phone2").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Fax1).HasColumnName(@"Fax1").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Fax2).HasColumnName(@"Fax2").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Email1).HasColumnName(@"Email1").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.Email2).HasColumnName(@"Email2").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.Website).HasColumnName(@"Website").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.LastUpdatedBy).HasColumnName(@"LastUpdatedBy").HasColumnType("int").IsOptional();
            Property(x => x.LastUpdated).HasColumnName(@"LastUpdated").HasColumnType("datetime").IsOptional();
            Property(x => x.OnNumber).HasColumnName(@"ONNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Rpr).HasColumnName(@"RPR").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.RegNr).HasColumnName(@"RegNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.NumberBh).HasColumnName(@"NumberBH").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Country).HasColumnName(@"Country").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Code1).HasColumnName(@"Code1").HasColumnType("int").IsOptional();
            Property(x => x.Code2).HasColumnName(@"Code2").HasColumnType("int").IsOptional();
            Property(x => x.Code3).HasColumnName(@"Code3").HasColumnType("int").IsOptional();
            Property(x => x.Code4).HasColumnName(@"Code4").HasColumnType("int").IsOptional();
            Property(x => x.Code5).HasColumnName(@"Code5").HasColumnType("int").IsOptional();
            Property(x => x.Code6).HasColumnName(@"Code6").HasColumnType("int").IsOptional();
            Property(x => x.Code7).HasColumnName(@"Code7").HasColumnType("int").IsOptional();
            Property(x => x.Code8).HasColumnName(@"Code8").HasColumnType("int").IsOptional();
            Property(x => x.Logo).HasColumnName(@"Logo").HasColumnType("image").IsOptional().HasMaxLength(2147483647);
            Property(x => x.Gsm).HasColumnName(@"GSM").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Ref1).HasColumnName(@"Ref1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref2).HasColumnName(@"Ref2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref3).HasColumnName(@"Ref3").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref4).HasColumnName(@"Ref4").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.AccountNumber).HasColumnName(@"AccountNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.DefaultBtwRegime).HasColumnName(@"DefaultBTWRegime").HasColumnType("int").IsOptional();
            Property(x => x.SPhone1).HasColumnName(@"sPhone1").HasColumnType("nvarchar").IsOptional().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.SPhone2).HasColumnName(@"sPhone2").HasColumnType("nvarchar").IsOptional().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.SFax1).HasColumnName(@"sFax1").HasColumnType("nvarchar").IsOptional().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.SFax2).HasColumnName(@"sFax2").HasColumnType("nvarchar").IsOptional().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.SOnNumber).HasColumnName(@"sONNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.SGsm).HasColumnName(@"sGSM").HasColumnType("nvarchar").IsOptional().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.IsReportTaxIncl).HasColumnName(@"IsReportTaxIncl").HasColumnType("bit").IsOptional();
            Property(x => x.DefaultClientDiscountId).HasColumnName(@"DefaultClientDiscountID").HasColumnType("int").IsOptional();
            Property(x => x.RegioId).HasColumnName(@"RegioID").HasColumnType("bigint").IsOptional();
            Property(x => x.AccId).HasColumnName(@"AccID").HasColumnType("bigint").IsOptional();
            Property(x => x.AccType).HasColumnName(@"AccType").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.ExtraPropText01).HasColumnName(@"ExtraPropText01").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.ExtraPropText02).HasColumnName(@"ExtraPropText02").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.ExtraPropText03).HasColumnName(@"ExtraPropText03").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.ExtraPropText04).HasColumnName(@"ExtraPropText04").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.ExtraPropNum01).HasColumnName(@"ExtraPropNum01").HasColumnType("decimal").IsOptional().HasPrecision(18,6);
            Property(x => x.ExtraPropNum02).HasColumnName(@"ExtraPropNum02").HasColumnType("decimal").IsOptional().HasPrecision(18,6);
            Property(x => x.ExtraPropNum03).HasColumnName(@"ExtraPropNum03").HasColumnType("decimal").IsOptional().HasPrecision(18,6);
            Property(x => x.ExtraPropNum04).HasColumnName(@"ExtraPropNum04").HasColumnType("decimal").IsOptional().HasPrecision(18,6);
            Property(x => x.UseRelationUntil).HasColumnName(@"UseRelationUntil").HasColumnType("date").IsOptional();
            Property(x => x.IsRelationActive).HasColumnName(@"IsRelationActive").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.AnaCodeId).HasColumnName(@"AnaCodeID").HasColumnType("bigint").IsOptional();
            Property(x => x.DefaultCashDiscountId).HasColumnName(@"DefaultCashDiscountID").HasColumnType("int").IsOptional();
            Property(x => x.DefaultKs).HasColumnName(@"DefaultKS").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.PayConditionIdSupplier).HasColumnName(@"PayConditionIDSupplier").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.OnNumberReal).HasColumnName(@"ONNumberReal").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.DefaultBtwRegimeSupplier).HasColumnName(@"DefaultBTWRegimeSupplier").HasColumnType("int").IsOptional();
            Property(x => x.DefaultCashDiscountIdSupplier).HasColumnName(@"DefaultCashDiscountIDSupplier").HasColumnType("int").IsOptional();
            Property(x => x.DefaultKsSupplier).HasColumnName(@"DefaultKSSupplier").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.DefaultLoonCost).HasColumnName(@"DefaultLoonCost").HasColumnType("float").IsOptional();
            Property(x => x.LoonCostFromParentYn).HasColumnName(@"LoonCostFromParentYn").HasColumnType("bit").IsRequired();
            Property(x => x.SOnNumberReal).HasColumnName(@"sONNumberReal").HasColumnType("nvarchar").IsOptional().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.SCleanedVatNumber).HasColumnName(@"sCleanedVatNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.SCleanedOnNumber).HasColumnName(@"sCleanedOnNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);

            HasOptional(a => a.BAnaCode).WithMany(b => b.Relations).HasForeignKey(c => c.AnaCodeId).WillCascadeOnDelete(false);
            HasOptional(a => a.CashDiscount).WithMany(b => b.Relations).HasForeignKey(c => c.DefaultCashDiscountId).WillCascadeOnDelete(false);
            HasOptional(a => a.ClientDiscount).WithMany(b => b.Relations).HasForeignKey(c => c.DefaultClientDiscountId).WillCascadeOnDelete(false);
            HasOptional(a => a.Country_CountryCode).WithMany(b => b.Relations).HasForeignKey(c => c.CountryCode).WillCascadeOnDelete(false);
            HasOptional(a => a.Ks).WithMany(b => b.Relations).HasForeignKey(c => c.DefaultKs).WillCascadeOnDelete(false);
            HasOptional(a => a.Language_Language).WithMany(b => b.Relations).HasForeignKey(c => c.Language).WillCascadeOnDelete(false);
            HasOptional(a => a.PayCondition).WithMany(b => b.Relations).HasForeignKey(c => c.PayConditionId).WillCascadeOnDelete(false);
            HasOptional(a => a.RelationCode1).WithMany(b => b.Relations).HasForeignKey(c => c.Code1).WillCascadeOnDelete(false);
            HasOptional(a => a.RelationCode2).WithMany(b => b.Relations).HasForeignKey(c => c.Code2).WillCascadeOnDelete(false);
            HasOptional(a => a.RelationCode3).WithMany(b => b.Relations).HasForeignKey(c => c.Code3).WillCascadeOnDelete(false);
            HasOptional(a => a.RelationCode4).WithMany(b => b.Relations).HasForeignKey(c => c.Code4).WillCascadeOnDelete(false);
            HasOptional(a => a.RelationCode5).WithMany(b => b.Relations).HasForeignKey(c => c.Code5).WillCascadeOnDelete(false);
            HasOptional(a => a.RelationCode6).WithMany(b => b.Relations).HasForeignKey(c => c.Code6).WillCascadeOnDelete(false);
            HasOptional(a => a.RelationCode7).WithMany(b => b.Relations).HasForeignKey(c => c.Code7).WillCascadeOnDelete(false);
            HasOptional(a => a.RelationCode8).WithMany(b => b.Relations).HasForeignKey(c => c.Code8).WillCascadeOnDelete(false);
            HasOptional(a => a.User).WithMany(b => b.Relations).HasForeignKey(c => c.LastUpdatedBy).WillCascadeOnDelete(false);
            HasOptional(a => a.VatRegime).WithMany(b => b.Relations).HasForeignKey(c => c.DefaultBtwRegime).WillCascadeOnDelete(false);
        }
    }
}
