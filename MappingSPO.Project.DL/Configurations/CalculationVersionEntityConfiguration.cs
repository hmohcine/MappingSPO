using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalculationVersionEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalculationVersionEntity>
    {
        public CalculationVersionEntityConfiguration()
            : this("Project")
        {
        }

        public CalculationVersionEntityConfiguration(string schema)
        {
            ToTable("tCalculationVersion", schema);
            HasKey(x => x.VersionCalcId);

            Property(x => x.OriginalCalcId).HasColumnName(@"OriginalCalcID").HasColumnType("bigint").IsRequired();
            Property(x => x.VersionCalcId).HasColumnName(@"VersionCalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.VersieNr).HasColumnName(@"VersieNr").HasColumnType("int").IsRequired();
            Property(x => x.Opmerking).HasColumnName(@"Opmerking").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();

            HasRequired(a => a.OriginalCalc).WithMany(b => b.CalculationVersions).HasForeignKey(c => c.OriginalCalcId).WillCascadeOnDelete(false);
            HasRequired(a => a.VersionCalc).WithOptional(b => b.CalculationVersion);
        }
    }
}
