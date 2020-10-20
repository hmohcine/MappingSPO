using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WBestelbonExplorerDxEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WBestelbonExplorerDxEntity>
    {
        public WBestelbonExplorerDxEntityConfiguration()
            : this("dbo")
        {
        }

        public WBestelbonExplorerDxEntityConfiguration(string schema)
        {
            ToTable("vwBestelbonExplorerDX", schema);
            HasKey(x => new { x.Sbid, x.Status, x.BestelBonType, x.IsRetour });

            Property(x => x.Sbid).HasColumnName(@"SBID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
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
            Property(x => x.BestelBonType).HasColumnName(@"BestelBonType").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TotalPrice).HasColumnName(@"TotalPrice").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.Geleverd).HasColumnName(@"Geleverd").HasColumnType("decimal").IsOptional().HasPrecision(38,8);
            Property(x => x.GeleverdAndUsed).HasColumnName(@"GeleverdAndUsed").HasColumnType("decimal").IsOptional().HasPrecision(38,8);
            Property(x => x.Gefactureerd).HasColumnName(@"Gefactureerd").HasColumnType("decimal").IsOptional().HasPrecision(38,8);
            Property(x => x.LanguageCode).HasColumnName(@"LanguageCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.TotalNumberOfPrints).HasColumnName(@"TotalNumberOfPrints").HasColumnType("int").IsOptional();
            Property(x => x.LastPrintDate).HasColumnName(@"LastPrintDate").HasColumnType("datetime").IsOptional();
            Property(x => x.LastChangedDate).HasColumnName(@"LastChangedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.LastChangedBy).HasColumnName(@"LastChangedBy").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.DefaultWerfId).HasColumnName(@"DefaultWerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(1);
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
            Property(x => x.ContactPerson).HasColumnName(@"ContactPerson").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.InkoopCats).HasColumnName(@"InkoopCats").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.InkoopCatGroups).HasColumnName(@"InkoopCatGroups").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Company).HasColumnName(@"Company").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.IsRetour).HasColumnName(@"IsRetour").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }
}
