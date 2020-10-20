using MappingSPO.Entities;

namespace MappingSPO
{
    public class EmmaAnaCode1EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmmaAnaCode1Entity>
    {
        public EmmaAnaCode1EntityConfiguration()
            : this("Settings")
        {
        }

        public EmmaAnaCode1EntityConfiguration(string schema)
        {
            ToTable("tEmmaAnaCode1", schema);
            HasKey(x => x.CodeId);

            Property(x => x.CodeId).HasColumnName(@"CodeID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CalcPct).HasColumnName(@"CalcPct").HasColumnType("float").IsOptional();
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
            Property(x => x.EmployeeId).HasColumnName(@"EmployeeID").HasColumnType("int").IsOptional();

            HasOptional(a => a.Employee).WithMany(b => b.EmmaAnaCode1).HasForeignKey(c => c.EmployeeId).WillCascadeOnDelete(false);
        }
    }
}
