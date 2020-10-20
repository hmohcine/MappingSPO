using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WCalculationExplorerDxEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WCalculationExplorerDxEntity>
    {
        public WCalculationExplorerDxEntityConfiguration()
            : this("dbo")
        {
        }

        public WCalculationExplorerDxEntityConfiguration(string schema)
        {
            ToTable("vwCalculationExplorerDX", schema);
            HasKey(x => x.CalcId);

            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CalcTypeId).HasColumnName(@"CalcTypeID").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(2);
            Property(x => x.CalcMayorTypeCode).HasColumnName(@"CalcMayorTypeCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1);
            Property(x => x.CalcType).HasColumnName(@"CalcType").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CalcYear).HasColumnName(@"CalcYear").HasColumnType("int").IsOptional();
            Property(x => x.CalcNumber).HasColumnName(@"CalcNumber").HasColumnType("int").IsOptional();
            Property(x => x.CalcStatus).HasColumnName(@"CalcStatus").HasColumnType("int").IsOptional();
            Property(x => x.FullCalcNumber).HasColumnName(@"FullCalcNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.VersionCalcNumber).HasColumnName(@"VersionCalcNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(70);
            Property(x => x.VersionOriginalCalcId).HasColumnName(@"VersionOriginalCalcID").HasColumnType("bigint").IsOptional();
            Property(x => x.VersionOriginalCalcTypeId).HasColumnName(@"VersionOriginalCalcTypeID").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(x => x.VersionOriginalCalcYear).HasColumnName(@"VersionOriginalCalcYear").HasColumnType("int").IsOptional();
            Property(x => x.VersieNr).HasColumnName(@"VersieNr").HasColumnType("int").IsOptional();
            Property(x => x.OriginalCalcNumber).HasColumnName(@"OriginalCalcNumber").HasColumnType("int").IsOptional();
            Property(x => x.VersieOpmerking).HasColumnName(@"VersieOpmerking").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.CalcName).HasColumnName(@"CalcName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.Tkp).HasColumnName(@"TKP").HasColumnType("float").IsOptional();
            Property(x => x.Tvp).HasColumnName(@"TVP").HasColumnType("float").IsOptional();
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
            Property(x => x.Calculator).HasColumnName(@"Calculator").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.CalculatorGsm).HasColumnName(@"CalculatorGSM").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.LoonEc).HasColumnName(@"LoonEC").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.LoonAantal).HasColumnName(@"LoonAantal").HasColumnType("float").IsOptional();
            Property(x => x.MarkedForDeletion).HasColumnName(@"MarkedForDeletion").HasColumnType("bit").IsRequired();
            Property(x => x.DeletionErrorRemark).HasColumnName(@"DeletionErrorRemark").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.WhoMarkedForDeletion).HasColumnName(@"WhoMarkedForDeletion").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.CalcSoort).HasColumnName(@"CalcSoort").HasColumnType("int").IsRequired();
            Property(x => x.PathDocsFileSystem).HasColumnName(@"PathDocsFileSystem").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.BimModelName).HasColumnName(@"BimModelName").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1);
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
            Property(x => x.KlantAdresName).HasColumnName(@"KlantAdresName").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.KlantAdres).HasColumnName(@"KlantAdres").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.WerfAdresName).HasColumnName(@"WerfAdresName").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.WerfAdres).HasColumnName(@"WerfAdres").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.UiVersion).HasColumnName(@"UIVersion").HasColumnType("int").IsRequired();
            Property(x => x.ProjectUnitId).HasColumnName(@"ProjectUnitID").HasColumnType("bigint").IsOptional();
            Property(x => x.ProjectUnitNumber).HasColumnName(@"ProjectUnitNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ProjectUnitDescription).HasColumnName(@"ProjectUnitDescription").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.ProjectUnitState).HasColumnName(@"ProjectUnitState").HasColumnType("int").IsOptional();
            Property(x => x.UpliftPct).HasColumnName(@"UpliftPct").HasColumnType("float").IsOptional();
            Property(x => x.MargePct).HasColumnName(@"MargePct").HasColumnType("float").IsOptional();
            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsOptional();
        }
    }
}
