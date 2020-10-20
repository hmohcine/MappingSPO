using MappingSPO.Entities;

namespace MappingSPO
{
    public class AutomaticCalcLibraryEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AutomaticCalcLibraryEntity>
    {
        public AutomaticCalcLibraryEntityConfiguration()
            : this("Settings")
        {
        }

        public AutomaticCalcLibraryEntityConfiguration(string schema)
        {
            ToTable("tAutomaticCalcLibrarys", schema);
            HasKey(x => new { x.Id, x.CalcId });

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Priority).HasColumnName(@"Priority").HasColumnType("int").IsRequired();

            HasRequired(a => a.AutomaticCalcSetting).WithMany(b => b.AutomaticCalcLibraries).HasForeignKey(c => c.Id);
        }
    }
}
