using MappingSPO.Entities;

namespace MappingSPO
{
    public class SysMpSettingsCijfersLabelEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SysMpSettingsCijfersLabelEntity>
    {
        public SysMpSettingsCijfersLabelEntityConfiguration()
            : this("Settings")
        {
        }

        public SysMpSettingsCijfersLabelEntityConfiguration(string schema)
        {
            ToTable("tsysMPSettingsCijfers_Labels", schema);
            HasKey(x => new { x.KolomId, x.UiLanguageCode });

            Property(x => x.KolomId).HasColumnName(@"KolomID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UiLanguageCode).HasColumnName(@"UILanguageCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.KolomLabel).HasColumnName(@"KolomLabel").HasColumnType("nvarchar").IsRequired().HasMaxLength(150);

            HasRequired(a => a.SysMpSettingsCijfer).WithMany(b => b.SysMpSettingsCijfersLabels).HasForeignKey(c => c.KolomId).WillCascadeOnDelete(false);
        }
    }
}
