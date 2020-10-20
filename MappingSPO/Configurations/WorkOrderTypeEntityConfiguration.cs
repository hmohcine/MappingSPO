using MappingSPO.Entities;

namespace MappingSPO
{
    public class WorkOrderTypeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WorkOrderTypeEntity>
    {
        public WorkOrderTypeEntityConfiguration()
            : this("BackOffice")
        {
        }

        public WorkOrderTypeEntityConfiguration(string schema)
        {
            ToTable("tWorkOrderType", schema);
            HasKey(x => x.WorkOrderTypeId);

            Property(x => x.WorkOrderTypeId).HasColumnName(@"WorkOrderTypeID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsOptional().HasMaxLength(4);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.Mastertype).HasColumnName(@"Mastertype").HasColumnType("int").IsRequired();
            Property(x => x.DefaultWerfId).HasColumnName(@"DefaultWerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.DefaultWerkCode).HasColumnName(@"DefaultWerkCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(10);
            Property(x => x.Icon).HasColumnName(@"Icon").HasColumnType("image").IsOptional().HasMaxLength(2147483647);

            HasRequired(a => a.WerkCode).WithMany(b => b.WorkOrderTypes).HasForeignKey(c => c.DefaultWerkCode).WillCascadeOnDelete(false);
        }
    }
}
