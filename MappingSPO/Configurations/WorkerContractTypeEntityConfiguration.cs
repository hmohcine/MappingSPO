using MappingSPO.Entities;

namespace MappingSPO
{
    public class WorkerContractTypeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WorkerContractTypeEntity>
    {
        public WorkerContractTypeEntityConfiguration()
            : this("BackOffice")
        {
        }

        public WorkerContractTypeEntityConfiguration(string schema)
        {
            ToTable("tWorkerContractType", schema);
            HasKey(x => x.ContractTypeId);

            Property(x => x.ContractTypeId).HasColumnName(@"ContractTypeID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsRequired().HasMaxLength(10);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.DefaultExportSocSecYn).HasColumnName(@"DefaultExportSocSecYn").HasColumnType("bit").IsRequired();
            Property(x => x.DefaultExportPlanningYn).HasColumnName(@"DefaultExportPlanningYn").HasColumnType("bit").IsRequired();
            Property(x => x.DefaultExportTrackAndTraceYn).HasColumnName(@"DefaultExportTrackAndTraceYn").HasColumnType("bit").IsRequired();
            Property(x => x.DefaultExportBuildMobileYn).HasColumnName(@"DefaultExportBuildMobileYn").HasColumnType("bit").IsRequired();
            Property(x => x.VoorschotBerekenenYn).HasColumnName(@"VoorschotBerekenenYn").HasColumnType("bit").IsRequired();
        }
    }
}
