using MappingSPO.Entities;

namespace MappingSPO
{
    public class CompanyEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CompanyEntity>
    {
        public CompanyEntityConfiguration()
            : this("HumanResources")
        {
        }

        public CompanyEntityConfiguration(string schema)
        {
            ToTable("tCompanies", schema);
            HasKey(x => x.CompanyId);

            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Logo).HasColumnName(@"Logo").HasColumnType("image").IsOptional().HasMaxLength(2147483647);
            Property(x => x.OnNumber).HasColumnName(@"ONNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Rpr).HasColumnName(@"RPR").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Title).HasColumnName(@"Title").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.AdressLine1).HasColumnName(@"AdressLine1").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.AdressLine2).HasColumnName(@"AdressLine2").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.ZipCode).HasColumnName(@"ZipCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.City).HasColumnName(@"City").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.StreetCode).HasColumnName(@"StreetCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(10);
            Property(x => x.CountryCode).HasColumnName(@"CountryCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.Language).HasColumnName(@"Language").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.NotesInternal).HasColumnName(@"NotesInternal").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.NotesExternal).HasColumnName(@"NotesExternal").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Phone1).HasColumnName(@"Phone1").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Phone2).HasColumnName(@"Phone2").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Fax1).HasColumnName(@"Fax1").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Fax2).HasColumnName(@"Fax2").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Email1).HasColumnName(@"Email1").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.Email2).HasColumnName(@"Email2").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.Website).HasColumnName(@"Website").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.LastUpdatedBy).HasColumnName(@"LastUpdatedBy").HasColumnType("int").IsOptional();
            Property(x => x.LastUpdated).HasColumnName(@"LastUpdated").HasColumnType("datetime").IsOptional();
            Property(x => x.Reknr1).HasColumnName(@"Reknr1").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Reknr2).HasColumnName(@"Reknr2").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Reknr3).HasColumnName(@"Reknr3").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.RegNr).HasColumnName(@"RegNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.DefaultRekeningId).HasColumnName(@"DefaultRekeningID").HasColumnType("bigint").IsOptional();
            Property(x => x.LogoType).HasColumnName(@"LogoType").HasColumnType("int").IsOptional();
            Property(x => x.ConvertedLogo).HasColumnName(@"ConvertedLogo").HasColumnType("image").IsOptional().HasMaxLength(2147483647);
            Property(x => x.DefaultMagazijnId).HasColumnName(@"DefaultMagazijnID").HasColumnType("bigint").IsOptional();
            Property(x => x.DefaultToonzaalId).HasColumnName(@"DefaultToonzaalID").HasColumnType("bigint").IsOptional();
            Property(x => x.OgmPrefix).HasColumnName(@"OGMPrefix").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.ShowOgm).HasColumnName(@"ShowOGM").HasColumnType("bit").IsRequired();
            Property(x => x.OgmPrefixInUse).HasColumnName(@"OGMPrefixInUse").HasColumnType("bit").IsRequired();
            Property(x => x.RelationId).HasColumnName(@"RelationID").HasColumnType("bigint").IsOptional();
            Property(x => x.DefaultVerkoopCatId).HasColumnName(@"DefaultVerkoopCatID").HasColumnType("bigint").IsOptional();
            Property(x => x.DefaultLoonCostKsIntern).HasColumnName(@"DefaultLoonCostKSIntern").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.DefaultLoonCostIntern).HasColumnName(@"DefaultLoonCostIntern").HasColumnType("float").IsOptional();
            Property(x => x.DefaultLoonCostKsExtern).HasColumnName(@"DefaultLoonCostKSExtern").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.DefaultLoonCostExtern).HasColumnName(@"DefaultLoonCostExtern").HasColumnType("float").IsOptional();
            Property(x => x.ExternalCode).HasColumnName(@"ExternalCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.CompanyType).HasColumnName(@"CompanyType").HasColumnType("int").IsRequired();
            Property(x => x.ParentCompanyId).HasColumnName(@"ParentCompanyID").HasColumnType("int").IsOptional();
            Property(x => x.VoorschotBedragPerRefDag).HasColumnName(@"VoorschotBedragPerRefDag").HasColumnType("decimal").IsOptional().HasPrecision(20,6);
            Property(x => x.VoorschotWerkCode).HasColumnName(@"VoorschotWerkCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);

            HasOptional(a => a.Country).WithMany(b => b.Companies).HasForeignKey(c => c.CountryCode).WillCascadeOnDelete(false);
            HasOptional(a => a.Language_Language).WithMany(b => b.Companies).HasForeignKey(c => c.Language).WillCascadeOnDelete(false);
            HasOptional(a => a.RelActiviteit).WithMany(b => b.Companies).HasForeignKey(c => c.DefaultVerkoopCatId).WillCascadeOnDelete(false);
            HasOptional(a => a.Relation).WithMany(b => b.Companies).HasForeignKey(c => c.RelationId).WillCascadeOnDelete(false);
            HasOptional(a => a.WerkCode).WithMany(b => b.Companies).HasForeignKey(c => c.VoorschotWerkCode).WillCascadeOnDelete(false);
        }
    }
}
