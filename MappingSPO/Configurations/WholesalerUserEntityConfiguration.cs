using MappingSPO.Entities;

namespace MappingSPO
{
    public class WholesalerUserEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WholesalerUserEntity>
    {
        public WholesalerUserEntityConfiguration()
            : this("Settings")
        {
        }

        public WholesalerUserEntityConfiguration(string schema)
        {
            ToTable("tWholesalerUser", schema);
            HasKey(x => new { x.Wholesalerkey, x.Environment, x.UserId });

            Property(x => x.Wholesalerkey).HasColumnName(@"Wholesalerkey").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Environment).HasColumnName(@"Environment").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UserId).HasColumnName(@"UserID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.StoreUserName).HasColumnName(@"StoreUserName").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.StorePassword).HasColumnName(@"StorePassword").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Allowed).HasColumnName(@"Allowed").HasColumnType("bit").IsOptional();

            HasRequired(a => a.Wholesaler).WithMany(b => b.WholesalerUsers).HasForeignKey(c => new { c.Wholesalerkey, c.Environment });
        }
    }
}
