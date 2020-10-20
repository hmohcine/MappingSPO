using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WSearchBestelBonDetailEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WSearchBestelBonDetailEntity>
    {
        public WSearchBestelBonDetailEntityConfiguration()
            : this("dbo")
        {
        }

        public WSearchBestelBonDetailEntityConfiguration(string schema)
        {
            ToTable("vwSearchBestelBonDetail", schema);
            HasKey(x => new { x.Sbid, x.Status, x.DetailId, x.LineOrder, x.LineType, x.GeleverdAantal, x.GeleverdBedrag, x.GeleverdAantalInOntwerp, x.GeleverdBedragInOntwerp, x.DefaultAddTypeText, x.DefaultAddType, x.AddedOnLevering });

            Property(x => x.Sbid).HasColumnName(@"SBID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SbNrTxt).HasColumnName(@"SBNrTxt").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.SbNr).HasColumnName(@"SBNr").HasColumnType("bigint").IsOptional();
            Property(x => x.Datum).HasColumnName(@"Datum").HasColumnType("datetime").IsOptional();
            Property(x => x.Jaar).HasColumnName(@"Jaar").HasColumnType("int").IsOptional();
            Property(x => x.AskDeliveryDate).HasColumnName(@"AskDeliveryDate").HasColumnType("datetime").IsOptional();
            Property(x => x.RelationId).HasColumnName(@"RelationID").HasColumnType("bigint").IsOptional();
            Property(x => x.RelationName).HasColumnName(@"RelationName").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.RelationAdressLine1).HasColumnName(@"RelationAdressLine1").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.RelationZipCode).HasColumnName(@"RelationZipCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.RelationCity).HasColumnName(@"RelationCity").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CreateDate).HasColumnName(@"CreateDate").HasColumnType("datetime").IsOptional();
            Property(x => x.UserAlias).HasColumnName(@"UserAlias").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.OrderbevestigingsNr).HasColumnName(@"OrderbevestigingsNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.VermoedelijkeLeverdatum).HasColumnName(@"VermoedelijkeLeverdatum").HasColumnType("datetime").IsOptional();
            Property(x => x.DetailId).HasColumnName(@"DetailID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.LineOrder).HasColumnName(@"LineOrder").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.LineType).HasColumnName(@"LineType").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Aantal).HasColumnName(@"Aantal").HasColumnType("float").IsOptional();
            Property(x => x.Prijs).HasColumnName(@"Prijs").HasColumnType("float").IsOptional();
            Property(x => x.Totaal).HasColumnName(@"Totaal").HasColumnType("float").IsOptional();
            Property(x => x.Uc).HasColumnName(@"UC").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.BestelCode).HasColumnName(@"BestelCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Ks).HasColumnName(@"KS").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.LeveradresId).HasColumnName(@"LeveradresID").HasColumnType("bigint").IsOptional();
            Property(x => x.MagazijnId).HasColumnName(@"MagazijnID").HasColumnType("bigint").IsOptional();
            Property(x => x.Code1).HasColumnName(@"Code1").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code2).HasColumnName(@"Code2").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code3).HasColumnName(@"Code3").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code4).HasColumnName(@"Code4").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code5).HasColumnName(@"Code5").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code6).HasColumnName(@"Code6").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code7).HasColumnName(@"Code7").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code8).HasColumnName(@"Code8").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.GeleverdAantal).HasColumnName(@"GeleverdAantal").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.GeleverdBedrag).HasColumnName(@"GeleverdBedrag").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.GeleverdAantalInOntwerp).HasColumnName(@"GeleverdAantalInOntwerp").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.GeleverdBedragInOntwerp).HasColumnName(@"GeleverdBedragInOntwerp").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Televeren).HasColumnName(@"Televeren").HasColumnType("float").IsOptional();
            Property(x => x.Magazijn).HasColumnName(@"Magazijn").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.LeverAdres).HasColumnName(@"LeverAdres").HasColumnType("nvarchar").IsOptional().HasMaxLength(223);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsOptional().HasMaxLength(2048);
            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.WerfName).HasColumnName(@"WerfName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.WerfNr).HasColumnName(@"WerfNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.Verantwoordelijke).HasColumnName(@"Verantwoordelijke").HasColumnType("nvarchar").IsOptional().HasMaxLength(205);
            Property(x => x.DefaultAddTypeText).HasColumnName(@"DefaultAddTypeText").HasColumnType("nvarchar").IsRequired().HasMaxLength(7).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DefaultAddType).HasColumnName(@"DefaultAddType").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CostAantal).HasColumnName(@"CostAantal").HasColumnType("float").IsOptional();
            Property(x => x.CostKp).HasColumnName(@"CostKP").HasColumnType("float").IsOptional();
            Property(x => x.AddedOnLevering).HasColumnName(@"AddedOnLevering").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.WerfTypeId).HasColumnName(@"WerfTypeID").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(x => x.WerfYear).HasColumnName(@"WerfYear").HasColumnType("int").IsOptional();
            Property(x => x.WerfNumber).HasColumnName(@"WerfNumber").HasColumnType("int").IsOptional();
            Property(x => x.RefIntern).HasColumnName(@"RefIntern").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.RefExtrern).HasColumnName(@"RefExtrern").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.Company).HasColumnName(@"Company").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.ProjectNrText).HasColumnName(@"ProjectNrText").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.ProjectName).HasColumnName(@"ProjectName").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(1);
        }
    }
}
