using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WKostenEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WKostenEntity>
    {
        public WKostenEntityConfiguration()
            : this("dbo")
        {
        }

        public WKostenEntityConfiguration(string schema)
        {
            ToTable("vwKosten", schema);
            HasKey(x => new { x.DetailId, x.CostHeaderId, x.CostHeaderType, x.MasterType, x.Aantal, x.Ekp, x.Kp, x.Evp, x.Vp, x.Status, x.Goedgekeurd, x.Domain });

            Property(x => x.DetailId).HasColumnName(@"DetailID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CostHeaderId).HasColumnName(@"CostHeaderID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CostHeaderType).HasColumnName(@"CostHeaderType").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.MasterType).HasColumnName(@"MasterType").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CostHeaderTypeDescription).HasColumnName(@"CostHeaderTypeDescription").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.IngaveDatum).HasColumnName(@"IngaveDatum").HasColumnType("datetime").IsOptional();
            Property(x => x.Documentnummer).HasColumnName(@"Documentnummer").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.VerantwIngave).HasColumnName(@"VerantwIngave").HasColumnType("nvarchar").IsOptional().HasMaxLength(205);
            Property(x => x.Relation).HasColumnName(@"Relation").HasColumnType("nvarchar").IsOptional().HasMaxLength(230);
            Property(x => x.Kg).HasColumnName(@"KG").HasColumnType("int").IsOptional();
            Property(x => x.WerfName).HasColumnName(@"WerfName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.WerfNummer).HasColumnName(@"WerfNummer").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.WerfLeider).HasColumnName(@"WerfLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(205);
            Property(x => x.Ks).HasColumnName(@"KS").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.Activiteit).HasColumnName(@"Activiteit").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Uc).HasColumnName(@"UC").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
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
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Aantal).HasColumnName(@"Aantal").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ekp).HasColumnName(@"EKP").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Kp).HasColumnName(@"KP").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Evp).HasColumnName(@"EVP").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Vp).HasColumnName(@"VP").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RegieYn).HasColumnName(@"RegieYn").HasColumnType("bit").IsOptional();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.LineOrder).HasColumnName(@"LineOrder").HasColumnType("int").IsOptional();
            Property(x => x.Documentdatum).HasColumnName(@"Documentdatum").HasColumnType("datetime").IsOptional();
            Property(x => x.Referentie).HasColumnName(@"Referentie").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.ReferentieIntern).HasColumnName(@"ReferentieIntern").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.FactuurNr).HasColumnName(@"FactuurNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.FactuurDatum).HasColumnName(@"FactuurDatum").HasColumnType("datetime").IsOptional();
            Property(x => x.Goedgekeurd).HasColumnName(@"Goedgekeurd").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ArbeiderId).HasColumnName(@"ArbeiderID").HasColumnType("int").IsOptional();
            Property(x => x.WerkCode).HasColumnName(@"WerkCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.MobiliteitsCode).HasColumnName(@"MobiliteitsCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.StartUur).HasColumnName(@"StartUur").HasColumnType("datetime").IsOptional();
            Property(x => x.EindUur).HasColumnName(@"EindUur").HasColumnType("datetime").IsOptional();
            Property(x => x.RustTijd).HasColumnName(@"RustTijd").HasColumnType("bigint").IsOptional();
            Property(x => x.LaadLosTijd).HasColumnName(@"LaadLosTijd").HasColumnType("bigint").IsOptional();
            Property(x => x.ExtraTijd).HasColumnName(@"ExtraTijd").HasColumnType("bigint").IsOptional();
            Property(x => x.Arbeider).HasColumnName(@"Arbeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(205);
            Property(x => x.WerfLijstId).HasColumnName(@"WerfLijstID").HasColumnType("bigint").IsOptional();
            Property(x => x.ArtId).HasColumnName(@"ArtID").HasColumnType("bigint").IsOptional();
            Property(x => x.MagazijnId).HasColumnName(@"MagazijnID").HasColumnType("bigint").IsOptional();
            Property(x => x.BestelBonNr).HasColumnName(@"BestelBonNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.BestelBonDatum).HasColumnName(@"BestelBonDatum").HasColumnType("datetime").IsOptional();
            Property(x => x.BestelAantal).HasColumnName(@"BestelAantal").HasColumnType("float").IsOptional();
            Property(x => x.BestelPrijs).HasColumnName(@"BestelPrijs").HasColumnType("float").IsOptional();
            Property(x => x.LeverAantal).HasColumnName(@"LeverAantal").HasColumnType("float").IsOptional();
            Property(x => x.LeverPrijs).HasColumnName(@"LeverPrijs").HasColumnType("float").IsOptional();
            Property(x => x.LeveringNr).HasColumnName(@"LeveringNr").HasColumnType("int").IsOptional();
            Property(x => x.LeveringDatum).HasColumnName(@"LeveringDatum").HasColumnType("datetime").IsOptional();
            Property(x => x.AfstandWerfInKm).HasColumnName(@"AfstandWerfInKm").HasColumnType("float").IsOptional();
            Property(x => x.TotVergoedingPassagier).HasColumnName(@"TotVergoedingPassagier").HasColumnType("float").IsOptional();
            Property(x => x.TotVergoedingBestuurder).HasColumnName(@"TotVergoedingBestuurder").HasColumnType("float").IsOptional();
            Property(x => x.MobiliteitMasterType).HasColumnName(@"MobiliteitMasterType").HasColumnType("int").IsOptional();
            Property(x => x.SbLeveringId).HasColumnName(@"SBLeveringID").HasColumnType("bigint").IsOptional();
            Property(x => x.Sbid).HasColumnName(@"SBID").HasColumnType("bigint").IsOptional();
            Property(x => x.SbLeveringDetailId).HasColumnName(@"SBLeveringDetailID").HasColumnType("bigint").IsOptional();
            Property(x => x.CostNrYear).HasColumnName(@"CostNrYear").HasColumnType("int").IsOptional();
            Property(x => x.CostNr).HasColumnName(@"CostNr").HasColumnType("bigint").IsOptional();
            Property(x => x.WerfTypeId).HasColumnName(@"WerfTypeID").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(x => x.WerfYear).HasColumnName(@"WerfYear").HasColumnType("int").IsOptional();
            Property(x => x.WerfNumber).HasColumnName(@"WerfNumber").HasColumnType("int").IsOptional();
            Property(x => x.BbYear).HasColumnName(@"BBYear").HasColumnType("int").IsOptional();
            Property(x => x.SbNr).HasColumnName(@"SBNr").HasColumnType("bigint").IsOptional();
            Property(x => x.ProjectYear).HasColumnName(@"ProjectYear").HasColumnType("int").IsOptional();
            Property(x => x.ProjectNumber).HasColumnName(@"ProjectNumber").HasColumnType("int").IsOptional();
            Property(x => x.ProjectNrText).HasColumnName(@"ProjectNrText").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ProjectName).HasColumnName(@"ProjectName").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.InkoopCatId).HasColumnName(@"InkoopCatID").HasColumnType("bigint").IsOptional();
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ContractId).HasColumnName(@"ContractID").HasColumnType("bigint").IsOptional();
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.RelationId).HasColumnName(@"RelationID").HasColumnType("bigint").IsOptional();
            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsOptional();
        }
    }
}
