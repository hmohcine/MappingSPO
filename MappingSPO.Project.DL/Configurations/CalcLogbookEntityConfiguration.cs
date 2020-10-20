using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcLogbookEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcLogbookEntity>
    {
        public CalcLogbookEntityConfiguration()
            : this("Project")
        {
        }

        public CalcLogbookEntityConfiguration(string schema)
        {
            ToTable("tCalcLogbook", schema);
            HasKey(x => new { x.CalcId, x.VolgNr });

            Property(x => x.CalcId).HasColumnName(@"CalcId").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.VolgNr).HasColumnName(@"VolgNr").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Date).HasColumnName(@"Date").HasColumnType("datetime").IsRequired();
            Property(x => x.UserId).HasColumnName(@"UserId").HasColumnType("int").IsRequired();
            Property(x => x.AppLog).HasColumnName(@"AppLog").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.CustomLog).HasColumnName(@"CustomLog").HasColumnType("nvarchar(max)").IsOptional();

            HasRequired(a => a.Calculation).WithMany(b => b.CalcLogbooks).HasForeignKey(c => c.CalcId).WillCascadeOnDelete(false);
        }
    }
}
