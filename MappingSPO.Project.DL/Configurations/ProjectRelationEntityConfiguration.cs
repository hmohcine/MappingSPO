using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class ProjectRelationEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProjectRelationEntity>
    {
        public ProjectRelationEntityConfiguration()
            : this("Project")
        {
        }

        public ProjectRelationEntityConfiguration(string schema)
        {
            ToTable("tProjectRelation", schema);
            HasKey(x => new { x.ProjectId, x.ProjectType, x.RelationTypeId, x.RelationId });

            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsRequired().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RelationTypeId).HasColumnName(@"RelationTypeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RelationId).HasColumnName(@"RelationID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DefaultContactId).HasColumnName(@"DefaultContactID").HasColumnType("int").IsOptional();
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.AutoAddToNewCalcs).HasColumnName(@"AutoAddToNewCalcs").HasColumnType("bit").IsOptional();
            Property(x => x.AddedFromHeader).HasColumnName(@"AddedFromHeader").HasColumnType("bit").IsRequired();

            HasRequired(a => a.Project).WithMany(b => b.ProjectRelations).HasForeignKey(c => new { c.ProjectId, c.ProjectType }).WillCascadeOnDelete(false);
            HasRequired(a => a.Relation).WithMany(b => b.ProjectRelations).HasForeignKey(c => c.RelationId).WillCascadeOnDelete(false);
            HasRequired(a => a.RelationType).WithMany(b => b.ProjectRelations).HasForeignKey(c => c.RelationTypeId).WillCascadeOnDelete(false);
        }
    }
}
