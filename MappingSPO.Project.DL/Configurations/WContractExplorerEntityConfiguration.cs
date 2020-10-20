using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WContractExplorerEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WContractExplorerEntity>
    {
        public WContractExplorerEntityConfiguration()
            : this("dbo")
        {
        }

        public WContractExplorerEntityConfiguration(string schema)
        {
            ToTable("vwContractExplorer", schema);
            HasKey(x => new { x.ContractId, x.ContractTypeId, x.Contractjaar, x.Contractnummer, x.ContractStatus, x.ContractNaam, x.Domain });

            Property(x => x.ContractId).HasColumnName(@"ContractID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ContractTypeId).HasColumnName(@"ContractTypeID").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Contractjaar).HasColumnName(@"Contractjaar").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Contractnummer).HasColumnName(@"Contractnummer").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ContractStatus).HasColumnName(@"ContractStatus").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FullContractNummer).HasColumnName(@"FullContractNummer").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.ContractNaam).HasColumnName(@"ContractNaam").HasColumnType("nvarchar").IsRequired().HasMaxLength(200).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Tkp).HasColumnName(@"TKP").HasColumnType("float").IsOptional();
            Property(x => x.Tvp).HasColumnName(@"TVP").HasColumnType("float").IsOptional();
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.CreatorId).HasColumnName(@"CreatorID").HasColumnType("int").IsOptional();
            Property(x => x.Creator).HasColumnName(@"Creator").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsOptional();
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetime").IsOptional();
            Property(x => x.KalenderStartDatum).HasColumnName(@"KalenderStartDatum").HasColumnType("date").IsOptional();
            Property(x => x.KalenderEinddatum).HasColumnName(@"KalenderEinddatum").HasColumnType("date").IsOptional();
            Property(x => x.KalenderContractDatum).HasColumnName(@"KalenderContractDatum").HasColumnType("date").IsOptional();
            Property(x => x.KalenderGoedkeurdatum).HasColumnName(@"KalenderGoedkeurdatum").HasColumnType("date").IsOptional();
            Property(x => x.KalenderUitvoeringsdatum).HasColumnName(@"KalenderUitvoeringsdatum").HasColumnType("date").IsOptional();
            Property(x => x.FirstAprovedVorderingDate).HasColumnName(@"FirstAprovedVorderingDate").HasColumnType("datetime").IsOptional();
            Property(x => x.LastAprovedVorderingDate).HasColumnName(@"LastAprovedVorderingDate").HasColumnType("datetime").IsOptional();
            Property(x => x.FirstVorderingDate).HasColumnName(@"FirstVorderingDate").HasColumnType("datetime").IsOptional();
            Property(x => x.LastVorderingDate).HasColumnName(@"LastVorderingDate").HasColumnType("datetime").IsOptional();
            Property(x => x.DefailtCompanyId).HasColumnName(@"DefailtCompanyID").HasColumnType("int").IsOptional();
            Property(x => x.DefaultCompany).HasColumnName(@"DefaultCompany").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.Ref1).HasColumnName(@"Ref1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref2).HasColumnName(@"Ref2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref3).HasColumnName(@"Ref3").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref4).HasColumnName(@"Ref4").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.WerfLeiderId).HasColumnName(@"WerfLeiderID").HasColumnType("int").IsOptional();
            Property(x => x.WerfLeider).HasColumnName(@"WerfLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.ProjectLeiderId).HasColumnName(@"ProjectLeiderID").HasColumnType("int").IsOptional();
            Property(x => x.ProjectLeider).HasColumnName(@"ProjectLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
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
            Property(x => x.VoorlopigeOpleveringsdatum).HasColumnName(@"VoorlopigeOpleveringsdatum").HasColumnType("date").IsOptional();
            Property(x => x.DefinitieveOpleveringsdatum).HasColumnName(@"DefinitieveOpleveringsdatum").HasColumnType("date").IsOptional();
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ParentWerfOpvolgingsnummer).HasColumnName(@"ParentWerfOpvolgingsnummer").HasColumnType("int").IsOptional();
            Property(x => x.ParentWerfName).HasColumnName(@"ParentWerfName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.ParentProjectNummer).HasColumnName(@"ParentProjectNummer").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ParentProjectName).HasColumnName(@"ParentProjectName").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.ParentWerfYear).HasColumnName(@"ParentWerfYear").HasColumnType("int").IsOptional();
            Property(x => x.ParentWerfTypeOmschrijving).HasColumnName(@"ParentWerfTypeOmschrijving").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.ParentWerfType).HasColumnName(@"ParentWerfType").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Code1Contract).HasColumnName(@"Code1Contract").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code2Contract).HasColumnName(@"Code2Contract").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code3Contract).HasColumnName(@"Code3Contract").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code4Contract).HasColumnName(@"Code4Contract").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code5Contract).HasColumnName(@"Code5Contract").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code6Contract).HasColumnName(@"Code6Contract").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code8Contract).HasColumnName(@"Code8Contract").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code7Contract).HasColumnName(@"Code7Contract").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.ParentWerfTypeId).HasColumnName(@"ParentWerfTypeID").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(x => x.ProjectYear).HasColumnName(@"ProjectYear").HasColumnType("int").IsOptional();
            Property(x => x.ProjectWerfNotes).HasColumnName(@"ProjectWerfNotes").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ProjectDone).HasColumnName(@"ProjectDone").HasColumnType("bit").IsOptional();
            Property(x => x.ProjectState).HasColumnName(@"ProjectState").HasColumnType("int").IsOptional();
            Property(x => x.ProjectResultReason).HasColumnName(@"ProjectResultReason").HasColumnType("int").IsOptional();
            Property(x => x.ProjectNumber).HasColumnName(@"ProjectNumber").HasColumnType("int").IsOptional();
            Property(x => x.OaNaam).HasColumnName(@"OANaam").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.OaPhone).HasColumnName(@"OAPhone").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.OaEmail).HasColumnName(@"OAEmail").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.OaGsm).HasColumnName(@"OAGsm").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.OaRelationId).HasColumnName(@"OARelationID").HasColumnType("bigint").IsOptional();
        }
    }
}
