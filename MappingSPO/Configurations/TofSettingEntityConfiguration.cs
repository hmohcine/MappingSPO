using MappingSPO.Entities;

namespace MappingSPO
{
    public class TofSettingEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TofSettingEntity>
    {
        public TofSettingEntityConfiguration()
            : this("Settings")
        {
        }

        public TofSettingEntityConfiguration(string schema)
        {
            ToTable("tTOFSettings", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TofEnabled).HasColumnName(@"TofEnabled").HasColumnType("bit").IsRequired();
            Property(x => x.SupplierIdRequired).HasColumnName(@"SupplierIDRequired").HasColumnType("bit").IsRequired();
            Property(x => x.ReferenceRequired).HasColumnName(@"ReferenceRequired").HasColumnType("bit").IsRequired();
            Property(x => x.DescriptionRequired).HasColumnName(@"DescriptionRequired").HasColumnType("bit").IsRequired();
            Property(x => x.EcRequired).HasColumnName(@"ECRequired").HasColumnType("bit").IsRequired();
            Property(x => x.KsRequired).HasColumnName(@"KSRequired").HasColumnType("bit").IsRequired();
            Property(x => x.InkoopCatIdRequired).HasColumnName(@"InkoopCatIDRequired").HasColumnType("bit").IsRequired();
        }
    }
}
