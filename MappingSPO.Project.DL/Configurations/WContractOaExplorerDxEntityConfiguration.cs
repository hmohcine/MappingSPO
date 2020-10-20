using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WContractOaExplorerDxEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WContractOaExplorerDxEntity>
    {
        public WContractOaExplorerDxEntityConfiguration()
            : this("dbo")
        {
        }

        public WContractOaExplorerDxEntityConfiguration(string schema)
        {
            ToTable("vwContractOAExplorerDX", schema);
            HasKey(x => new { x.ContractId, x.ContractState, x.ContractName, x.ContractTypeId, x.ContractYear, x.ContractNumber, x.Domain, x.WerfId, x.WerfState, x.WerfName });

            Property(x => x.ContractId).HasColumnName(@"ContractID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ContractState).HasColumnName(@"ContractState").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ContractNr).HasColumnName(@"ContractNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.ContractName).HasColumnName(@"ContractName").HasColumnType("nvarchar").IsRequired().HasMaxLength(200).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Creator).HasColumnName(@"Creator").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsOptional();
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetime").IsOptional();
            Property(x => x.ContractTypeId).HasColumnName(@"ContractTypeID").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ContractYear).HasColumnName(@"ContractYear").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ContractNumber).HasColumnName(@"ContractNumber").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CreatorId).HasColumnName(@"CreatorID").HasColumnType("int").IsOptional();
            Property(x => x.Code1).HasColumnName(@"Code1").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code2).HasColumnName(@"Code2").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code3).HasColumnName(@"Code3").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code4).HasColumnName(@"Code4").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code5).HasColumnName(@"Code5").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code6).HasColumnName(@"Code6").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code7).HasColumnName(@"Code7").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code8).HasColumnName(@"Code8").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Ref1).HasColumnName(@"Ref1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref2).HasColumnName(@"Ref2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref3).HasColumnName(@"Ref3").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref4).HasColumnName(@"Ref4").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.VerantWoordelijke1).HasColumnName(@"VerantWoordelijke1").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.VerantWoordelijke1Gsm).HasColumnName(@"VerantWoordelijke1_GSM").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.VerantWoordelijke2).HasColumnName(@"VerantWoordelijke2").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.VerantWoordelijke2Gsm).HasColumnName(@"VerantWoordelijke2_GSM").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.ExtNumberWerf).HasColumnName(@"ExtNumberWerf").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.CheckInAtWorkYnWerf).HasColumnName(@"CheckInAtWorkYnWerf").HasColumnType("bit").IsOptional();
            Property(x => x.PathDocsFileSystem).HasColumnName(@"PathDocsFileSystem").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ExtraNum1).HasColumnName(@"ExtraNum1").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum2).HasColumnName(@"ExtraNum2").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum3).HasColumnName(@"ExtraNum3").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum4).HasColumnName(@"ExtraNum4").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum5).HasColumnName(@"ExtraNum5").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum6).HasColumnName(@"ExtraNum6").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum7).HasColumnName(@"ExtraNum7").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum8).HasColumnName(@"ExtraNum8").HasColumnType("float").IsOptional();
            Property(x => x.VoorlopigeOpleveringsdatum).HasColumnName(@"VoorlopigeOpleveringsdatum").HasColumnType("date").IsOptional();
            Property(x => x.DefinitieveOpleveringsdatum).HasColumnName(@"DefinitieveOpleveringsdatum").HasColumnType("date").IsOptional();
            Property(x => x.ExtraDate1).HasColumnName(@"ExtraDate1").HasColumnType("date").IsOptional();
            Property(x => x.ExtraDate2).HasColumnName(@"ExtraDate2").HasColumnType("date").IsOptional();
            Property(x => x.ExtraDate3).HasColumnName(@"ExtraDate3").HasColumnType("date").IsOptional();
            Property(x => x.ExtraDate4).HasColumnName(@"ExtraDate4").HasColumnType("date").IsOptional();
            Property(x => x.ExtraDate5).HasColumnName(@"ExtraDate5").HasColumnType("date").IsOptional();
            Property(x => x.ExtraDate6).HasColumnName(@"ExtraDate6").HasColumnType("date").IsOptional();
            Property(x => x.ExtraDate7).HasColumnName(@"ExtraDate7").HasColumnType("date").IsOptional();
            Property(x => x.ExtraDate8).HasColumnName(@"ExtraDate8").HasColumnType("date").IsOptional();
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BudgetTkp).HasColumnName(@"BudgetTKP").HasColumnType("float").IsOptional();
            Property(x => x.WerfAdresName).HasColumnName(@"WerfAdresName").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.WerfAdres).HasColumnName(@"WerfAdres").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.WerfFactuurAdresName).HasColumnName(@"WerfFactuurAdresName").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.WerfFactuurAdres).HasColumnName(@"WerfFactuurAdres").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.CreditVorderingVpState0).HasColumnName(@"CreditVorderingVPState0").HasColumnType("float").IsOptional();
            Property(x => x.CreditVorderingVpState1).HasColumnName(@"CreditVorderingVPState1").HasColumnType("float").IsOptional();
            Property(x => x.CreditVorderingVpState2).HasColumnName(@"CreditVorderingVPState2").HasColumnType("float").IsOptional();
            Property(x => x.CreditVorderingVpState3).HasColumnName(@"CreditVorderingVPState3").HasColumnType("float").IsOptional();
            Property(x => x.CreditVorderingVpState45).HasColumnName(@"CreditVorderingVPState45").HasColumnType("float").IsOptional();
            Property(x => x.CreditVorderingVpStateH1).HasColumnName(@"CreditVorderingVPStateH1").HasColumnType("float").IsOptional();
            Property(x => x.CreditVorderingVpStateL2).HasColumnName(@"CreditVorderingVPStateL2").HasColumnType("float").IsOptional();
            Property(x => x.FirstCreditVordDate).HasColumnName(@"FirstCreditVordDate").HasColumnType("datetime").IsOptional();
            Property(x => x.LastCreditVordDate).HasColumnName(@"LastCreditVordDate").HasColumnType("datetime").IsOptional();
            Property(x => x.TotalCostContract).HasColumnName(@"TotalCostContract").HasColumnType("float").IsOptional();
            Property(x => x.PurchaseInvoiceTotal).HasColumnName(@"PurchaseInvoiceTotal").HasColumnType("decimal").IsOptional().HasPrecision(38,8);
            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.ProjectNumber).HasColumnName(@"ProjectNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ProjectNaam).HasColumnName(@"ProjectNaam").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.MasterProjectId).HasColumnName(@"MasterProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.MasterProjectType).HasColumnName(@"MasterProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.MasterProjectNumber).HasColumnName(@"MasterProjectNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.MasterProjectName).HasColumnName(@"MasterProjectName").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsOptional();
            Property(x => x.CompanyName).HasColumnName(@"CompanyName").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.SupplierRelationId).HasColumnName(@"SupplierRelationID").HasColumnType("bigint").IsOptional();
            Property(x => x.Supplier).HasColumnName(@"Supplier").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.SupplierAdres1).HasColumnName(@"SupplierAdres1").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.SupplierAdres2).HasColumnName(@"SupplierAdres2").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.SupplierCity).HasColumnName(@"SupplierCity").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.SupplierZip).HasColumnName(@"SupplierZip").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.SupplierCountryCode).HasColumnName(@"SupplierCountryCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.ContactName).HasColumnName(@"ContactName").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.InkoopCats).HasColumnName(@"InkoopCats").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.InkoopCatGroups).HasColumnName(@"InkoopCatGroups").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.RelationTypeId).HasColumnName(@"RelationTypeID").HasColumnType("int").IsOptional();
            Property(x => x.WerfState).HasColumnName(@"WerfState").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.WerfName).HasColumnName(@"WerfName").HasColumnType("nvarchar").IsRequired().HasMaxLength(200).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FullWerfNumber).HasColumnName(@"FullWerfNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.LanguageCode).HasColumnName(@"LanguageCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
        }
    }
}
