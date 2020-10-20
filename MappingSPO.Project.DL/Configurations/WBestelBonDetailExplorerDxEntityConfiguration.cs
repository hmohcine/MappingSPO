using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WBestelBonDetailExplorerDxEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WBestelBonDetailExplorerDxEntity>
    {
        public WBestelBonDetailExplorerDxEntityConfiguration()
            : this("dbo")
        {
        }

        public WBestelBonDetailExplorerDxEntityConfiguration(string schema)
        {
            ToTable("vwBestelBonDetailExplorerDX", schema);
            HasKey(x => new { x.DetailId, x.LineOrder, x.LineType, x.AddedOnLevering, x.Status, x.BestelBonType });

            Property(x => x.DetailId).HasColumnName(@"DetailID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Sbid).HasColumnName(@"SBID").HasColumnType("bigint").IsOptional();
            Property(x => x.LineOrder).HasColumnName(@"LineOrder").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.LineType).HasColumnName(@"LineType").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Prijs).HasColumnName(@"Prijs").HasColumnType("float").IsOptional();
            Property(x => x.Uc).HasColumnName(@"UC").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.BestelCode).HasColumnName(@"BestelCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Ks).HasColumnName(@"KS").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.LeveradresId).HasColumnName(@"LeveradresID").HasColumnType("bigint").IsOptional();
            Property(x => x.MagazijnId).HasColumnName(@"MagazijnID").HasColumnType("bigint").IsOptional();
            Property(x => x.Code1).HasColumnName(@"Code1").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code2).HasColumnName(@"Code2").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code3).HasColumnName(@"Code3").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code4).HasColumnName(@"Code4").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code5).HasColumnName(@"Code5").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code6).HasColumnName(@"Code6").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code7).HasColumnName(@"Code7").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code8).HasColumnName(@"Code8").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.FullCode).HasColumnName(@"FullCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(2048);
            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.AddedOnLevering).HasColumnName(@"AddedOnLevering").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.WerfLijstId).HasColumnName(@"WerfLijstID").HasColumnType("bigint").IsOptional();
            Property(x => x.InkoopCatId).HasColumnName(@"InkoopCatID").HasColumnType("bigint").IsOptional();
            Property(x => x.InkoopCat).HasColumnName(@"InkoopCat").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.InkoopCatGroup).HasColumnName(@"InkoopCatGroup").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.LeverancierRef).HasColumnName(@"LeverancierRef").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.WerfState).HasColumnName(@"WerfState").HasColumnType("int").IsOptional();
            Property(x => x.FullWerfNumber).HasColumnName(@"FullWerfNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.WerfName).HasColumnName(@"WerfName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.WerfLeider).HasColumnName(@"WerfLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.ProjectLeider).HasColumnName(@"ProjectLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsOptional();
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetime").IsOptional();
            Property(x => x.VoorlopigeOpleveringsdatum).HasColumnName(@"VoorlopigeOpleveringsdatum").HasColumnType("date").IsOptional();
            Property(x => x.DefinitieveOpleveringsdatum).HasColumnName(@"DefinitieveOpleveringsdatum").HasColumnType("date").IsOptional();
            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.ProjectNumber).HasColumnName(@"ProjectNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ProjectNaam).HasColumnName(@"ProjectNaam").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.MasterProjectId).HasColumnName(@"MasterProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.MasterProjectType).HasColumnName(@"MasterProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.MasterProjectNumber).HasColumnName(@"MasterProjectNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.MasterProjectName).HasColumnName(@"MasterProjectName").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.SbNrTxt).HasColumnName(@"SBNrTxt").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Datum).HasColumnName(@"Datum").HasColumnType("datetime").IsOptional();
            Property(x => x.AskDeliveryDate).HasColumnName(@"AskDeliveryDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CreateDate).HasColumnName(@"CreateDate").HasColumnType("datetime").IsOptional();
            Property(x => x.OrderbevestigingsNr).HasColumnName(@"OrderbevestigingsNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.VermoedelijkeLeverdatum).HasColumnName(@"VermoedelijkeLeverdatum").HasColumnType("datetime").IsOptional();
            Property(x => x.Verantwoordelijke).HasColumnName(@"Verantwoordelijke").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.VerantwoordelijkeGsm).HasColumnName(@"VerantwoordelijkeGSM").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Creator).HasColumnName(@"Creator").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.RefIntern).HasColumnName(@"RefIntern").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.RefExtrern).HasColumnName(@"RefExtrern").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.SupplierId).HasColumnName(@"SupplierID").HasColumnType("bigint").IsOptional();
            Property(x => x.SupplierName).HasColumnName(@"SupplierName").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.SupplierAdress1).HasColumnName(@"SupplierAdress1").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.SupplierAdress2).HasColumnName(@"SupplierAdress2").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.SupplierZip).HasColumnName(@"SupplierZip").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.SupplierCity).HasColumnName(@"SupplierCity").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.SupplierCountryCode).HasColumnName(@"SupplierCountryCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.ExternalLocked).HasColumnName(@"ExternalLocked").HasColumnType("bit").IsOptional();
            Property(x => x.LastChangedDate).HasColumnName(@"LastChangedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.LastChangedBy).HasColumnName(@"LastChangedBy").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.DefaultWerfId).HasColumnName(@"DefaultWerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.ContactPerson).HasColumnName(@"ContactPerson").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.BesteldAantal).HasColumnName(@"BesteldAantal").HasColumnType("float").IsOptional();
            Property(x => x.Besteld).HasColumnName(@"Besteld").HasColumnType("float").IsOptional();
            Property(x => x.GeleverdAantal).HasColumnName(@"GeleverdAantal").HasColumnType("float").IsOptional();
            Property(x => x.Geleverd).HasColumnName(@"Geleverd").HasColumnType("float").IsOptional();
            Property(x => x.GeleverdAndUsedAantal).HasColumnName(@"GeleverdAndUsedAantal").HasColumnType("float").IsOptional();
            Property(x => x.GeleverdAndUsed).HasColumnName(@"GeleverdAndUsed").HasColumnType("float").IsOptional();
            Property(x => x.Activiteit).HasColumnName(@"Activiteit").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.Activiteitgroup).HasColumnName(@"Activiteitgroup").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.Company).HasColumnName(@"Company").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.BestelBonType).HasColumnName(@"BestelBonType").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.LanguageCode).HasColumnName(@"LanguageCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
        }
    }
}
