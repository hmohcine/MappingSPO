using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WWerfExplorerDxEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WWerfExplorerDxEntity>
    {
        public WWerfExplorerDxEntityConfiguration()
            : this("dbo")
        {
        }

        public WWerfExplorerDxEntityConfiguration(string schema)
        {
            ToTable("vwWerfExplorerDX", schema);
            HasKey(x => x.WerfId);

            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.WerfState).HasColumnName(@"WerfState").HasColumnType("int").IsRequired();
            Property(x => x.FullWerfNumber).HasColumnName(@"FullWerfNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.WerfName).HasColumnName(@"WerfName").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Creator).HasColumnName(@"Creator").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsOptional();
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetime").IsOptional();
            Property(x => x.WerfTypeId).HasColumnName(@"WerfTypeID").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(2);
            Property(x => x.WerfYear).HasColumnName(@"WerfYear").HasColumnType("int").IsRequired();
            Property(x => x.WerfNumber).HasColumnName(@"WerfNumber").HasColumnType("int").IsRequired();
            Property(x => x.CreatorId).HasColumnName(@"CreatorID").HasColumnType("int").IsOptional();
            Property(x => x.DefailtCompanyId).HasColumnName(@"DefailtCompanyID").HasColumnType("int").IsOptional();
            Property(x => x.DefaultCompany).HasColumnName(@"DefaultCompany").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
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
            Property(x => x.WerfLeider).HasColumnName(@"WerfLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.WerfLeiderGsm).HasColumnName(@"WerfLeiderGSM").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.ProjectLeider).HasColumnName(@"ProjectLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.ProjectLeiderGsm).HasColumnName(@"ProjectLeiderGSM").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.ExtNumber).HasColumnName(@"ExtNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.CheckInAtWorkYn).HasColumnName(@"CheckInAtWorkYn").HasColumnType("bit").IsOptional();
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
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1);
            Property(x => x.BudgetTkp).HasColumnName(@"BudgetTKP").HasColumnType("float").IsOptional();
            Property(x => x.BudgetTvp).HasColumnName(@"BudgetTVP").HasColumnType("float").IsOptional();
            Property(x => x.AnaCode1).HasColumnName(@"AnaCode1").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.AnaCode2).HasColumnName(@"AnaCode2").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.AnaCode3).HasColumnName(@"AnaCode3").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.AnaCode4).HasColumnName(@"AnaCode4").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.AnaCode5).HasColumnName(@"AnaCode5").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.AnaCode6).HasColumnName(@"AnaCode6").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.AnaCode7).HasColumnName(@"AnaCode7").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.AnaCode8).HasColumnName(@"AnaCode8").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.KlantAdresName).HasColumnName(@"KlantAdresName").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.KlantAdres).HasColumnName(@"KlantAdres").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.WerfAdresName).HasColumnName(@"WerfAdresName").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.WerfAdres).HasColumnName(@"WerfAdres").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.FactuurAdresName).HasColumnName(@"FactuurAdresName").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.FactuurAdres).HasColumnName(@"FactuurAdres").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.VorderingVpState0).HasColumnName(@"VorderingVPState0").HasColumnType("float").IsOptional();
            Property(x => x.VorderingVpState1).HasColumnName(@"VorderingVPState1").HasColumnType("float").IsOptional();
            Property(x => x.VorderingVpState2).HasColumnName(@"VorderingVPState2").HasColumnType("float").IsOptional();
            Property(x => x.VorderingVpState3).HasColumnName(@"VorderingVPState3").HasColumnType("float").IsOptional();
            Property(x => x.VorderingVpState45).HasColumnName(@"VorderingVPState45").HasColumnType("float").IsOptional();
            Property(x => x.VorderingVpStateH1).HasColumnName(@"VorderingVPStateH1").HasColumnType("float").IsOptional();
            Property(x => x.VorderingVpStateL2).HasColumnName(@"VorderingVPStateL2").HasColumnType("float").IsOptional();
            Property(x => x.FirstVordDate).HasColumnName(@"FirstVordDate").HasColumnType("datetime").IsOptional();
            Property(x => x.LastVordDate).HasColumnName(@"LastVordDate").HasColumnType("datetime").IsOptional();
            Property(x => x.SalesInvoiceState0).HasColumnName(@"SalesInvoiceState0").HasColumnType("decimal").IsOptional().HasPrecision(38,8);
            Property(x => x.SalesInvoiceState1).HasColumnName(@"SalesInvoiceState1").HasColumnType("decimal").IsOptional().HasPrecision(38,8);
            Property(x => x.SalesInvoiceState2).HasColumnName(@"SalesInvoiceState2").HasColumnType("decimal").IsOptional().HasPrecision(38,8);
            Property(x => x.SalesInvoiceState3).HasColumnName(@"SalesInvoiceState3").HasColumnType("decimal").IsOptional().HasPrecision(38,8);
            Property(x => x.SalesInvoiceStateAf).HasColumnName(@"SalesInvoiceStateAF").HasColumnType("decimal").IsOptional().HasPrecision(38,8);
            Property(x => x.TvpExcl).HasColumnName(@"TVPExcl").HasColumnType("decimal").IsOptional().HasPrecision(38,8);
            Property(x => x.VatAmount).HasColumnName(@"VATAmount").HasColumnType("decimal").IsOptional().HasPrecision(38,8);
            Property(x => x.TvpIncl).HasColumnName(@"TVPIncl").HasColumnType("decimal").IsOptional().HasPrecision(38,8);
            Property(x => x.SalesInvoiceBetaald).HasColumnName(@"SalesInvoiceBetaald").HasColumnType("float").IsOptional();
            Property(x => x.SalesInvoiceTeBetalen).HasColumnName(@"SalesInvoiceTeBetalen").HasColumnType("float").IsOptional();
            Property(x => x.TotBasteldBb).HasColumnName(@"TotBasteldBB").HasColumnType("float").IsOptional();
            Property(x => x.TotBesteldOa).HasColumnName(@"TotBesteldOA").HasColumnType("float").IsOptional();
            Property(x => x.TotBesteld).HasColumnName(@"TotBesteld").HasColumnType("float").IsRequired();
            Property(x => x.TotalCostCost).HasColumnName(@"TotalCostCost").HasColumnType("float").IsOptional();
            Property(x => x.TotalCostContract).HasColumnName(@"TotalCostContract").HasColumnType("float").IsOptional();
            Property(x => x.TotalCost).HasColumnName(@"TotalCost").HasColumnType("float").IsRequired();
            Property(x => x.PurchaseInvoiceTotal).HasColumnName(@"PurchaseInvoiceTotal").HasColumnType("decimal").IsOptional().HasPrecision(38,8);
            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.ProjectNumber).HasColumnName(@"ProjectNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ProjectNaam).HasColumnName(@"ProjectNaam").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.MasterProjectId).HasColumnName(@"MasterProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.MasterProjectType).HasColumnName(@"MasterProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.MasterProjectNumber).HasColumnName(@"MasterProjectNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.MasterProjectName).HasColumnName(@"MasterProjectName").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.CalStartDate).HasColumnName(@"CalStartDate").HasColumnType("date").IsOptional();
            Property(x => x.CalEndDate).HasColumnName(@"CalEndDate").HasColumnType("date").IsOptional();
            Property(x => x.CalContractDate).HasColumnName(@"CalContractDate").HasColumnType("date").IsOptional();
            Property(x => x.CalApprovedDate).HasColumnName(@"CalApprovedDate").HasColumnType("date").IsOptional();
            Property(x => x.CalStartCommandDate).HasColumnName(@"CalStartCommandDate").HasColumnType("date").IsOptional();
            Property(x => x.LanguageCode).HasColumnName(@"LanguageCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
        }
    }
}
