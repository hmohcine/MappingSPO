using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class ProjectUnitEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProjectUnitEntity>
    {
        public ProjectUnitEntityConfiguration()
            : this("Project")
        {
        }

        public ProjectUnitEntityConfiguration(string schema)
        {
            ToTable("tProjectUnits", schema);
            HasKey(x => x.ProjectUnitId);

            Property(x => x.ProjectUnitId).HasColumnName(@"ProjectUnitID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsRequired();
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsRequired().HasMaxLength(2);
            Property(x => x.UnitState).HasColumnName(@"UnitState").HasColumnType("int").IsRequired();
            Property(x => x.UnittypeId).HasColumnName(@"UnittypeID").HasColumnType("bigint").IsRequired();
            Property(x => x.NrPart1).HasColumnName(@"NrPart1").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.NrPart2).HasColumnName(@"NrPart2").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.NrPart3).HasColumnName(@"NrPart3").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.Nummer).HasColumnName(@"Nummer").HasColumnType("int").IsOptional();
            Property(x => x.NrFormat).HasColumnName(@"NrFormat").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.VolgNummer).HasColumnName(@"VolgNummer").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.CodeId1).HasColumnName(@"CodeID1").HasColumnType("bigint").IsOptional();
            Property(x => x.CodeId2).HasColumnName(@"CodeID2").HasColumnType("bigint").IsOptional();
            Property(x => x.CodeId3).HasColumnName(@"CodeID3").HasColumnType("bigint").IsOptional();
            Property(x => x.CodeId4).HasColumnName(@"CodeID4").HasColumnType("bigint").IsOptional();
            Property(x => x.CodeId5).HasColumnName(@"CodeID5").HasColumnType("bigint").IsOptional();
            Property(x => x.CodeId6).HasColumnName(@"CodeID6").HasColumnType("bigint").IsOptional();
            Property(x => x.CodeId7).HasColumnName(@"CodeID7").HasColumnType("bigint").IsOptional();
            Property(x => x.CodeId8).HasColumnName(@"CodeID8").HasColumnType("bigint").IsOptional();
            Property(x => x.BrutoVloerOpp).HasColumnName(@"BrutoVloerOpp").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.NettoVloerOpp).HasColumnName(@"NettoVloerOpp").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.Quotiteit).HasColumnName(@"Quotiteit").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField1).HasColumnName(@"VerkoopField1").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField2).HasColumnName(@"VerkoopField2").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField3).HasColumnName(@"VerkoopField3").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField4).HasColumnName(@"VerkoopField4").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField5).HasColumnName(@"VerkoopField5").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField6).HasColumnName(@"VerkoopField6").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField7).HasColumnName(@"VerkoopField7").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField8).HasColumnName(@"VerkoopField8").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField9).HasColumnName(@"VerkoopField9").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField10).HasColumnName(@"VerkoopField10").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField11).HasColumnName(@"VerkoopField11").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField12).HasColumnName(@"VerkoopField12").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField13).HasColumnName(@"VerkoopField13").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField14).HasColumnName(@"VerkoopField14").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField15).HasColumnName(@"VerkoopField15").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField16).HasColumnName(@"VerkoopField16").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField17).HasColumnName(@"VerkoopField17").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField18).HasColumnName(@"VerkoopField18").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField19).HasColumnName(@"VerkoopField19").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField20).HasColumnName(@"VerkoopField20").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField21).HasColumnName(@"VerkoopField21").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField22).HasColumnName(@"VerkoopField22").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField23).HasColumnName(@"VerkoopField23").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField24).HasColumnName(@"VerkoopField24").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopField25).HasColumnName(@"VerkoopField25").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopOtherVPexcl).HasColumnName(@"VerkoopOtherVPexcl").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopOtherBtw).HasColumnName(@"VerkoopOtherBTW").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopTotalExcl).HasColumnName(@"VerkoopTotalExcl").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerkoopTotalBtw).HasColumnName(@"VerkoopTotalBTW").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.CreateDate).HasColumnName(@"CreateDate").HasColumnType("datetime").IsRequired();
            Property(x => x.ChangedDate).HasColumnName(@"ChangedDate").HasColumnType("datetime").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("int").IsRequired();
            Property(x => x.ChangedBy).HasColumnName(@"ChangedBy").HasColumnType("int").IsRequired();
            Property(x => x.IntegrationYn).HasColumnName(@"IntegrationYn").HasColumnType("bit").IsRequired();
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
            Property(x => x.VerdeelMode).HasColumnName(@"VerdeelMode").HasColumnType("int").IsRequired();
            Property(x => x.SubCategoryId).HasColumnName(@"SubCategoryId").HasColumnType("int").IsOptional();
            Property(x => x.Year).HasColumnName(@"Year").HasColumnType("int").IsRequired();
            Property(x => x.VolgNrYear).HasColumnName(@"VolgNrYear").HasColumnType("int").IsRequired();
            Property(x => x.VolgNrYearText).HasColumnName(@"VolgNrYearText").HasColumnType("nvarchar").IsRequired().HasMaxLength(20);
            Property(x => x.PerceelOpp).HasColumnName(@"PerceelOpp").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.VerdeelWaarde).HasColumnName(@"VerdeelWaarde").HasColumnType("decimal").IsOptional().HasPrecision(20,8).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Ref1).HasColumnName(@"Ref1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref2).HasColumnName(@"Ref2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref3).HasColumnName(@"Ref3").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref4).HasColumnName(@"Ref4").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ExtraBoolean1).HasColumnName(@"ExtraBoolean1").HasColumnType("bit").IsOptional();
            Property(x => x.ExtraBoolean2).HasColumnName(@"ExtraBoolean2").HasColumnType("bit").IsOptional();
            Property(x => x.ExtraBoolean3).HasColumnName(@"ExtraBoolean3").HasColumnType("bit").IsOptional();
            Property(x => x.ExtraBoolean4).HasColumnName(@"ExtraBoolean4").HasColumnType("bit").IsOptional();
            Property(x => x.ExtraNum1).HasColumnName(@"ExtraNum1").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum2).HasColumnName(@"ExtraNum2").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum3).HasColumnName(@"ExtraNum3").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum4).HasColumnName(@"ExtraNum4").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum5).HasColumnName(@"ExtraNum5").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum6).HasColumnName(@"ExtraNum6").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum7).HasColumnName(@"ExtraNum7").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum8).HasColumnName(@"ExtraNum8").HasColumnType("float").IsOptional();
        }
    }
}
