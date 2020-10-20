using MappingSPO.Entities;

namespace MappingSPO
{
    public class SysUserFilterEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SysUserFilterEntity>
    {
        public SysUserFilterEntityConfiguration()
            : this("Settings")
        {
        }

        public SysUserFilterEntityConfiguration(string schema)
        {
            ToTable("tsysUserFilters", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UserId).HasColumnName(@"UserID").HasColumnType("bigint").IsRequired();
            Property(x => x.ObjectName).HasColumnName(@"ObjectName").HasColumnType("nvarchar").IsRequired().HasMaxLength(4000);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.Filter).HasColumnName(@"Filter").HasColumnType("nvarchar").IsOptional().HasMaxLength(4000);
            Property(x => x.IsDefault).HasColumnName(@"IsDefault").HasColumnType("bit").IsRequired();
            Property(x => x.IsShared).HasColumnName(@"IsShared").HasColumnType("bit").IsOptional();
        }
    }
}
