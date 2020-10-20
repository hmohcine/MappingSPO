using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class ProjectRelationContactEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProjectRelationContactEntity>
    {
        public ProjectRelationContactEntityConfiguration()
            : this("Project")
        {
        }

        public ProjectRelationContactEntityConfiguration(string schema)
        {
            ToTable("tProjectRelationContacts", schema);
            HasKey(x => new { x.ProjectId, x.ProjectType, x.RelationTypeId, x.RelationId, x.ContactId });

            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsRequired().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RelationTypeId).HasColumnName(@"RelationTypeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RelationId).HasColumnName(@"RelationID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ContactId).HasColumnName(@"ContactID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ContactTypeId).HasColumnName(@"ContactTypeID").HasColumnType("int").IsOptional();
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.AutoAddToNewCalcs).HasColumnName(@"AutoAddToNewCalcs").HasColumnType("bit").IsOptional();
            Property(x => x.AddedFromHeader).HasColumnName(@"AddedFromHeader").HasColumnType("bit").IsRequired();

            HasRequired(a => a.Project).WithMany(b => b.ProjectRelationContacts).HasForeignKey(c => new { c.ProjectId, c.ProjectType }).WillCascadeOnDelete(false);
            HasRequired(a => a.ProjectRelation).WithMany(b => b.ProjectRelationContacts).HasForeignKey(c => new { c.ProjectId, c.ProjectType, c.RelationTypeId, c.RelationId }).WillCascadeOnDelete(false);
        }
    }
}
