using MappingSPO.Entities;

namespace MappingSPO
{
    public class SysMpSettingsCijferEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SysMpSettingsCijferEntity>
    {
        public SysMpSettingsCijferEntityConfiguration()
            : this("Settings")
        {
        }

        public SysMpSettingsCijferEntityConfiguration(string schema)
        {
            ToTable("tsysMPSettingsCijfers", schema);
            HasKey(x => x.KolomId);

            Property(x => x.KolomId).HasColumnName(@"KolomID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DefaultUiLanguageCode).HasColumnName(@"DefaultUILanguageCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(5);
            Property(x => x.InkoopCatId).HasColumnName(@"InkoopCatID").HasColumnType("bigint").IsRequired();
            Property(x => x.KolomValue).HasColumnName(@"KolomValue").HasColumnType("int").IsRequired();
            Property(x => x.FieldOrder).HasColumnName(@"FieldOrder").HasColumnType("int").IsRequired();
            Property(x => x.UiKolom).HasColumnName(@"UIKolom").HasColumnType("int").IsRequired();

            HasRequired(a => a.RelActiviteit).WithMany(b => b.SysMpSettingsCijfers).HasForeignKey(c => c.InkoopCatId).WillCascadeOnDelete(false);
        }
    }
}
