using MappingSPO.Entities;

namespace MappingSPO
{
    public class EmmaUserSettingEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmmaUserSettingEntity>
    {
        public EmmaUserSettingEntityConfiguration()
            : this("Settings")
        {
        }

        public EmmaUserSettingEntityConfiguration(string schema)
        {
            ToTable("tEmmaUserSettings", schema);
            HasKey(x => x.UserId);

            Property(x => x.UserId).HasColumnName(@"UserID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AutoJumpAfterAdd).HasColumnName(@"AutoJumpAfterAdd").HasColumnType("bit").IsRequired();
            Property(x => x.AutoReWriteAantalOnStockBestelling).HasColumnName(@"AutoReWriteAantalOnStockBestelling").HasColumnType("bit").IsRequired();
            Property(x => x.AutoFillMagazijnOnStockBestelling).HasColumnName(@"AutoFillMagazijnOnStockBestelling").HasColumnType("bit").IsRequired();

            HasRequired(a => a.User).WithOptional(b => b.EmmaUserSetting).WillCascadeOnDelete(false);
        }
    }
}
