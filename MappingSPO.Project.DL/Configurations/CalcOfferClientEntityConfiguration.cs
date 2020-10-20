using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcOfferClientEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcOfferClientEntity>
    {
        public CalcOfferClientEntityConfiguration()
            : this("Project")
        {
        }

        public CalcOfferClientEntityConfiguration(string schema)
        {
            ToTable("tCalcOfferClient", schema);
            HasKey(x => new { x.CalcId, x.RelationTypeId, x.RelationId });

            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RelationTypeId).HasColumnName(@"RelationTypeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RelationId).HasColumnName(@"RelationID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Title).HasColumnName(@"Title").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.AdressLine1).HasColumnName(@"AdressLine1").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.AdressLine2).HasColumnName(@"AdressLine2").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.ZipCode).HasColumnName(@"ZipCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.City).HasColumnName(@"City").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.StreetCode).HasColumnName(@"StreetCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(10);
            Property(x => x.CountryCode).HasColumnName(@"CountryCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.Language).HasColumnName(@"Language").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.Phone1).HasColumnName(@"Phone1").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Phone2).HasColumnName(@"Phone2").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Fax1).HasColumnName(@"Fax1").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Fax2).HasColumnName(@"Fax2").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Email1).HasColumnName(@"Email1").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.Email2).HasColumnName(@"Email2").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.Website).HasColumnName(@"Website").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.LastUpdated).HasColumnName(@"LastUpdated").HasColumnType("datetime").IsOptional();
            Property(x => x.OnNumber).HasColumnName(@"ONNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Rpr).HasColumnName(@"RPR").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.RegNr).HasColumnName(@"RegNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ContactTitle).HasColumnName(@"ContactTitle").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ContactName).HasColumnName(@"ContactName").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.ContactPhone).HasColumnName(@"ContactPhone").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.ContactEmail).HasColumnName(@"ContactEmail").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.ContactLastUpdated).HasColumnName(@"ContactLastUpdated").HasColumnType("datetime").IsOptional();
            Property(x => x.ContactGsm).HasColumnName(@"ContactGSM").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.ContactAanhef).HasColumnName(@"ContactAanhef").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);

            HasRequired(a => a.Calculation).WithMany(b => b.CalcOfferClients).HasForeignKey(c => c.CalcId);
        }
    }
}
