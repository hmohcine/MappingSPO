using MappingSPO.Entities;

namespace MappingSPO
{
    public class SysUserSettingUserObjectEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SysUserSettingUserObjectEntity>
    {
        public SysUserSettingUserObjectEntityConfiguration()
            : this("Settings")
        {
        }

        public SysUserSettingUserObjectEntityConfiguration(string schema)
        {
            ToTable("tsysUserSettingUserObjects", schema);
            HasKey(x => new { x.ObjectId, x.UserId });

            Property(x => x.ObjectId).HasColumnName(@"ObjectID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UserId).HasColumnName(@"UserID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UserDefault).HasColumnName(@"UserDefault").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ViewsActive).HasColumnName(@"ViewsActive").HasColumnType("bit").IsRequired();
            Property(x => x.UserDefaultViews).HasColumnName(@"UserDefaultViews").HasColumnType("nvarchar(max)").IsOptional();

            HasRequired(a => a.SysUserSettingObject).WithMany(b => b.SysUserSettingUserObjects).HasForeignKey(c => c.ObjectId).WillCascadeOnDelete(false);
            HasRequired(a => a.User).WithMany(b => b.SysUserSettingUserObjects).HasForeignKey(c => c.UserId).WillCascadeOnDelete(false);
        }
    }
}
