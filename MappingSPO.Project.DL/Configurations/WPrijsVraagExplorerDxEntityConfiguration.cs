using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WPrijsVraagExplorerDxEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WPrijsVraagExplorerDxEntity>
    {
        public WPrijsVraagExplorerDxEntityConfiguration()
            : this("dbo")
        {
        }

        public WPrijsVraagExplorerDxEntityConfiguration(string schema)
        {
            ToTable("vwPrijsVraagExplorerDX", schema);
            HasKey(x => new { x.PrijsAanvraagId, x.CalcTypeId, x.MarkedForDeletion, x.CalcSoort, x.Domain, x.UiVersion, x.CalcId });

            Property(x => x.PrijsAanvraagId).HasColumnName(@"PrijsAanvraagID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CalcTypeId).HasColumnName(@"CalcTypeID").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PrijsAanvraagType).HasColumnName(@"PrijsAanvraagType").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.PrijsAanvraagYear).HasColumnName(@"PrijsAanvraagYear").HasColumnType("int").IsOptional();
            Property(x => x.Number).HasColumnName(@"Number").HasColumnType("int").IsOptional();
            Property(x => x.PrijsAanvraagState).HasColumnName(@"PrijsAanvraagState").HasColumnType("int").IsOptional();
            Property(x => x.PrijsAanvraagNummer).HasColumnName(@"PrijsAanvraagNummer").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.PrijsAanvraagVersieNummer).HasColumnName(@"PrijsAanvraagVersieNummer").HasColumnType("nvarchar").IsOptional().HasMaxLength(70);
            Property(x => x.PrijsAanvraagName).HasColumnName(@"PrijsAanvraagName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.Total).HasColumnName(@"Total").HasColumnType("float").IsOptional();
            Property(x => x.TotalInclVat).HasColumnName(@"TotalInclVat").HasColumnType("float").IsOptional();
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
            Property(x => x.MarkedForDeletion).HasColumnName(@"MarkedForDeletion").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DeletionErrorRemark).HasColumnName(@"DeletionErrorRemark").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.WhoMarkedForDeletion).HasColumnName(@"WhoMarkedForDeletion").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.CalcSoort).HasColumnName(@"CalcSoort").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PathDocsFileSystem).HasColumnName(@"PathDocsFileSystem").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.BimModelName).HasColumnName(@"BimModelName").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.WerfState).HasColumnName(@"WerfState").HasColumnType("int").IsOptional();
            Property(x => x.FullWerfNumber).HasColumnName(@"FullWerfNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.WerfName).HasColumnName(@"WerfName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.WerfLeider).HasColumnName(@"WerfLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.ProjectLeider).HasColumnName(@"ProjectLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.CProjectId).HasColumnName(@"cProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.CProjectType).HasColumnName(@"cProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.CProjectNumber).HasColumnName(@"cProjectNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CProjectNaam).HasColumnName(@"cProjectNaam").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.CMasterProjectId).HasColumnName(@"cMasterProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.CMasterProjectType).HasColumnName(@"cMasterProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.CMasterProjectNumber).HasColumnName(@"cMasterProjectNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CMasterProjectName).HasColumnName(@"cMasterProjectName").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.WerfAdresName).HasColumnName(@"WerfAdresName").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.WerfAdres).HasColumnName(@"WerfAdres").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.UiVersion).HasColumnName(@"UIVersion").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.OfferteNummer).HasColumnName(@"OfferteNummer").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.OfferteNaam).HasColumnName(@"OfferteNaam").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.InkoopCats).HasColumnName(@"InkoopCats").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Suppliers).HasColumnName(@"Suppliers").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.WProjectId).HasColumnName(@"wProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.WProjectType).HasColumnName(@"wProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.WProjectNumber).HasColumnName(@"wProjectNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WProjectNaam).HasColumnName(@"wProjectNaam").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.WMasterProjectId).HasColumnName(@"wMasterProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.WMasterProjectType).HasColumnName(@"wMasterProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.WMasterProjectNumber).HasColumnName(@"wMasterProjectNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WMasterProjectName).HasColumnName(@"wMasterProjectName").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.Verantw1).HasColumnName(@"Verantw1").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.Verantw2).HasColumnName(@"Verantw2").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.Verantw3).HasColumnName(@"Verantw3").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.InkoopCatGroups).HasColumnName(@"InkoopCatGroups").HasColumnType("nvarchar(max)").IsOptional();
        }
    }
}
