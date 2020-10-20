using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WBestelBonExplorer2EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WBestelBonExplorer2Entity>
    {
        public WBestelBonExplorer2EntityConfiguration()
            : this("dbo")
        {
        }

        public WBestelBonExplorer2EntityConfiguration(string schema)
        {
            ToTable("vwBestelBonExplorer2", schema);
            HasKey(x => new { x.Sbid, x.Status, x.BestelbonType });

            Property(x => x.Sbid).HasColumnName(@"SBID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SbNrTxt).HasColumnName(@"SBNrTxt").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.SbNr).HasColumnName(@"SBNr").HasColumnType("bigint").IsOptional();
            Property(x => x.Jaar).HasColumnName(@"Jaar").HasColumnType("int").IsOptional();
            Property(x => x.Datum).HasColumnName(@"Datum").HasColumnType("datetime").IsOptional();
            Property(x => x.AskDeliveryDate).HasColumnName(@"AskDeliveryDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CreateDate).HasColumnName(@"CreateDate").HasColumnType("datetime").IsOptional();
            Property(x => x.OrderbevestigingsNr).HasColumnName(@"OrderbevestigingsNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.VermoedelijkeLeverdatum).HasColumnName(@"VermoedelijkeLeverdatum").HasColumnType("datetime").IsOptional();
            Property(x => x.Verantwoordelijke).HasColumnName(@"Verantwoordelijke").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.RefIntern).HasColumnName(@"RefIntern").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.RefExtrern).HasColumnName(@"RefExtrern").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.RelationId).HasColumnName(@"RelationID").HasColumnType("bigint").IsOptional();
            Property(x => x.SupplierType).HasColumnName(@"SupplierType").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.SuplierName).HasColumnName(@"SuplierName").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.SupplierContact).HasColumnName(@"SupplierContact").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.SuplierAdress1).HasColumnName(@"SuplierAdress1").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.SuplierAdress2).HasColumnName(@"SuplierAdress2").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.SuplierZipCode).HasColumnName(@"SuplierZipCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.SuplierCity).HasColumnName(@"SuplierCity").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.SuplierCountryCode).HasColumnName(@"SuplierCountryCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.SuplierCountry).HasColumnName(@"SuplierCountry").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ExternalLocked).HasColumnName(@"ExternalLocked").HasColumnType("bit").IsOptional();
            Property(x => x.BestelbonType).HasColumnName(@"BestelbonType").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TotalPrice).HasColumnName(@"TotalPrice").HasColumnType("decimal").IsOptional().HasPrecision(20,8);
            Property(x => x.Geleverd).HasColumnName(@"Geleverd").HasColumnType("float").IsOptional();
            Property(x => x.Kost).HasColumnName(@"Kost").HasColumnType("float").IsOptional();
            Property(x => x.Gefactureerd).HasColumnName(@"Gefactureerd").HasColumnType("decimal").IsOptional().HasPrecision(38,8);
            Property(x => x.LanguageCode).HasColumnName(@"LanguageCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.TotalNumberOfPrints).HasColumnName(@"TotalNumberOfPrints").HasColumnType("int").IsOptional();
            Property(x => x.LastPrintDate).HasColumnName(@"LastPrintDate").HasColumnType("datetime").IsOptional();
            Property(x => x.LastChangedDate).HasColumnName(@"LastChangedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.LastChangedBy).HasColumnName(@"LastChangedBy").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.WerfTypeId).HasColumnName(@"WerfTypeID").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(x => x.WerfYear).HasColumnName(@"WerfYear").HasColumnType("int").IsOptional();
            Property(x => x.WerfNumber).HasColumnName(@"WerfNumber").HasColumnType("int").IsOptional();
            Property(x => x.WerfName).HasColumnName(@"WerfName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.ProjectNrText).HasColumnName(@"ProjectNrText").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ProjectName).HasColumnName(@"ProjectName").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.MasterProjectNr).HasColumnName(@"MasterProjectNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.MasterProjectName).HasColumnName(@"MasterProjectName").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
        }
    }
}
