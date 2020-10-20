using MappingSPO.Entities;

namespace MappingSPO
{
    public class SettingEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SettingEntity>
    {
        public SettingEntityConfiguration()
            : this("Settings")
        {
        }

        public SettingEntityConfiguration(string schema)
        {
            ToTable("tSettings", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Caption).HasColumnName(@"Caption").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.ParentId).HasColumnName(@"ParentId").HasColumnType("int").IsOptional();
            Property(x => x.OldSecurityLevel).HasColumnName(@"OldSecurityLevel").HasColumnType("int").IsRequired();
            Property(x => x.Sequence).HasColumnName(@"Sequence").HasColumnType("int").IsRequired();
            Property(x => x.UserControlName).HasColumnName(@"UserControlName").HasColumnType("nvarchar").IsOptional().HasMaxLength(500);
            Property(x => x.Enabled).HasColumnName(@"Enabled").HasColumnType("bit").IsRequired();

            HasOptional(a => a.Parent).WithMany(b => b.Settings).HasForeignKey(c => c.ParentId).WillCascadeOnDelete(false);
            HasMany(t => t.UsersGroeps).WithMany(t => t.Settings).Map(m =>
            {
                m.ToTable("tUserGroupSettings", "Settings");
                m.MapLeftKey("SettingId");
                m.MapRightKey("UserGroupId");
            });
        }
    }
}
