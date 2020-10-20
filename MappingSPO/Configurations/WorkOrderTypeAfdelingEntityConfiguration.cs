using MappingSPO.Entities;

namespace MappingSPO
{
    public class WorkOrderTypeAfdelingEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WorkOrderTypeAfdelingEntity>
    {
        public WorkOrderTypeAfdelingEntityConfiguration()
            : this("BackOffice")
        {
        }

        public WorkOrderTypeAfdelingEntityConfiguration(string schema)
        {
            ToTable("tWorkOrderType_Afdeling", schema);
            HasKey(x => new { x.WorkOrderTypeId, x.AfdelingId });

            Property(x => x.WorkOrderTypeId).HasColumnName(@"WorkOrderTypeID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AfdelingId).HasColumnName(@"AfdelingID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.LastChangedBy).HasColumnName(@"LastChangedBy").HasColumnType("int").IsRequired();
            Property(x => x.LastChangedDate).HasColumnName(@"LastChangedDate").HasColumnType("datetime").IsRequired();

            HasRequired(a => a.Afdeling).WithMany(b => b.WorkOrderTypeAfdelings).HasForeignKey(c => c.AfdelingId).WillCascadeOnDelete(false);
            HasRequired(a => a.User).WithMany(b => b.WorkOrderTypeAfdelings).HasForeignKey(c => c.LastChangedBy).WillCascadeOnDelete(false);
            HasRequired(a => a.WorkOrderType).WithMany(b => b.WorkOrderTypeAfdelings).HasForeignKey(c => c.WorkOrderTypeId).WillCascadeOnDelete(false);
        }
    }
}
