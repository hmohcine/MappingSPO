using MappingSPO.Entities;

namespace MappingSPO
{
    public class EmmaMagazijnEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmmaMagazijnEntity>
    {
        public EmmaMagazijnEntityConfiguration()
            : this("Stock")
        {
        }

        public EmmaMagazijnEntityConfiguration(string schema)
        {
            ToTable("tEmmaMagazijn", schema);
            HasKey(x => x.MagazijnId);

            Property(x => x.MagazijnId).HasColumnName(@"MagazijnID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.MagazijnType).HasColumnName(@"MagazijnType").HasColumnType("tinyint").IsRequired();
            Property(x => x.MagazijnName).HasColumnName(@"MagazijnName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.AdressLine1).HasColumnName(@"AdressLine1").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.AdressLine2).HasColumnName(@"AdressLine2").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.ZipCode).HasColumnName(@"ZipCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.City).HasColumnName(@"City").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.StreetCode).HasColumnName(@"StreetCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(10);
            Property(x => x.CountryCode).HasColumnName(@"CountryCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.Country).HasColumnName(@"Country").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.OpeningsUren).HasColumnName(@"OpeningsUren").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Afkorting).HasColumnName(@"Afkorting").HasColumnType("nvarchar").IsRequired().HasMaxLength(10);
            Property(x => x.Phone1).HasColumnName(@"Phone1").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Phone2).HasColumnName(@"Phone2").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Fax1).HasColumnName(@"Fax1").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Fax2).HasColumnName(@"Fax2").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Email1).HasColumnName(@"Email1").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.MagazijnierName).HasColumnName(@"MagazijnierName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.MagazijnierGsm).HasColumnName(@"MagazijnierGSM").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.IsKlantMagazijnYn).HasColumnName(@"IsKlantMagazijnYn").HasColumnType("bit").IsOptional();
            Property(x => x.OwnerArticles).HasColumnName(@"OwnerArticles").HasColumnType("bigint").IsOptional();
            Property(x => x.DeliveryAdressMagazijn).HasColumnName(@"DeliveryAdressMagazijn").HasColumnType("bigint").IsOptional();

            HasOptional(a => a.Relation_DeliveryAdressMagazijn).WithMany(b => b.EmmaMagazijns_DeliveryAdressMagazijn).HasForeignKey(c => c.DeliveryAdressMagazijn).WillCascadeOnDelete(false);
            HasOptional(a => a.Relation_OwnerArticles).WithMany(b => b.EmmaMagazijns_OwnerArticles).HasForeignKey(c => c.OwnerArticles).WillCascadeOnDelete(false);
        }
    }
}
