using MappingSPO.Entities;

namespace MappingSPO
{
    public class ProjectExplorerSpecialQueryEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProjectExplorerSpecialQueryEntity>
    {
        public ProjectExplorerSpecialQueryEntityConfiguration()
            : this("Settings")
        {
        }

        public ProjectExplorerSpecialQueryEntityConfiguration(string schema)
        {
            ToTable("tProjectExplorerSpecialQuerys", schema);
            HasKey(x => x.Code);

            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Displayname).HasColumnName(@"Displayname").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar").IsOptional().HasMaxLength(500);
            Property(x => x.SqlStatement).HasColumnName(@"SQLStatement").HasColumnType("nvarchar").IsRequired().HasMaxLength(4000);
            Property(x => x.LineOrder).HasColumnName(@"LineOrder").HasColumnType("bigint").IsRequired();
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
            Property(x => x.UserGroupId).HasColumnName(@"UserGroupID").HasColumnType("int").IsOptional();
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("int").IsRequired();
        }
    }
}
