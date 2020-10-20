using MappingSPO.Entities;

namespace MappingSPO
{
    public class EmmaAnaCode7EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmmaAnaCode7Entity>
    {
        public EmmaAnaCode7EntityConfiguration()
            : this("Settings")
        {
        }

        public EmmaAnaCode7EntityConfiguration(string schema)
        {
            ToTable("tEmmaAnaCode7", schema);
            HasKey(x => x.CodeId);

            Property(x => x.CodeId).HasColumnName(@"CodeID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CalcPct).HasColumnName(@"CalcPct").HasColumnType("float").IsOptional();
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
            Property(x => x.EmployeeId).HasColumnName(@"EmployeeID").HasColumnType("int").IsOptional();

            HasOptional(a => a.Employee).WithMany(b => b.EmmaAnaCode7).HasForeignKey(c => c.EmployeeId).WillCascadeOnDelete(false);
        }
    }
}
