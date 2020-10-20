using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WProjectExplorerEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WProjectExplorerEntity>
    {
        public WProjectExplorerEntityConfiguration()
            : this("dbo")
        {
        }

        public WProjectExplorerEntityConfiguration(string schema)
        {
            ToTable("vwProjectExplorer", schema);
            HasKey(x => new { x.ProjectId, x.ProjectType, x.ProjectYear, x.ProjectNumber, x.ProjectNrText, x.ProjectName, x.ProjectDate, x.CreateDate, x.UpdateDate, x.CreatedBy, x.UpdatedBy, x.OwnerId, x.ProjectResult, x.ProjectResultText, x.HasExtendedSecurity, x.ProjectDone, x.ProjectDoneText, x.CountOfExtInvoiceTodo });

            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsRequired().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectYear).HasColumnName(@"ProjectYear").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectNumber).HasColumnName(@"ProjectNumber").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectNrText).HasColumnName(@"ProjectNrText").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectName).HasColumnName(@"ProjectName").HasColumnType("nvarchar").IsRequired().HasMaxLength(250).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectDate).HasColumnName(@"ProjectDate").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsOptional();
            Property(x => x.DueDate).HasColumnName(@"DueDate").HasColumnType("datetime").IsOptional();
            Property(x => x.DoneDate).HasColumnName(@"DoneDate").HasColumnType("datetime").IsOptional();
            Property(x => x.CreateDate).HasColumnName(@"CreateDate").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UpdateDate).HasColumnName(@"UpdateDate").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Creator).HasColumnName(@"Creator").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.UpdatedBy).HasColumnName(@"UpdatedBy").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.LastChangedBy).HasColumnName(@"LastChangedBy").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.OwnerId).HasColumnName(@"OwnerID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Owner).HasColumnName(@"Owner").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.DefaultCompanyId).HasColumnName(@"DefaultCompanyID").HasColumnType("int").IsOptional();
            Property(x => x.Company).HasColumnName(@"Company").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.Ref1).HasColumnName(@"Ref1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref2).HasColumnName(@"Ref2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref3).HasColumnName(@"Ref3").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref4).HasColumnName(@"Ref4").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.IdProjectVerantWoordelijke1).HasColumnName(@"IDProjectVerantWoordelijke1").HasColumnType("int").IsOptional();
            Property(x => x.IdProjectVerantWoordelijke2).HasColumnName(@"IDProjectVerantWoordelijke2").HasColumnType("int").IsOptional();
            Property(x => x.IdProjectVerantWoordelijke3).HasColumnName(@"IDProjectVerantWoordelijke3").HasColumnType("int").IsOptional();
            Property(x => x.ProjectResult).HasColumnName(@"ProjectResult").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectResultText).HasColumnName(@"ProjectResultText").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(13).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.HasExtendedSecurity).HasColumnName(@"HasExtendedSecurity").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Code1).HasColumnName(@"Code1").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code2).HasColumnName(@"Code2").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code3).HasColumnName(@"Code3").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code4).HasColumnName(@"Code4").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code5).HasColumnName(@"Code5").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code6).HasColumnName(@"Code6").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code7).HasColumnName(@"Code7").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code8).HasColumnName(@"Code8").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.IdCode1).HasColumnName(@"IDCode1").HasColumnType("int").IsOptional();
            Property(x => x.IdCode2).HasColumnName(@"IDCode2").HasColumnType("int").IsOptional();
            Property(x => x.IdCode3).HasColumnName(@"IDCode3").HasColumnType("int").IsOptional();
            Property(x => x.IdCode4).HasColumnName(@"IDCode4").HasColumnType("int").IsOptional();
            Property(x => x.IdCode5).HasColumnName(@"IDCode5").HasColumnType("int").IsOptional();
            Property(x => x.IdCode6).HasColumnName(@"IDCode6").HasColumnType("int").IsOptional();
            Property(x => x.IdCode7).HasColumnName(@"IDCode7").HasColumnType("int").IsOptional();
            Property(x => x.IdCode8).HasColumnName(@"IDCode8").HasColumnType("int").IsOptional();
            Property(x => x.ProjectVerantWoordelijke1).HasColumnName(@"ProjectVerantWoordelijke1").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.ProjectVerantWoordelijke2).HasColumnName(@"ProjectVerantWoordelijke2").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.ProjectVerantWoordelijke3).HasColumnName(@"ProjectVerantWoordelijke3").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.RelationTypeId).HasColumnName(@"RelationTypeID").HasColumnType("int").IsOptional();
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
            Property(x => x.CurrentStateId).HasColumnName(@"CurrentStateID").HasColumnType("bigint").IsOptional();
            Property(x => x.ProjectDone).HasColumnName(@"ProjectDone").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectDoneText).HasColumnName(@"ProjectDoneText").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
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
            Property(x => x.OriginalWorkFlowId).HasColumnName(@"OriginalWorkFlowID").HasColumnType("bigint").IsOptional();
            Property(x => x.OpportunityPct).HasColumnName(@"OpportunityPct").HasColumnType("float").IsOptional();
            Property(x => x.OpportunityPctInText).HasColumnName(@"OpportunityPctInText").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(15);
            Property(x => x.ForeCastOwner).HasColumnName(@"ForeCastOwner").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.TvpWerf).HasColumnName(@"TVPWerf").HasColumnType("float").IsOptional();
            Property(x => x.TvpCalc).HasColumnName(@"TVPCalc").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum1).HasColumnName(@"ExtraNum1").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.ExtraNum2).HasColumnName(@"ExtraNum2").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.ExtraNum3).HasColumnName(@"ExtraNum3").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.ExtraNum4).HasColumnName(@"ExtraNum4").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.ExtraNum5).HasColumnName(@"ExtraNum5").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.ExtraNum6).HasColumnName(@"ExtraNum6").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.ExtraNum7).HasColumnName(@"ExtraNum7").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.ExtraNum8).HasColumnName(@"ExtraNum8").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.MainRelationPhone1).HasColumnName(@"MainRelationPhone1").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.MainRelationPhone2).HasColumnName(@"MainRelationPhone2").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.MainRelationEmail1).HasColumnName(@"MainRelationEmail1").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.MainRelationEmail2).HasColumnName(@"MainRelationEmail2").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.MainRelationGsm).HasColumnName(@"MainRelationGSM").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.MainContact).HasColumnName(@"MainContact").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.MainContactPhone).HasColumnName(@"MainContactPhone").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.MainContactEmail).HasColumnName(@"MainContactEmail").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.MainContactGsm).HasColumnName(@"MainContactGSM").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.CountOfExtInvoiceTodo).HasColumnName(@"CountOfExtInvoiceTodo").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.MasterPid).HasColumnName(@"MasterPID").HasColumnType("bigint").IsOptional();
            Property(x => x.MasterPType).HasColumnName(@"MasterPType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.MasterProjectNr).HasColumnName(@"MasterProjectNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.MasterProjectName).HasColumnName(@"MasterProjectName").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.RegioId).HasColumnName(@"RegioID").HasColumnType("bigint").IsOptional();
            Property(x => x.Regio).HasColumnName(@"Regio").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.MasterProjectRelationTypeId).HasColumnName(@"MasterProjectRelationTypeID").HasColumnType("int").IsOptional();
            Property(x => x.MasterProjectRelationId).HasColumnName(@"MasterProjectRelationID").HasColumnType("bigint").IsOptional();
            Property(x => x.MasterProjectRegioId).HasColumnName(@"MasterProjectRegioID").HasColumnType("bigint").IsOptional();
            Property(x => x.MasterProjectRegio).HasColumnName(@"MasterProjectRegio").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.ProjectMasterType).HasColumnName(@"ProjectMasterType").HasColumnType("int").IsOptional();
            Property(x => x.CheckInAtWorkYn).HasColumnName(@"CheckInAtWorkYn").HasColumnType("bit").IsOptional();
            Property(x => x.ExtNumber).HasColumnName(@"ExtNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Country).HasColumnName(@"Country").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.CountryCode).HasColumnName(@"CountryCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.TeamsUrl).HasColumnName(@"TeamsUrl").HasColumnType("nvarchar").IsOptional().HasMaxLength(1000);
        }
    }
}
