using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcStatusHistoriekEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcStatusHistoriekEntity>
    {
        public CalcStatusHistoriekEntityConfiguration()
            : this("Project")
        {
        }

        public CalcStatusHistoriekEntityConfiguration(string schema)
        {
            ToTable("tCalcStatusHistoriek", schema);
            HasKey(x => new { x.CalcId, x.DateChanged });

            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DateChanged).HasColumnName(@"DateChanged").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.OldStatus).HasColumnName(@"OldStatus").HasColumnType("int").IsOptional();
            Property(x => x.CalcStatus).HasColumnName(@"CalcStatus").HasColumnType("int").IsOptional();
            Property(x => x.WhoChanged).HasColumnName(@"WhoChanged").HasColumnType("int").IsOptional();
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();

            HasRequired(a => a.Calculation).WithMany(b => b.CalcStatusHistorieks).HasForeignKey(c => c.CalcId);
        }
    }
}
