using MappingSPO.Entities;

namespace MappingSPO
{
    public class ProjectTypeWorkFlowEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProjectTypeWorkFlowEntity>
    {
        public ProjectTypeWorkFlowEntityConfiguration()
            : this("Settings")
        {
        }

        public ProjectTypeWorkFlowEntityConfiguration(string schema)
        {
            ToTable("tProjectTypeWorkFlows", schema);
            HasKey(x => new { x.ProjectType, x.WorkflowId });

            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsRequired().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.WorkflowId).HasColumnName(@"WorkflowID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.InitialWorkflowYn).HasColumnName(@"InitialWorkflowYn").HasColumnType("bit").IsRequired();
            Property(x => x.WorkflowOrder).HasColumnName(@"WorkflowOrder").HasColumnType("int").IsRequired();

            HasRequired(a => a.ProjectType_ProjectType).WithMany(b => b.ProjectTypeWorkFlows).HasForeignKey(c => c.ProjectType).WillCascadeOnDelete(false);
            HasRequired(a => a.WorkFlow).WithMany(b => b.ProjectTypeWorkFlows).HasForeignKey(c => c.WorkflowId).WillCascadeOnDelete(false);
        }
    }
}
