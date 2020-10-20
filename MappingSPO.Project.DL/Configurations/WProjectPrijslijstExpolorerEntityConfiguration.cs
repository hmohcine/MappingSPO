using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WProjectPrijslijstExpolorerEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WProjectPrijslijstExpolorerEntity>
    {
        public WProjectPrijslijstExpolorerEntityConfiguration()
            : this("dbo")
        {
        }

        public WProjectPrijslijstExpolorerEntityConfiguration(string schema)
        {
            ToTable("vwProjectPrijslijstExpolorer", schema);
            HasKey(x => new { x.ProjectUnitId, x.ProjectMasterType, x.ProjectId, x.ProjectType, x.ProjectNrText, x.ProjectName, x.UnitState, x.UnittypeId, x.VolgNummer, x.CreateDate, x.ChangedDate, x.CreatedById, x.ChangedById, x.IntegrationYn, x.ProjectYear, x.ProjectNumber, x.VerdeelMode, x.VolgNrYearText });

            Property(x => x.ProjectUnitId).HasColumnName(@"ProjectUnitID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectMasterType).HasColumnName(@"ProjectMasterType").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsRequired().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectNrText).HasColumnName(@"ProjectNrText").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectName).HasColumnName(@"ProjectName").HasColumnType("nvarchar").IsRequired().HasMaxLength(250).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.MasterProjectNr).HasColumnName(@"MasterProjectNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.MasterProjectName).HasColumnName(@"MasterProjectName").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.MasterPid).HasColumnName(@"MasterPID").HasColumnType("bigint").IsOptional();
            Property(x => x.MasterPType).HasColumnName(@"MasterPType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.UnitState).HasColumnName(@"UnitState").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UnittypeId).HasColumnName(@"UnittypeID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Unittype).HasColumnName(@"Unittype").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.Afkorting).HasColumnName(@"Afkorting").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.NrPart1).HasColumnName(@"NrPart1").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.NrPart2).HasColumnName(@"NrPart2").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.NrPart3).HasColumnName(@"NrPart3").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.Nummer).HasColumnName(@"Nummer").HasColumnType("int").IsOptional();
            Property(x => x.NrFormat).HasColumnName(@"NrFormat").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
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
            Property(x => x.DefaultFormat).HasColumnName(@"DefaultFormat").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.CodeId1).HasColumnName(@"CodeID1").HasColumnType("bigint").IsOptional();
            Property(x => x.CodeId2).HasColumnName(@"CodeID2").HasColumnType("bigint").IsOptional();
            Property(x => x.CodeId3).HasColumnName(@"CodeID3").HasColumnType("bigint").IsOptional();
            Property(x => x.CodeId4).HasColumnName(@"CodeID4").HasColumnType("bigint").IsOptional();
            Property(x => x.CodeId5).HasColumnName(@"CodeID5").HasColumnType("bigint").IsOptional();
            Property(x => x.CodeId6).HasColumnName(@"CodeID6").HasColumnType("bigint").IsOptional();
            Property(x => x.CodeId7).HasColumnName(@"CodeID7").HasColumnType("bigint").IsOptional();
            Property(x => x.CodeId8).HasColumnName(@"CodeID8").HasColumnType("bigint").IsOptional();
            Property(x => x.OfferId).HasColumnName(@"OfferID").HasColumnType("bigint").IsOptional();
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
            Property(x => x.VerkoopOtherVPexcl).HasColumnName(@"VerkoopOtherVPexcl").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopOtherBtw).HasColumnName(@"VerkoopOtherBTW").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopTotalExcl).HasColumnName(@"VerkoopTotalExcl").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopTotalBtw).HasColumnName(@"VerkoopTotalBTW").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G17).HasColumnName(@"g17").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G18).HasColumnName(@"g18").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G19).HasColumnName(@"g19").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G20).HasColumnName(@"g20").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G21).HasColumnName(@"g21").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G22).HasColumnName(@"g22").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G23).HasColumnName(@"g23").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G24).HasColumnName(@"g24").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.G25).HasColumnName(@"g25").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.CreateDate).HasColumnName(@"CreateDate").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ChangedDate).HasColumnName(@"ChangedDate").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CreatedById).HasColumnName(@"CreatedByID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ChangedById).HasColumnName(@"ChangedByID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.ChangedBy).HasColumnName(@"ChangedBy").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.FullCalcNumber).HasColumnName(@"FullCalcNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.VersionCalcNumber).HasColumnName(@"VersionCalcNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(70);
            Property(x => x.CalcStatus).HasColumnName(@"CalcStatus").HasColumnType("int").IsOptional();
            Property(x => x.VersieOpmerking).HasColumnName(@"VersieOpmerking").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.CalcName).HasColumnName(@"CalcName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.Tkp).HasColumnName(@"TKP").HasColumnType("float").IsOptional();
            Property(x => x.Tvp).HasColumnName(@"TVP").HasColumnType("float").IsOptional();
            Property(x => x.OfferteDatum).HasColumnName(@"OfferteDatum").HasColumnType("datetime").IsOptional();
            Property(x => x.VervalDatum).HasColumnName(@"VervalDatum").HasColumnType("datetime").IsOptional();
            Property(x => x.IndienDatum).HasColumnName(@"IndienDatum").HasColumnType("datetime").IsOptional();
            Property(x => x.Company).HasColumnName(@"Company").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.CalcSoort).HasColumnName(@"CalcSoort").HasColumnType("int").IsOptional();
            Property(x => x.FullWerfNumber).HasColumnName(@"FullWerfNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.WerfName).HasColumnName(@"WerfName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsOptional();
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetime").IsOptional();
            Property(x => x.WerfLeider).HasColumnName(@"WerfLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.ProjectLeider).HasColumnName(@"ProjectLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.WerfState).HasColumnName(@"WerfState").HasColumnType("int").IsOptional();
            Property(x => x.IntegrationYn).HasColumnName(@"IntegrationYn").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectYear).HasColumnName(@"ProjectYear").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectNumber).HasColumnName(@"ProjectNumber").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.WerfTypeId).HasColumnName(@"WerfTypeID").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(x => x.WerfYear).HasColumnName(@"WerfYear").HasColumnType("int").IsOptional();
            Property(x => x.WerfNumber).HasColumnName(@"WerfNumber").HasColumnType("int").IsOptional();
            Property(x => x.Clients).HasColumnName(@"Clients").HasColumnType("nvarchar(max)").IsOptional();
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
            Property(x => x.RegioId).HasColumnName(@"RegioID").HasColumnType("bigint").IsOptional();
            Property(x => x.Regio).HasColumnName(@"Regio").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.MasterProjectRegioId).HasColumnName(@"MasterProjectRegioID").HasColumnType("bigint").IsOptional();
            Property(x => x.MasterProjectRegio).HasColumnName(@"MasterProjectRegio").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.VoorlopigeOpleveringsdatum).HasColumnName(@"VoorlopigeOpleveringsdatum").HasColumnType("date").IsOptional();
            Property(x => x.DefinitieveOpleveringsdatum).HasColumnName(@"DefinitieveOpleveringsdatum").HasColumnType("date").IsOptional();
            Property(x => x.SubCategory).HasColumnName(@"SubCategory").HasColumnType("nvarchar").IsOptional().HasMaxLength(203);
            Property(x => x.SubCategoryId).HasColumnName(@"SubCategoryId").HasColumnType("int").IsOptional();
            Property(x => x.VolgNrYearText).HasColumnName(@"VolgNrYearText").HasColumnType("nvarchar").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PerceelOpp).HasColumnName(@"PerceelOpp").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
        }
    }
}
