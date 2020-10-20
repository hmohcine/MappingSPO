using MappingSPO.Entities;

namespace MappingSPO
{
    public class ProjectTypeUserGroupEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProjectTypeUserGroupEntity>
    {
        public ProjectTypeUserGroupEntityConfiguration()
            : this("Settings")
        {
        }

        public ProjectTypeUserGroupEntityConfiguration(string schema)
        {
            ToTable("tProjectTypeUserGroup", schema);
            HasKey(x => new { x.ProjectType, x.UserGroupId });

            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsRequired().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UserGroupId).HasColumnName(@"UserGroupID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CanChangeItems).HasColumnName(@"CanChangeItems").HasColumnType("bit").IsRequired();
            Property(x => x.IsManager).HasColumnName(@"IsManager").HasColumnType("bit").IsRequired();

            HasRequired(a => a.ProjectType_ProjectType).WithMany(b => b.ProjectTypeUserGroups).HasForeignKey(c => c.ProjectType);
            HasRequired(a => a.UsersGroep).WithMany(b => b.ProjectTypeUserGroups).HasForeignKey(c => c.UserGroupId).WillCascadeOnDelete(false);
        }
    }
}
