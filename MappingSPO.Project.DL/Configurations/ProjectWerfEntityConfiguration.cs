using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class ProjectWerfEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProjectWerfEntity>
    {
        public ProjectWerfEntityConfiguration()
            : this("Project")
        {
        }

        public ProjectWerfEntityConfiguration(string schema)
        {
            ToTable("tProjectWerf", schema);
            HasKey(x => new { x.ProjectId, x.ProjectType, x.WerfId });

            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsRequired().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IncludeInSum).HasColumnName(@"IncludeInSum").HasColumnType("bit").IsRequired();
            Property(x => x.IncludeInXrm).HasColumnName(@"IncludeInXRM").HasColumnType("bit").IsRequired();
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.LineOrder).HasColumnName(@"LineOrder").HasColumnType("int").IsRequired();
            Property(x => x.TypeWerf).HasColumnName(@"TypeWerf").HasColumnType("int").IsRequired();

            HasRequired(a => a.Project).WithMany(b => b.ProjectWerfs).HasForeignKey(c => new { c.ProjectId, c.ProjectType }).WillCascadeOnDelete(false);
            HasRequired(a => a.Werf).WithMany(b => b.ProjectWerfs).HasForeignKey(c => c.WerfId);
        }
    }
}
