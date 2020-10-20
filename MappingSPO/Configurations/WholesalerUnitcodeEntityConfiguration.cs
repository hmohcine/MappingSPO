using MappingSPO.Entities;

namespace MappingSPO
{
    public class WholesalerUnitcodeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WholesalerUnitcodeEntity>
    {
        public WholesalerUnitcodeEntityConfiguration()
            : this("Settings")
        {
        }

        public WholesalerUnitcodeEntityConfiguration(string schema)
        {
            ToTable("tWholesalerUnitcodes", schema);
            HasKey(x => new { x.Wholesalerkey, x.Environment, x.UcWholesaler });

            Property(x => x.Wholesalerkey).HasColumnName(@"Wholesalerkey").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Environment).HasColumnName(@"Environment").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UcWholesaler).HasColumnName(@"UC_Wholesaler").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UcBuild).HasColumnName(@"UC_Build").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);

            HasOptional(a => a.Uc).WithMany(b => b.WholesalerUnitcodes).HasForeignKey(c => c.UcBuild).WillCascadeOnDelete(false);
            HasRequired(a => a.Wholesaler).WithMany(b => b.WholesalerUnitcodes).HasForeignKey(c => new { c.Wholesalerkey, c.Environment });
        }
    }
}
