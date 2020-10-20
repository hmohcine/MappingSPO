using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalculationLogEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalculationLogEntity>
    {
        public CalculationLogEntityConfiguration()
            : this("Project")
        {
        }

        public CalculationLogEntityConfiguration(string schema)
        {
            ToTable("tCalculationLog", schema);
            HasKey(x => new { x.LogId, x.CalcId });

            Property(x => x.LogId).HasColumnName(@"LogID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UserId).HasColumnName(@"UserID").HasColumnType("int").IsRequired();
            Property(x => x.LogType).HasColumnName(@"LogType").HasColumnType("tinyint").IsRequired();
            Property(x => x.TimeEntry).HasColumnName(@"TimeEntry").HasColumnType("datetime").IsRequired();
            Property(x => x.TimeClose).HasColumnName(@"TimeClose").HasColumnType("datetime").IsOptional();
            Property(x => x.Info).HasColumnName(@"Info").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1);

            HasRequired(a => a.Calculation).WithMany(b => b.CalculationLogs).HasForeignKey(c => c.CalcId);
        }
    }
}
