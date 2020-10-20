using MappingSPO.Entities;

namespace MappingSPO
{
    public class ProjectTypeUserEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProjectTypeUserEntity>
    {
        public ProjectTypeUserEntityConfiguration()
            : this("Settings")
        {
        }

        public ProjectTypeUserEntityConfiguration(string schema)
        {
            ToTable("tProjectTypeUsers", schema);
            HasKey(x => new { x.ProjectType, x.UserId });

            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsRequired().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UserId).HasColumnName(@"UserID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IsManager).HasColumnName(@"IsManager").HasColumnType("bit").IsRequired();
            Property(x => x.CanChangeItems).HasColumnName(@"CanChangeItems").HasColumnType("bit").IsRequired();

            HasRequired(a => a.ProjectType_ProjectType).WithMany(b => b.ProjectTypeUsers).HasForeignKey(c => c.ProjectType);
            HasRequired(a => a.User).WithMany(b => b.ProjectTypeUsers).HasForeignKey(c => c.UserId).WillCascadeOnDelete(false);
        }
    }
}
