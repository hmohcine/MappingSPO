using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WPrijsAntwoordExplorerDxEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WPrijsAntwoordExplorerDxEntity>
    {
        public WPrijsAntwoordExplorerDxEntityConfiguration()
            : this("dbo")
        {
        }

        public WPrijsAntwoordExplorerDxEntityConfiguration(string schema)
        {
            ToTable("vwPrijsAntwoordExplorerDX", schema);
            HasKey(x => new { x.AntwoordId, x.AntwoordType, x.HasPrijsVraag, x.CalcTypeId, x.MarkedForDeletion, x.CalcSoort, x.UiVersion });

            Property(x => x.AntwoordId).HasColumnName(@"AntwoordID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AntwoordType).HasColumnName(@"AntwoordType").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.HasPrijsVraag).HasColumnName(@"HasPrijsVraag").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CalcTypeId).HasColumnName(@"CalcTypeID").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CalcType).HasColumnName(@"CalcType").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CalcYear).HasColumnName(@"CalcYear").HasColumnType("int").IsOptional();
            Property(x => x.CalcNumber).HasColumnName(@"CalcNumber").HasColumnType("int").IsOptional();
            Property(x => x.CalcStatus).HasColumnName(@"CalcStatus").HasColumnType("int").IsOptional();
            Property(x => x.FullCalcNumber).HasColumnName(@"FullCalcNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.VersionCalcNumber).HasColumnName(@"VersionCalcNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(70);
            Property(x => x.CalcName).HasColumnName(@"CalcName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.Tkp).HasColumnName(@"TKP").HasColumnType("float").IsOptional();
            Property(x => x.TvpIncl).HasColumnName(@"TVPIncl").HasColumnType("float").IsOptional();
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.LastSaveData).HasColumnName(@"LastSaveData").HasColumnType("datetime").IsOptional();
            Property(x => x.Creator).HasColumnName(@"Creator").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.LockedBy).HasColumnName(@"LockedBy").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Datum1).HasColumnName(@"Datum1").HasColumnType("datetime").IsOptional();
            Property(x => x.Datum2).HasColumnName(@"Datum2").HasColumnType("datetime").IsOptional();
            Property(x => x.OfferteDatum).HasColumnName(@"OfferteDatum").HasColumnType("datetime").IsOptional();
            Property(x => x.VervalDatum).HasColumnName(@"VervalDatum").HasColumnType("datetime").IsOptional();
            Property(x => x.IndienDatum).HasColumnName(@"IndienDatum").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtraDate1).HasColumnName(@"ExtraDate1").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtraDate2).HasColumnName(@"ExtraDate2").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtraDate3).HasColumnName(@"ExtraDate3").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtraDate4).HasColumnName(@"ExtraDate4").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtraDate5).HasColumnName(@"ExtraDate5").HasColumnType("datetime").IsOptional();
            Property(x => x.Company).HasColumnName(@"Company").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
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
            Property(x => x.ExtraNum1).HasColumnName(@"ExtraNum1").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum2).HasColumnName(@"ExtraNum2").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum3).HasColumnName(@"ExtraNum3").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum4).HasColumnName(@"ExtraNum4").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum5).HasColumnName(@"ExtraNum5").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum6).HasColumnName(@"ExtraNum6").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum7).HasColumnName(@"ExtraNum7").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum8).HasColumnName(@"ExtraNum8").HasColumnType("float").IsOptional();
            Property(x => x.MarkedForDeletion).HasColumnName(@"MarkedForDeletion").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DeletionErrorRemark).HasColumnName(@"DeletionErrorRemark").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.WhoMarkedForDeletion).HasColumnName(@"WhoMarkedForDeletion").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.CalcSoort).HasColumnName(@"CalcSoort").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PathDocsFileSystem).HasColumnName(@"PathDocsFileSystem").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.BimModelName).HasColumnName(@"BimModelName").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.UiVersion).HasColumnName(@"UIVersion").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SupplierRelationId).HasColumnName(@"SupplierRelationID").HasColumnType("bigint").IsOptional();
            Property(x => x.Supplier).HasColumnName(@"Supplier").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.SupplierAdres1).HasColumnName(@"SupplierAdres1").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.SupplierAdres2).HasColumnName(@"SupplierAdres2").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.SupplierZip).HasColumnName(@"SupplierZip").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.SupplierCity).HasColumnName(@"SupplierCity").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.SupplierCountryCode).HasColumnName(@"SupplierCountryCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.OpmerkingPrijsvraagSupplier).HasColumnName(@"OpmerkingPrijsvraagSupplier").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Verantw1).HasColumnName(@"Verantw1").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.Verantw2).HasColumnName(@"Verantw2").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.Verantw3).HasColumnName(@"Verantw3").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.InkoopCats).HasColumnName(@"InkoopCats").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.PrijsvraagNr).HasColumnName(@"PrijsvraagNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.PrijsVraagName).HasColumnName(@"PrijsVraagName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.BaseCalcId).HasColumnName(@"BaseCalcID").HasColumnType("bigint").IsOptional();
            Property(x => x.BaseCalcNumber).HasColumnName(@"BaseCalcNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.BaseCalcName).HasColumnName(@"BaseCalcName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.CProjectId).HasColumnName(@"cProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.CProjectType).HasColumnName(@"cProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.CProjectNumber).HasColumnName(@"cProjectNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CProjectNaam).HasColumnName(@"cProjectNaam").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.CMasterProjectId).HasColumnName(@"cMasterProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.CMasterProjectType).HasColumnName(@"cMasterProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.CMasterProjectNumber).HasColumnName(@"cMasterProjectNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CMasterProjectName).HasColumnName(@"cMasterProjectName").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.CWerfId).HasColumnName(@"cWerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.CFullWerfNumber).HasColumnName(@"cFullWerfNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.CWerfName).HasColumnName(@"cWerfName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.CWerfLeider).HasColumnName(@"cWerfLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.CProjectLeider).HasColumnName(@"cProjectLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.CWerfAdresName).HasColumnName(@"cWerfAdresName").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.CWerfAdres).HasColumnName(@"cWerfAdres").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ContractId).HasColumnName(@"ContractID").HasColumnType("bigint").IsOptional();
            Property(x => x.ContractNr).HasColumnName(@"ContractNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.ContractName).HasColumnName(@"ContractName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.WWerfId).HasColumnName(@"wWerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.WFullWerfNumber).HasColumnName(@"wFullWerfNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.WWerfName).HasColumnName(@"wWerfName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.WWerfLeider).HasColumnName(@"wWerfLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.WProjectLeider).HasColumnName(@"wProjectLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.WWerfAdresName).HasColumnName(@"wWerfAdresName").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.WWerfAdres).HasColumnName(@"wWerfAdres").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.WProjectId).HasColumnName(@"wProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.WProjectType).HasColumnName(@"wProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.WProjectNumber).HasColumnName(@"wProjectNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WProjectNaam).HasColumnName(@"wProjectNaam").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.WMasterProjectId).HasColumnName(@"wMasterProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.WMasterProjectType).HasColumnName(@"wMasterProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.WMasterProjectNumber).HasColumnName(@"wMasterProjectNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WMasterProjectName).HasColumnName(@"wMasterProjectName").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.InkoopCatGroups).HasColumnName(@"InkoopCatGroups").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ContractState).HasColumnName(@"ContractState").HasColumnType("int").IsOptional();
            Property(x => x.RelationTypeId).HasColumnName(@"RelationTypeID").HasColumnType("int").IsOptional();
            Property(x => x.PrijsVraagId).HasColumnName(@"PrijsVraagID").HasColumnType("bigint").IsOptional();
            Property(x => x.LanguageCode).HasColumnName(@"LanguageCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
        }
    }
}
