using MappingSPO.Entities;

namespace MappingSPO
{
    public class BatchJobParameterEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BatchJobParameterEntity>
    {
        public BatchJobParameterEntityConfiguration()
            : this("Settings")
        {
        }

        public BatchJobParameterEntityConfiguration(string schema)
        {
            ToTable("tBatchJobParameters", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BatchJobId).HasColumnName(@"BatchJobId").HasColumnType("bigint").IsRequired();
            Property(x => x.ParamKey).HasColumnName(@"ParamKey").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.ParamValue).HasColumnName(@"ParamValue").HasColumnType("nvarchar(max)").IsOptional();

            HasRequired(a => a.BatchJob).WithMany(b => b.BatchJobParameters).HasForeignKey(c => c.BatchJobId).WillCascadeOnDelete(false);
        }
    }
}
