using MappingSPO.Entities;

namespace MappingSPO
{
    public class SysUserSettingObjectEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SysUserSettingObjectEntity>
    {
        public SysUserSettingObjectEntityConfiguration()
            : this("Settings")
        {
        }

        public SysUserSettingObjectEntityConfiguration(string schema)
        {
            ToTable("tsysUserSettingObjects", schema);
            HasKey(x => x.ObjectId);

            Property(x => x.ObjectId).HasColumnName(@"ObjectID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ObjectName).HasColumnName(@"ObjectName").HasColumnType("nvarchar").IsOptional().HasMaxLength(4000);
            Property(x => x.CompanyDefault).HasColumnName(@"CompanyDefault").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ViewsActive).HasColumnName(@"ViewsActive").HasColumnType("bit").IsRequired();
            Property(x => x.CompanyDefaultViews).HasColumnName(@"CompanyDefaultViews").HasColumnType("nvarchar(max)").IsOptional();
        }
    }
}
