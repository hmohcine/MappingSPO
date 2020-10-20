using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WCalculationExplorer2EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WCalculationExplorer2Entity>
    {
        public WCalculationExplorer2EntityConfiguration()
            : this("dbo")
        {
        }

        public WCalculationExplorer2EntityConfiguration(string schema)
        {
            ToTable("vwCalculationExplorer2", schema);
            HasKey(x => new { x.CalcId, x.CalcTypeId, x.CalcMayorTypeCode, x.MarkedForDeletion, x.CalcSoort, x.Domain, x.UiVersion });

            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CalcTypeId).HasColumnName(@"CalcTypeID").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CalcMayorTypeCode).HasColumnName(@"CalcMayorTypeCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
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
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.LastSaveData).HasColumnName(@"LastSaveData").HasColumnType("datetime").IsOptional();
            Property(x => x.CreatorId).HasColumnName(@"CreatorID").HasColumnType("int").IsOptional();
            Property(x => x.Creator).HasColumnName(@"Creator").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.LockedById).HasColumnName(@"LockedByID").HasColumnType("int").IsOptional();
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
            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsOptional();
            Property(x => x.Company).HasColumnName(@"Company").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.Code1Id).HasColumnName(@"Code1ID").HasColumnType("int").IsOptional();
            Property(x => x.Code2Id).HasColumnName(@"Code2ID").HasColumnType("int").IsOptional();
            Property(x => x.Code3Id).HasColumnName(@"Code3ID").HasColumnType("int").IsOptional();
            Property(x => x.Code4Id).HasColumnName(@"Code4ID").HasColumnType("int").IsOptional();
            Property(x => x.Code5Id).HasColumnName(@"Code5ID").HasColumnType("int").IsOptional();
            Property(x => x.Code6Id).HasColumnName(@"Code6ID").HasColumnType("int").IsOptional();
            Property(x => x.Code7Id).HasColumnName(@"Code7ID").HasColumnType("int").IsOptional();
            Property(x => x.Code8Id).HasColumnName(@"Code8ID").HasColumnType("int").IsOptional();
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
            Property(x => x.CalculatorId).HasColumnName(@"CalculatorID").HasColumnType("int").IsOptional();
            Property(x => x.Calculator).HasColumnName(@"Calculator").HasColumnType("nvarchar").IsOptional().HasMaxLength(205);
            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.WerfTypeId).HasColumnName(@"WerfTypeID").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(x => x.WerfYear).HasColumnName(@"WerfYear").HasColumnType("int").IsOptional();
            Property(x => x.WerfNr).HasColumnName(@"WerfNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.WerfName).HasColumnName(@"WerfName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.ProjectNrText).HasColumnName(@"ProjectNrText").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ProjectName).HasColumnName(@"ProjectName").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.WerfNumber).HasColumnName(@"WerfNumber").HasColumnType("int").IsOptional();
            Property(x => x.ProjectYear).HasColumnName(@"ProjectYear").HasColumnType("int").IsOptional();
            Property(x => x.ProjectNumber).HasColumnName(@"ProjectNumber").HasColumnType("int").IsOptional();
            Property(x => x.LoonEc).HasColumnName(@"LoonEC").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.LoonAantal).HasColumnName(@"LoonAantal").HasColumnType("float").IsOptional();
            Property(x => x.MarkedForDeletion).HasColumnName(@"MarkedForDeletion").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DeletionErrorRemark).HasColumnName(@"DeletionErrorRemark").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.WhoMarkedForDeletion).HasColumnName(@"WhoMarkedForDeletion").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.CalcSoort).HasColumnName(@"CalcSoort").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectUnit).HasColumnName(@"ProjectUnit").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.UnitState).HasColumnName(@"UnitState").HasColumnType("int").IsOptional();
            Property(x => x.VolgNrYearText).HasColumnName(@"VolgNrYearText").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.Verantwoordelijke1).HasColumnName(@"Verantwoordelijke1").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.Verantwoordelijke2).HasColumnName(@"Verantwoordelijke2").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.Verantwoordelijke3).HasColumnName(@"Verantwoordelijke3").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.Verantwoordelijke1Id).HasColumnName(@"Verantwoordelijke1ID").HasColumnType("int").IsOptional();
            Property(x => x.Verantwoordelijke2Id).HasColumnName(@"Verantwoordelijke2ID").HasColumnType("int").IsOptional();
            Property(x => x.Verantwoordelijke3Id).HasColumnName(@"Verantwoordelijke3ID").HasColumnType("int").IsOptional();
            Property(x => x.ExtraNum1).HasColumnName(@"ExtraNum1").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum2).HasColumnName(@"ExtraNum2").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum3).HasColumnName(@"ExtraNum3").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum4).HasColumnName(@"ExtraNum4").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum5).HasColumnName(@"ExtraNum5").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum6).HasColumnName(@"ExtraNum6").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum7).HasColumnName(@"ExtraNum7").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum8).HasColumnName(@"ExtraNum8").HasColumnType("float").IsOptional();
            Property(x => x.BaseCalcId).HasColumnName(@"BaseCalcID").HasColumnType("bigint").IsOptional();
            Property(x => x.OnderaannemerRelationId).HasColumnName(@"OnderaannemerRelationID").HasColumnType("bigint").IsOptional();
            Property(x => x.OnderaannemerName).HasColumnName(@"OnderaannemerName").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.OnderaannemerEmail1).HasColumnName(@"OnderaannemerEmail1").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.OnderaannemerPhone1).HasColumnName(@"OnderaannemerPhone1").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.OnderaannemerGsm).HasColumnName(@"OnderaannemerGSM").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.InkoopCategory).HasColumnName(@"InkoopCategory").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.InkoopCategoryGroup).HasColumnName(@"InkoopCategoryGroup").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.UiVersion).HasColumnName(@"UIVersion").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }
}
