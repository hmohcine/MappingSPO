using MappingSPO.Entities;

namespace MappingSPO
{
    public class BatchServiceSettingEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BatchServiceSettingEntity>
    {
        public BatchServiceSettingEntityConfiguration()
            : this("Settings")
        {
        }

        public BatchServiceSettingEntityConfiguration(string schema)
        {
            ToTable("tBatchServiceSettings", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BatchJobUserId).HasColumnName(@"BatchJobUserId").HasColumnType("int").IsRequired();
            Property(x => x.Interval).HasColumnName(@"Interval").HasColumnType("int").IsRequired();
            Property(x => x.UserLanguage).HasColumnName(@"UserLanguage").HasColumnType("nvarchar").IsRequired().HasMaxLength(5);

            HasRequired(a => a.User).WithMany(b => b.BatchServiceSettings).HasForeignKey(c => c.BatchJobUserId).WillCascadeOnDelete(false);
        }
    }
}
