using MappingSPO.Entities;

namespace MappingSPO
{
    public class BatchJobEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BatchJobEntity>
    {
        public BatchJobEntityConfiguration()
            : this("Settings")
        {
        }

        public BatchJobEntityConfiguration(string schema)
        {
            ToTable("tBatchJob", schema);
            HasKey(x => x.BatchJobId);

            Property(x => x.BatchJobId).HasColumnName(@"BatchJobId").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.JobId).HasColumnName(@"JobId").HasColumnType("int").IsRequired();
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsRequired().HasMaxLength(250);
            Property(x => x.StartTime).HasColumnName(@"StartTime").HasColumnType("datetime2").IsOptional();
            Property(x => x.EndTime).HasColumnName(@"EndTime").HasColumnType("datetime2").IsOptional();
            Property(x => x.RecurrencyType).HasColumnName(@"RecurrencyType").HasColumnType("int").IsOptional();
            Property(x => x.WhichDays).HasColumnName(@"WhichDays").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.IntervalMinutes).HasColumnName(@"IntervalMinutes").HasColumnType("int").IsOptional();
            Property(x => x.LastRunDate).HasColumnName(@"LastRunDate").HasColumnType("datetime").IsOptional();
            Property(x => x.NextRunDate).HasColumnName(@"NextRunDate").HasColumnType("datetime").IsOptional();
            Property(x => x.LastRunDuration).HasColumnName(@"LastRunDuration").HasColumnType("int").IsOptional();
            Property(x => x.Enabled).HasColumnName(@"Enabled").HasColumnType("bit").IsRequired();
            Property(x => x.IsRunning).HasColumnName(@"IsRunning").HasColumnType("bit").IsRequired();
        }
    }
}
