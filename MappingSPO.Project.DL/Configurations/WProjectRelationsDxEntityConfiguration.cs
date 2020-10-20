using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WProjectRelationsDxEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WProjectRelationsDxEntity>
    {
        public WProjectRelationsDxEntityConfiguration()
            : this("dbo")
        {
        }

        public WProjectRelationsDxEntityConfiguration(string schema)
        {
            ToTable("vwProjectRelationsDX", schema);
            HasKey(x => new { x.ProjectId, x.ProjectType, x.RelationId });

            Property(x => x.ProjectId).HasColumnName(@"ProjectId").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsRequired().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RelationId).HasColumnName(@"RelationId").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            HasRequired(a => a.WMasterProjectExplorerDx).WithMany(b => b.WProjectRelationsDxes).HasForeignKey(c => new { c.ProjectId, c.ProjectType }).WillCascadeOnDelete(false);
            HasRequired(a => a.WProjectExplorerDx).WithMany(b => b.WProjectRelationsDxes).HasForeignKey(c => new { c.ProjectId, c.ProjectType }).WillCascadeOnDelete(false);
        }
    }
}
