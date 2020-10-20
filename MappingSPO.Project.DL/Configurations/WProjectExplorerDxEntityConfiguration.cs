using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WProjectExplorerDxEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WProjectExplorerDxEntity>
    {
        public WProjectExplorerDxEntityConfiguration()
            : this("dbo")
        {
        }

        public WProjectExplorerDxEntityConfiguration(string schema)
        {
            ToTable("vwProjectExplorerDX", schema);
            HasKey(x => new { x.ProjectId, x.ProjectType });

            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsRequired().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.GlobalId).HasColumnName(@"GlobalID").HasColumnType("bigint").IsRequired();
            Property(x => x.ProjectYear).HasColumnName(@"ProjectYear").HasColumnType("int").IsRequired();
            Property(x => x.ProjectNumber).HasColumnName(@"ProjectNumber").HasColumnType("int").IsRequired();
            Property(x => x.ProjectNrText).HasColumnName(@"ProjectNrText").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.ProjectName).HasColumnName(@"ProjectName").HasColumnType("nvarchar").IsRequired().HasMaxLength(250);
            Property(x => x.ProjectDate).HasColumnName(@"ProjectDate").HasColumnType("datetime").IsRequired();
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsOptional();
            Property(x => x.DueDate).HasColumnName(@"DueDate").HasColumnType("datetime").IsOptional();
            Property(x => x.DoneDate).HasColumnName(@"DoneDate").HasColumnType("datetime").IsOptional();
            Property(x => x.CreateDate).HasColumnName(@"CreateDate").HasColumnType("datetime").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.UpdateDate).HasColumnName(@"UpdateDate").HasColumnType("datetime").IsRequired();
            Property(x => x.UpdatedBy).HasColumnName(@"UpdatedBy").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.Owner).HasColumnName(@"Owner").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.Company).HasColumnName(@"Company").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.Ref1).HasColumnName(@"Ref1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref2).HasColumnName(@"Ref2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref3).HasColumnName(@"Ref3").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref4).HasColumnName(@"Ref4").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ProjectResult).HasColumnName(@"ProjectResult").HasColumnType("int").IsRequired();
            Property(x => x.HasExtendedSecurity).HasColumnName(@"HasExtendedSecurity").HasColumnType("bit").IsRequired();
            Property(x => x.Code1).HasColumnName(@"Code1").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code2).HasColumnName(@"Code2").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code3).HasColumnName(@"Code3").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code4).HasColumnName(@"Code4").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code5).HasColumnName(@"Code5").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code6).HasColumnName(@"Code6").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code7).HasColumnName(@"Code7").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code8).HasColumnName(@"Code8").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.ProjectVerantWoordelijke1).HasColumnName(@"ProjectVerantWoordelijke1").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.ProjectVerantWoordelijke2).HasColumnName(@"ProjectVerantWoordelijke2").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.ProjectVerantWoordelijke3).HasColumnName(@"ProjectVerantWoordelijke3").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.RelationId).HasColumnName(@"RelationID").HasColumnType("bigint").IsOptional();
            Property(x => x.MainRelationType).HasColumnName(@"MainRelationType").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.MainRelationName).HasColumnName(@"MainRelationName").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.AdressLine1).HasColumnName(@"AdressLine1").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.AdressLine2).HasColumnName(@"AdressLine2").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.ZipCode).HasColumnName(@"ZipCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.City).HasColumnName(@"City").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.CurrentState).HasColumnName(@"CurrentState").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.CurrentStateIcon).HasColumnName(@"CurrentStateIcon").HasColumnType("image").IsOptional().HasMaxLength(2147483647);
            Property(x => x.CurrentStateWorkflow).HasColumnName(@"CurrentStateWorkflow").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.ProjectDone).HasColumnName(@"ProjectDone").HasColumnType("bit").IsRequired();
            Property(x => x.ExtraDate1).HasColumnName(@"ExtraDate1").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtraDate2).HasColumnName(@"ExtraDate2").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtraDate3).HasColumnName(@"ExtraDate3").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtraDate4).HasColumnName(@"ExtraDate4").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtraDate5).HasColumnName(@"ExtraDate5").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtraDate6).HasColumnName(@"ExtraDate6").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtraDate7).HasColumnName(@"ExtraDate7").HasColumnType("datetime").IsOptional();
            Property(x => x.ContactId).HasColumnName(@"ContactID").HasColumnType("int").IsOptional();
            Property(x => x.ProjectResultReason).HasColumnName(@"ProjectResultReason").HasColumnType("int").IsOptional();
            Property(x => x.ProjectResultReasonText).HasColumnName(@"ProjectResultReasonText").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.ForeCastDate).HasColumnName(@"ForeCastDate").HasColumnType("datetime").IsOptional();
            Property(x => x.OppertunityValue).HasColumnName(@"OppertunityValue").HasColumnType("bigint").IsOptional();
            Property(x => x.OpportunityPct).HasColumnName(@"OpportunityPct").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum1).HasColumnName(@"ExtraNum1").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.ExtraNum2).HasColumnName(@"ExtraNum2").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.ExtraNum3).HasColumnName(@"ExtraNum3").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.ExtraNum4).HasColumnName(@"ExtraNum4").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.ExtraNum5).HasColumnName(@"ExtraNum5").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.ExtraNum6).HasColumnName(@"ExtraNum6").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.ExtraNum7).HasColumnName(@"ExtraNum7").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.ExtraNum8).HasColumnName(@"ExtraNum8").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.MainContact).HasColumnName(@"MainContact").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.ProjectMasterType).HasColumnName(@"ProjectMasterType").HasColumnType("int").IsOptional();
            Property(x => x.ExtNumber).HasColumnName(@"ExtNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.CountryCode).HasColumnName(@"CountryCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.TeamsUrl).HasColumnName(@"TeamsUrl").HasColumnType("nvarchar").IsOptional().HasMaxLength(1000);
            Property(x => x.MasterProjectId).HasColumnName(@"MasterProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.MasterProjectType).HasColumnName(@"MasterProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.MasterProjectNrText).HasColumnName(@"MasterProjectNrText").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.MasterProjectName).HasColumnName(@"MasterProjectName").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.BudgetViaCalc).HasColumnName(@"BudgetViaCalc").HasColumnType("float").IsOptional();
            Property(x => x.TvpViaCalc).HasColumnName(@"TVPViaCalc").HasColumnType("float").IsOptional();
            Property(x => x.BudgetViaWerf).HasColumnName(@"BudgetViaWerf").HasColumnType("float").IsOptional();
            Property(x => x.TvpViaWerf).HasColumnName(@"TVPViaWerf").HasColumnType("float").IsOptional();
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
            Property(x => x.SalesInvoiceTvpExcl).HasColumnName(@"SalesInvoiceTVPExcl").HasColumnType("decimal").IsOptional().HasPrecision(38,8);
            Property(x => x.SalesInvoiceVatAmount).HasColumnName(@"SalesInvoiceVATAmount").HasColumnType("decimal").IsOptional().HasPrecision(38,8);
            Property(x => x.SalesInvoiceTvpIncl).HasColumnName(@"SalesInvoiceTVPIncl").HasColumnType("decimal").IsOptional().HasPrecision(38,8);
            Property(x => x.SalesInvoiceBetaald).HasColumnName(@"SalesInvoiceBetaald").HasColumnType("float").IsOptional();
            Property(x => x.SalesInvoiceTeBetalen).HasColumnName(@"SalesInvoiceTeBetalen").HasColumnType("float").IsOptional();
            Property(x => x.TotBesteldBb).HasColumnName(@"TotBesteldBB").HasColumnType("float").IsOptional();
            Property(x => x.TotBesteldOa).HasColumnName(@"TotBesteldOA").HasColumnType("float").IsOptional();
            Property(x => x.TotBesteld).HasColumnName(@"TotBesteld").HasColumnType("float").IsOptional();
            Property(x => x.TotalCostCost).HasColumnName(@"TotalCostCost").HasColumnType("float").IsOptional();
            Property(x => x.TotalCostContract).HasColumnName(@"TotalCostContract").HasColumnType("float").IsOptional();
            Property(x => x.TotalCost).HasColumnName(@"TotalCost").HasColumnType("float").IsOptional();
            Property(x => x.PurchaseInvoiceTotal).HasColumnName(@"PurchaseInvoiceTotal").HasColumnType("decimal").IsOptional().HasPrecision(38,8);
            Property(x => x.CheckInAtWorkYn).HasColumnName(@"CheckInAtWorkYn").HasColumnType("bit").IsOptional();
            Property(x => x.CExtNumber).HasColumnName(@"cExtNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(4000);
            Property(x => x.SubCategory).HasColumnName(@"SubCategory").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ProjectState).HasColumnName(@"ProjectState").HasColumnType("int").IsRequired();
            Property(x => x.ProjectTvp).HasColumnName(@"ProjectTVP").HasColumnType("float").IsOptional();
            Property(x => x.LanguageCode).HasColumnName(@"LanguageCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
        }
    }
}
