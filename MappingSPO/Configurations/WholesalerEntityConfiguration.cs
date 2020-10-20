using MappingSPO.Entities;

namespace MappingSPO
{
    public class WholesalerEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WholesalerEntity>
    {
        public WholesalerEntityConfiguration()
            : this("Settings")
        {
        }

        public WholesalerEntityConfiguration(string schema)
        {
            ToTable("tWholesaler", schema);
            HasKey(x => new { x.Wholesalerkey, x.Environment });

            Property(x => x.Wholesalerkey).HasColumnName(@"Wholesalerkey").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Environment).HasColumnName(@"Environment").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IsActive).HasColumnName(@"IsActive").HasColumnType("bit").IsRequired();
            Property(x => x.FullName).HasColumnName(@"FullName").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.WebsiteUrl).HasColumnName(@"WebsiteUrl").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.StoreUrl).HasColumnName(@"StoreUrl").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.DefaultStoreUserName).HasColumnName(@"DefaultStoreUserName").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.DefaultStorePassword).HasColumnName(@"DefaultStorePassword").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WebserviceUrl).HasColumnName(@"WebserviceUrl").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.WebserviceUserName).HasColumnName(@"WebserviceUserName").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WebservicePassword).HasColumnName(@"WebservicePassword").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CustomerId).HasColumnName(@"CustomerId").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.NumFieldEcotax).HasColumnName(@"NumField_Ecotax").HasColumnType("int").IsOptional();
            Property(x => x.NumFieldSabam).HasColumnName(@"NumField_Sabam").HasColumnType("int").IsOptional();
            Property(x => x.NumFieldRecupel).HasColumnName(@"NumField_Recupel").HasColumnType("int").IsOptional();
        }
    }
}
