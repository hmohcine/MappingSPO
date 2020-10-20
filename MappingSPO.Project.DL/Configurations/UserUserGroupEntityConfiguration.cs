using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class UserUserGroupEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UserUserGroupEntity>
    {
        public UserUserGroupEntityConfiguration()
            : this("HumanResources")
        {
        }

        public UserUserGroupEntityConfiguration(string schema)
        {
            ToTable("tUserUserGroup", schema);
            HasKey(x => new { x.UserId, x.UserGroupId });

            Property(x => x.UserId).HasColumnName(@"UserID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UserGroupId).HasColumnName(@"UserGroupID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            HasRequired(a => a.UsersGroep).WithMany(b => b.UserUserGroups).HasForeignKey(c => c.UserGroupId).WillCascadeOnDelete(false);
        }
    }
}
