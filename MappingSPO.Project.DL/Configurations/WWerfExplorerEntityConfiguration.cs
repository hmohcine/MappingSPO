using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WWerfExplorerEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WWerfExplorerEntity>
    {
        public WWerfExplorerEntityConfiguration()
            : this("dbo")
        {
        }

        public WWerfExplorerEntityConfiguration(string schema)
        {
            ToTable("vwWerfExplorer", schema);
            HasKey(x => new { x.WerfId, x.WerfTypeId, x.WerfMayorTypeCode, x.WerfYear, x.WerfNumber, x.WerfState, x.WerfName, x.CountOfExtInvoiceTodo, x.Domain });

            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.WerfTypeId).HasColumnName(@"WerfTypeID").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.WerfMayorTypeCode).HasColumnName(@"WerfMayorTypeCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.WerfType).HasColumnName(@"WerfType").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WerfYear).HasColumnName(@"WerfYear").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.WerfNumber).HasColumnName(@"WerfNumber").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.WerfState).HasColumnName(@"WerfState").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FullWerfNumber).HasColumnName(@"FullWerfNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.WerfName).HasColumnName(@"WerfName").HasColumnType("nvarchar").IsRequired().HasMaxLength(200).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Tkp).HasColumnName(@"TKP").HasColumnType("float").IsOptional();
            Property(x => x.Tvp).HasColumnName(@"TVP").HasColumnType("float").IsOptional();
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.CreatorId).HasColumnName(@"CreatorID").HasColumnType("int").IsOptional();
            Property(x => x.Creator).HasColumnName(@"Creator").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsOptional();
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetime").IsOptional();
            Property(x => x.CalStartDate).HasColumnName(@"CalStartDate").HasColumnType("date").IsOptional();
            Property(x => x.CalEndDate).HasColumnName(@"CalEndDate").HasColumnType("date").IsOptional();
            Property(x => x.CalContractDate).HasColumnName(@"CalContractDate").HasColumnType("date").IsOptional();
            Property(x => x.CalApprovedDate).HasColumnName(@"CalApprovedDate").HasColumnType("date").IsOptional();
            Property(x => x.CalStartCommandDate).HasColumnName(@"CalStartCommandDate").HasColumnType("date").IsOptional();
            Property(x => x.FirstAprovedVorderingDate).HasColumnName(@"FirstAprovedVorderingDate").HasColumnType("datetime").IsOptional();
            Property(x => x.LastAprovedVorderingDate).HasColumnName(@"LastAprovedVorderingDate").HasColumnType("datetime").IsOptional();
            Property(x => x.FirstVorderingDate).HasColumnName(@"FirstVorderingDate").HasColumnType("datetime").IsOptional();
            Property(x => x.LastVorderingDate).HasColumnName(@"LastVorderingDate").HasColumnType("datetime").IsOptional();
            Property(x => x.InvoiceState0Amount).HasColumnName(@"InvoiceState0Amount").HasColumnType("decimal").IsOptional().HasPrecision(38,8);
            Property(x => x.InvoiceState1Amount).HasColumnName(@"InvoiceState1Amount").HasColumnType("decimal").IsOptional().HasPrecision(38,8);
            Property(x => x.InvoiceState2Amount).HasColumnName(@"InvoiceState2Amount").HasColumnType("decimal").IsOptional().HasPrecision(38,8);
            Property(x => x.InvoiceState3Amount).HasColumnName(@"InvoiceState3Amount").HasColumnType("decimal").IsOptional().HasPrecision(38,8);
            Property(x => x.InvoiceStateAfAmount).HasColumnName(@"InvoiceStateAFAmount").HasColumnType("decimal").IsOptional().HasPrecision(38,8);
            Property(x => x.DefailtCompanyId).HasColumnName(@"DefailtCompanyID").HasColumnType("int").IsOptional();
            Property(x => x.DefaultCompany).HasColumnName(@"DefaultCompany").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.Code1Id).HasColumnName(@"Code1ID").HasColumnType("int").IsOptional();
            Property(x => x.Code1).HasColumnName(@"Code1").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code2Id).HasColumnName(@"Code2ID").HasColumnType("int").IsOptional();
            Property(x => x.Code2).HasColumnName(@"Code2").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code3Id).HasColumnName(@"Code3ID").HasColumnType("int").IsOptional();
            Property(x => x.Code3).HasColumnName(@"Code3").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code4Id).HasColumnName(@"Code4ID").HasColumnType("int").IsOptional();
            Property(x => x.Code4).HasColumnName(@"Code4").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code5Id).HasColumnName(@"Code5ID").HasColumnType("int").IsOptional();
            Property(x => x.Code5).HasColumnName(@"Code5").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code6Id).HasColumnName(@"Code6ID").HasColumnType("int").IsOptional();
            Property(x => x.Code6).HasColumnName(@"Code6").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code7Id).HasColumnName(@"Code7ID").HasColumnType("int").IsOptional();
            Property(x => x.Code7).HasColumnName(@"Code7").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code8Id).HasColumnName(@"Code8ID").HasColumnType("int").IsOptional();
            Property(x => x.Code8).HasColumnName(@"Code8").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Ref1).HasColumnName(@"Ref1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref2).HasColumnName(@"Ref2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref3).HasColumnName(@"Ref3").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref4).HasColumnName(@"Ref4").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.WerfLeiderId).HasColumnName(@"WerfLeiderID").HasColumnType("int").IsOptional();
            Property(x => x.WerfLeider).HasColumnName(@"WerfLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.ProjectLeiderId).HasColumnName(@"ProjectLeiderID").HasColumnType("int").IsOptional();
            Property(x => x.ProjectLeider).HasColumnName(@"ProjectLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.ProjectYear).HasColumnName(@"ProjectYear").HasColumnType("int").IsOptional();
            Property(x => x.ProjectNumber).HasColumnName(@"ProjectNumber").HasColumnType("int").IsOptional();
            Property(x => x.ProjectNrText).HasColumnName(@"ProjectNrText").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ProjectName).HasColumnName(@"ProjectName").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.ProjectState).HasColumnName(@"ProjectState").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.ProjectStateIcon).HasColumnName(@"ProjectStateIcon").HasColumnType("image").IsOptional().HasMaxLength(2147483647);
            Property(x => x.ProjectDone).HasColumnName(@"ProjectDone").HasColumnType("bit").IsOptional();
            Property(x => x.ProjectResultReason).HasColumnName(@"ProjectResultReason").HasColumnType("int").IsOptional();
            Property(x => x.ProjectWerfNotes).HasColumnName(@"ProjectWerfNotes").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ExtNumber).HasColumnName(@"ExtNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.CheckInAtWorkYn).HasColumnName(@"CheckInAtWorkYn").HasColumnType("bit").IsOptional();
            Property(x => x.ExtraNum1).HasColumnName(@"ExtraNum1").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum2).HasColumnName(@"ExtraNum2").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum3).HasColumnName(@"ExtraNum3").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum4).HasColumnName(@"ExtraNum4").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum5).HasColumnName(@"ExtraNum5").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum6).HasColumnName(@"ExtraNum6").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum7).HasColumnName(@"ExtraNum7").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum8).HasColumnName(@"ExtraNum8").HasColumnType("float").IsOptional();
            Property(x => x.ExtraDate1).HasColumnName(@"ExtraDate1").HasColumnType("date").IsOptional();
            Property(x => x.ExtraDate2).HasColumnName(@"ExtraDate2").HasColumnType("date").IsOptional();
            Property(x => x.ExtraDate3).HasColumnName(@"ExtraDate3").HasColumnType("date").IsOptional();
            Property(x => x.ExtraDate4).HasColumnName(@"ExtraDate4").HasColumnType("date").IsOptional();
            Property(x => x.ExtraDate5).HasColumnName(@"ExtraDate5").HasColumnType("date").IsOptional();
            Property(x => x.ExtraDate6).HasColumnName(@"ExtraDate6").HasColumnType("date").IsOptional();
            Property(x => x.ExtraDate7).HasColumnName(@"ExtraDate7").HasColumnType("date").IsOptional();
            Property(x => x.ExtraDate8).HasColumnName(@"ExtraDate8").HasColumnType("date").IsOptional();
            Property(x => x.CountOfExtInvoiceTodo).HasColumnName(@"CountOfExtInvoiceTodo").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.VoorlopigeOpleveringsdatum).HasColumnName(@"VoorlopigeOpleveringsdatum").HasColumnType("date").IsOptional();
            Property(x => x.DefinitieveOpleveringsdatum).HasColumnName(@"DefinitieveOpleveringsdatum").HasColumnType("date").IsOptional();
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FirstInvoiceAdressRelationId).HasColumnName(@"FirstInvoiceAdressRelationID").HasColumnType("bigint").IsOptional();
            Property(x => x.WerfAdresCountryCode).HasColumnName(@"WerfAdresCountryCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.WerfAdresCountry).HasColumnName(@"WerfAdresCountry").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
        }
    }
}
