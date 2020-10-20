using MappingSPO.Entities;

namespace MappingSPO
{
    public class WorkFlowEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WorkFlowEntity>
    {
        public WorkFlowEntityConfiguration()
            : this("Project")
        {
        }

        public WorkFlowEntityConfiguration(string schema)
        {
            ToTable("tWorkFlow", schema);
            HasKey(x => x.WorkflowId);

            Property(x => x.WorkflowId).HasColumnName(@"WorkflowID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Type).HasColumnName(@"Type").HasColumnType("int").IsRequired();
            Property(x => x.UpdatedBy).HasColumnName(@"UpdatedBy").HasColumnType("int").IsRequired();
            Property(x => x.UpdatedDate).HasColumnName(@"UpdatedDate").HasColumnType("datetime").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("int").IsRequired();
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").HasColumnType("datetime").IsRequired();
            Property(x => x.WfGuid).HasColumnName(@"WfGuid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ProjectWorkflow).HasColumnName(@"ProjectWorkflow").HasColumnType("bit").IsRequired();
            Property(x => x.OriginalWorkFlowId).HasColumnName(@"OriginalWorkFlowID").HasColumnType("bigint").IsOptional();
            Property(x => x.ShowInSearchCombo).HasColumnName(@"ShowInSearchCombo").HasColumnType("bit").IsRequired();
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();

            HasOptional(a => a.OriginalWorkFlow).WithMany(b => b.WorkFlows).HasForeignKey(c => c.OriginalWorkFlowId).WillCascadeOnDelete(false);
            HasRequired(a => a.User_CreatedBy).WithMany(b => b.WorkFlows_CreatedBy).HasForeignKey(c => c.CreatedBy).WillCascadeOnDelete(false);
            HasRequired(a => a.User_UpdatedBy).WithMany(b => b.WorkFlows_UpdatedBy).HasForeignKey(c => c.UpdatedBy).WillCascadeOnDelete(false);
        }
    }
}
