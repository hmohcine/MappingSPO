using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WerfRelationEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WerfRelationEntity>
    {
        public WerfRelationEntityConfiguration()
            : this("Project")
        {
        }

        public WerfRelationEntityConfiguration(string schema)
        {
            ToTable("tWerfRelation", schema);
            HasKey(x => new { x.WerfId, x.RelationId, x.RelationTypeId });

            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RelationId).HasColumnName(@"RelationID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RelationTypeId).HasColumnName(@"RelationTypeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.DefaultContactId).HasColumnName(@"DefaultContactID").HasColumnType("int").IsOptional();

            HasRequired(a => a.Relation).WithMany(b => b.WerfRelations).HasForeignKey(c => c.RelationId).WillCascadeOnDelete(false);
            HasRequired(a => a.RelationType).WithMany(b => b.WerfRelations).HasForeignKey(c => c.RelationTypeId).WillCascadeOnDelete(false);
            HasRequired(a => a.Werf).WithMany(b => b.WerfRelations).HasForeignKey(c => c.WerfId);
            HasRequired(a => a.WWerfExplorerDx).WithMany(b => b.WerfRelations).HasForeignKey(c => c.WerfId).WillCascadeOnDelete(false);
        }
    }
}
