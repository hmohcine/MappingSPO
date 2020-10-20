using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WProjectUnitExplorerDxEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WProjectUnitExplorerDxEntity>
    {
        public WProjectUnitExplorerDxEntityConfiguration()
            : this("dbo")
        {
        }

        public WProjectUnitExplorerDxEntityConfiguration(string schema)
        {
            ToTable("vwProjectUnitExplorerDX", schema);
            HasKey(x => new { x.ProjectUnitId, x.UnitState, x.VolgNummer, x.CreateDate, x.ChangedDate, x.IntegrationYn, x.VerdeelMode, x.VolgNrYearText, x.Year, x.VolgNrYear });

            Property(x => x.ProjectUnitId).HasColumnName(@"ProjectUnitID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.ProjectNrText).HasColumnName(@"ProjectNrText").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ProjectName).HasColumnName(@"ProjectName").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.ProjectRegio).HasColumnName(@"ProjectRegio").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.MasterProjectId).HasColumnName(@"MasterProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.MasterProjectType).HasColumnName(@"MasterProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.MasterProjectNrText).HasColumnName(@"MasterProjectNrText").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.MasterProjectName).HasColumnName(@"MasterProjectName").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.MasterProjectRegion).HasColumnName(@"MasterProjectRegion").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.UnitState).HasColumnName(@"UnitState").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Unittype).HasColumnName(@"Unittype").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.Afkorting).HasColumnName(@"Afkorting").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.VolgNummer).HasColumnName(@"VolgNummer").HasColumnType("nvarchar").IsRequired().HasMaxLength(100).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code1).HasColumnName(@"Code1").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code2).HasColumnName(@"Code2").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code3).HasColumnName(@"Code3").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code4).HasColumnName(@"Code4").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code5).HasColumnName(@"Code5").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code6).HasColumnName(@"Code6").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code7).HasColumnName(@"Code7").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code8).HasColumnName(@"Code8").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.BrutoVloerOpp).HasColumnName(@"BrutoVloerOpp").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.NettoVloerOpp).HasColumnName(@"NettoVloerOpp").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.Quotiteit).HasColumnName(@"Quotiteit").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsOptional();
            Property(x => x.G1).HasColumnName(@"g1").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G2).HasColumnName(@"g2").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G3).HasColumnName(@"g3").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G4).HasColumnName(@"g4").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G5).HasColumnName(@"g5").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G6).HasColumnName(@"g6").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G7).HasColumnName(@"g7").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G8).HasColumnName(@"g8").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G9).HasColumnName(@"g9").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G10).HasColumnName(@"g10").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G11).HasColumnName(@"g11").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G12).HasColumnName(@"g12").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G13).HasColumnName(@"g13").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G14).HasColumnName(@"g14").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G15).HasColumnName(@"g15").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G16).HasColumnName(@"g16").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G17).HasColumnName(@"g17").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G18).HasColumnName(@"g18").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G19).HasColumnName(@"g19").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G20).HasColumnName(@"g20").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G21).HasColumnName(@"g21").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G22).HasColumnName(@"g22").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G23).HasColumnName(@"g23").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G24).HasColumnName(@"g24").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G25).HasColumnName(@"g25").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopOtherVPexcl).HasColumnName(@"VerkoopOtherVPexcl").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopOtherBtw).HasColumnName(@"VerkoopOtherBTW").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopTotalExcl).HasColumnName(@"VerkoopTotalExcl").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopTotalBtw).HasColumnName(@"VerkoopTotalBTW").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.CreateDate).HasColumnName(@"CreateDate").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.ChangedDate).HasColumnName(@"ChangedDate").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ChangedBy).HasColumnName(@"ChangedBy").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.IntegrationYn).HasColumnName(@"IntegrationYn").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.OptieDatum).HasColumnName(@"OptieDatum").HasColumnType("date").IsOptional();
            Property(x => x.OptieVervalDatum).HasColumnName(@"OptieVervalDatum").HasColumnType("date").IsOptional();
            Property(x => x.UDatum1).HasColumnName(@"uDatum1").HasColumnType("date").IsOptional();
            Property(x => x.UDatum2).HasColumnName(@"uDatum2").HasColumnType("date").IsOptional();
            Property(x => x.UDatum3).HasColumnName(@"uDatum3").HasColumnType("date").IsOptional();
            Property(x => x.UDatum4).HasColumnName(@"uDatum4").HasColumnType("date").IsOptional();
            Property(x => x.UDatum5).HasColumnName(@"uDatum5").HasColumnType("date").IsOptional();
            Property(x => x.UDatum6).HasColumnName(@"uDatum6").HasColumnType("date").IsOptional();
            Property(x => x.UDatum7).HasColumnName(@"uDatum7").HasColumnType("date").IsOptional();
            Property(x => x.UDatum8).HasColumnName(@"uDatum8").HasColumnType("date").IsOptional();
            Property(x => x.VerdeelMode).HasColumnName(@"VerdeelMode").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.VerdeelWaarde).HasColumnName(@"VerdeelWaarde").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VolgNrYearText).HasColumnName(@"VolgNrYearText").HasColumnType("nvarchar").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Year).HasColumnName(@"Year").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.VolgNrYear).HasColumnName(@"VolgNrYear").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SubCategory).HasColumnName(@"SubCategory").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Category).HasColumnName(@"Category").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.FullCalcNumber).HasColumnName(@"FullCalcNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.VersionCalcNumber).HasColumnName(@"VersionCalcNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(70);
            Property(x => x.CalcStatus).HasColumnName(@"CalcStatus").HasColumnType("int").IsOptional();
            Property(x => x.VersieOpmerking).HasColumnName(@"VersieOpmerking").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.CalcName).HasColumnName(@"CalcName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.Tkp).HasColumnName(@"TKP").HasColumnType("float").IsOptional();
            Property(x => x.Tvp).HasColumnName(@"TVP").HasColumnType("float").IsOptional();
            Property(x => x.TvpIncl).HasColumnName(@"TVPIncl").HasColumnType("float").IsOptional();
            Property(x => x.OfferteDatum).HasColumnName(@"OfferteDatum").HasColumnType("datetime").IsOptional();
            Property(x => x.VervalDatum).HasColumnName(@"VervalDatum").HasColumnType("datetime").IsOptional();
            Property(x => x.IndienDatum).HasColumnName(@"IndienDatum").HasColumnType("datetime").IsOptional();
            Property(x => x.Company).HasColumnName(@"Company").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.CalcSoort).HasColumnName(@"CalcSoort").HasColumnType("int").IsOptional();
            Property(x => x.FullWerfNumber).HasColumnName(@"FullWerfNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.WerfName).HasColumnName(@"WerfName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.WerfLeider).HasColumnName(@"WerfLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.ProjectLeider).HasColumnName(@"ProjectLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.WerfState).HasColumnName(@"WerfState").HasColumnType("int").IsOptional();
            Property(x => x.WerfStartDate).HasColumnName(@"WerfStartDate").HasColumnType("datetime").IsOptional();
            Property(x => x.WerfEndDate).HasColumnName(@"WerfEndDate").HasColumnType("datetime").IsOptional();
            Property(x => x.VoorlopigeOpleveringsdatum).HasColumnName(@"VoorlopigeOpleveringsdatum").HasColumnType("date").IsOptional();
            Property(x => x.DefinitieveOpleveringsdatum).HasColumnName(@"DefinitieveOpleveringsdatum").HasColumnType("date").IsOptional();
            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.PerceelOpp).HasColumnName(@"PerceelOpp").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.KlantAdresNaamWerf).HasColumnName(@"KlantAdresNaamWerf").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.KlantAdresWerf).HasColumnName(@"KlantAdresWerf").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.KlantAdresNaamCalc).HasColumnName(@"KlantAdresNaamCalc").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.KlantAdresCalc).HasColumnName(@"KlantAdresCalc").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ExtraBoolean1).HasColumnName(@"ExtraBoolean1").HasColumnType("bit").IsOptional();
            Property(x => x.ExtraBoolean2).HasColumnName(@"ExtraBoolean2").HasColumnType("bit").IsOptional();
            Property(x => x.ExtraBoolean3).HasColumnName(@"ExtraBoolean3").HasColumnType("bit").IsOptional();
            Property(x => x.ExtraBoolean4).HasColumnName(@"ExtraBoolean4").HasColumnType("bit").IsOptional();
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
            Property(x => x.MultiSelect1).HasColumnName(@"MultiSelect1").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.MultiSelect2).HasColumnName(@"MultiSelect2").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.MultiSelect3).HasColumnName(@"MultiSelect3").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.MultiSelect4).HasColumnName(@"MultiSelect4").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.MultiSelect5).HasColumnName(@"MultiSelect5").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.MultiSelect6).HasColumnName(@"MultiSelect6").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.MultiSelect7).HasColumnName(@"MultiSelect7").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.MultiSelect8).HasColumnName(@"MultiSelect8").HasColumnType("nvarchar(max)").IsOptional();
        }
    }
}
