using MappingSPO.Entities;

namespace MappingSPO
{
    public class MagazijnEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MagazijnEntity>
    {
        public MagazijnEntityConfiguration()
            : this("Settings")
        {
        }

        public MagazijnEntityConfiguration(string schema)
        {
            ToTable("tMagazijn", schema);
            HasKey(x => x.MagazijnId);

            Property(x => x.MagazijnId).HasColumnName(@"MagazijnID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Magazijn_).HasColumnName(@"Magazijn").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.AdressLine1).HasColumnName(@"AdressLine1").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.AdressLine2).HasColumnName(@"AdressLine2").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.ZipCode).HasColumnName(@"ZipCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.City).HasColumnName(@"City").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.StreetCode).HasColumnName(@"StreetCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(10);
            Property(x => x.CountryCode).HasColumnName(@"CountryCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.Country).HasColumnName(@"Country").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.OpeningsUren).HasColumnName(@"OpeningsUren").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Afkorting).HasColumnName(@"Afkorting").HasColumnType("nvarchar").IsRequired().HasMaxLength(10);
            Property(x => x.GridPosition).HasColumnName(@"GridPosition").HasColumnType("int").IsOptional();
            Property(x => x.BColor).HasColumnName(@"bColor").HasColumnType("int").IsOptional();
            Property(x => x.ShowInGrid).HasColumnName(@"ShowInGrid").HasColumnType("bit").IsRequired();
            Property(x => x.MagazijnierId).HasColumnName(@"MagazijnierID").HasColumnType("int").IsOptional();
            Property(x => x.Phone1).HasColumnName(@"Phone1").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Phone2).HasColumnName(@"Phone2").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Fax1).HasColumnName(@"Fax1").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Fax2).HasColumnName(@"Fax2").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Email1).HasColumnName(@"Email1").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.IsWerfMagazijn).HasColumnName(@"IsWerfMagazijn").HasColumnType("bit").IsRequired();
            Property(x => x.IsVirtualMagazijn).HasColumnName(@"IsVirtualMagazijn").HasColumnType("bit").IsRequired();
            Property(x => x.RealMagazijnId).HasColumnName(@"RealMagazijnID").HasColumnType("bigint").IsOptional();
            Property(x => x.OverNemenVanWerfAdres).HasColumnName(@"OverNemenVanWerfAdres").HasColumnType("bit").IsRequired();

            HasOptional(a => a.Country_CountryCode).WithMany(b => b.Magazijns).HasForeignKey(c => c.CountryCode).WillCascadeOnDelete(false);
            HasOptional(a => a.Employee).WithMany(b => b.Magazijns).HasForeignKey(c => c.MagazijnierId).WillCascadeOnDelete(false);
        }
    }
}
