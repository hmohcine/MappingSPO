using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WCostExplorerDxEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WCostExplorerDxEntity>
    {
        public WCostExplorerDxEntityConfiguration()
            : this("dbo")
        {
        }

        public WCostExplorerDxEntityConfiguration(string schema)
        {
            ToTable("vwCostExplorerDX", schema);
            HasKey(x => new { x.DetailId, x.CostHeaderId, x.CostHeaderType, x.MasterType, x.Aantal, x.Ekp, x.Kp, x.Evp, x.Vp, x.Status });

            Property(x => x.DetailId).HasColumnName(@"DetailID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CostHeaderId).HasColumnName(@"CostHeaderID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CostHeaderType).HasColumnName(@"CostHeaderType").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.MasterType).HasColumnName(@"MasterType").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CostHeaderTypeDescription).HasColumnName(@"CostHeaderTypeDescription").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.IngaveDatum).HasColumnName(@"IngaveDatum").HasColumnType("datetime").IsOptional();
            Property(x => x.Documentnummer).HasColumnName(@"Documentnummer").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.VerantwoordelijkeIngave).HasColumnName(@"VerantwoordelijkeIngave").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.VerantwoordelijkeIngaveGsm).HasColumnName(@"VerantwoordelijkeIngaveGSM").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.RelationId).HasColumnName(@"RelationID").HasColumnType("bigint").IsOptional();
            Property(x => x.SupplierName).HasColumnName(@"SupplierName").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.SupplierAdressLine1).HasColumnName(@"SupplierAdressLine1").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.SupplierAdressLine2).HasColumnName(@"SupplierAdressLine2").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.SupplierZip).HasColumnName(@"SupplierZip").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.SupplierCity).HasColumnName(@"SupplierCity").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.SupplierCountryCode).HasColumnName(@"SupplierCountryCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.ContactId).HasColumnName(@"ContactID").HasColumnType("int").IsOptional();
            Property(x => x.ContactName).HasColumnName(@"ContactName").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.WerfState).HasColumnName(@"WerfState").HasColumnType("int").IsOptional();
            Property(x => x.FullWerfNumber).HasColumnName(@"FullWerfNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.WerfName).HasColumnName(@"WerfName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.WerfLeider).HasColumnName(@"WerfLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.ProjectLeider).HasColumnName(@"ProjectLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.ProjectNumber).HasColumnName(@"ProjectNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ProjectNaam).HasColumnName(@"ProjectNaam").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.MasterProjectId).HasColumnName(@"MasterProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.MasterProjectType).HasColumnName(@"MasterProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.MasterProjectNumber).HasColumnName(@"MasterProjectNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.MasterProjectName).HasColumnName(@"MasterProjectName").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.Ks).HasColumnName(@"KS").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.Kg).HasColumnName(@"KG").HasColumnType("int").IsOptional();
            Property(x => x.Activiteit).HasColumnName(@"Activiteit").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.ActiviteitGroup).HasColumnName(@"ActiviteitGroup").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
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
            Property(x => x.Aantal).HasColumnName(@"Aantal").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ekp).HasColumnName(@"EKP").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Kp).HasColumnName(@"KP").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Evp).HasColumnName(@"EVP").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Vp).HasColumnName(@"VP").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RegieYn).HasColumnName(@"RegieYn").HasColumnType("bit").IsOptional();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Documentdatum).HasColumnName(@"Documentdatum").HasColumnType("datetime").IsOptional();
            Property(x => x.Referentie).HasColumnName(@"Referentie").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.ReferentieIntern).HasColumnName(@"ReferentieIntern").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.FactuurNr).HasColumnName(@"FactuurNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.FactuurDatum).HasColumnName(@"FactuurDatum").HasColumnType("datetime").IsOptional();
            Property(x => x.Goedgekeurd).HasColumnName(@"Goedgekeurd").HasColumnType("bit").IsOptional();
            Property(x => x.InkoopCat).HasColumnName(@"InkoopCat").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.InkoopCatGroup).HasColumnName(@"InkoopCatGroup").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.Company).HasColumnName(@"Company").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.AfmeldingsPunt).HasColumnName(@"AfmeldingsPunt").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.EmpName).HasColumnName(@"EmpName").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.WerkCode).HasColumnName(@"WerkCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.WerkCodeDescription).HasColumnName(@"WerkCodeDescription").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.IsWerkend).HasColumnName(@"IsWerkend").HasColumnType("bit").IsOptional();
            Property(x => x.WerkCodeExtern).HasColumnName(@"WerkCodeExtern").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.MobiliteitsCode).HasColumnName(@"MobiliteitsCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.Mobiliteit).HasColumnName(@"Mobiliteit").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.StartUur).HasColumnName(@"StartUur").HasColumnType("datetime").IsOptional();
            Property(x => x.EindUur).HasColumnName(@"EindUur").HasColumnType("datetime").IsOptional();
            Property(x => x.RustTijd).HasColumnName(@"RustTijd").HasColumnType("bigint").IsOptional();
            Property(x => x.LaadLosTijd).HasColumnName(@"LaadLosTijd").HasColumnType("bigint").IsOptional();
            Property(x => x.ExtraTijd).HasColumnName(@"ExtraTijd").HasColumnType("bigint").IsOptional();
            Property(x => x.ContractId).HasColumnName(@"ContractID").HasColumnType("bigint").IsOptional();
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsOptional();
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetime").IsOptional();
            Property(x => x.VoorlopigeOpleveringsdatum).HasColumnName(@"VoorlopigeOpleveringsdatum").HasColumnType("date").IsOptional();
            Property(x => x.DefinitieveOpleveringsdatum).HasColumnName(@"DefinitieveOpleveringsdatum").HasColumnType("date").IsOptional();
            Property(x => x.SupplierLanguage).HasColumnName(@"SupplierLanguage").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
        }
    }
}
