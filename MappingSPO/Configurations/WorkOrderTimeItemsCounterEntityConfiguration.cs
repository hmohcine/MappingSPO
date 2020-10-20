using MappingSPO.Entities;

namespace MappingSPO
{
    public class WorkOrderTimeItemsCounterEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WorkOrderTimeItemsCounterEntity>
    {
        public WorkOrderTimeItemsCounterEntityConfiguration()
            : this("BackOffice")
        {
        }

        public WorkOrderTimeItemsCounterEntityConfiguration(string schema)
        {
            ToTable("tWorkOrderTimeItemsCounters", schema);
            HasKey(x => x.Id);

            Property(x => x.TimeItemId).HasColumnName(@"TimeItemID").HasColumnType("bigint").IsRequired();
            Property(x => x.CounterId).HasColumnName(@"CounterID").HasColumnType("bigint").IsRequired();
            Property(x => x.ValidDays).HasColumnName(@"ValidDays").HasColumnType("int").IsRequired();
            Property(x => x.ValidUntilDate).HasColumnName(@"ValidUntilDate").HasColumnType("date").IsRequired();
            Property(x => x.Mode).HasColumnName(@"Mode").HasColumnType("int").IsRequired();
            Property(x => x.WerkCode).HasColumnName(@"WerkCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(10);
            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            HasRequired(a => a.CounterDefinition).WithMany(b => b.WorkOrderTimeItemsCounters).HasForeignKey(c => c.CounterId).WillCascadeOnDelete(false);
        }
    }
}
