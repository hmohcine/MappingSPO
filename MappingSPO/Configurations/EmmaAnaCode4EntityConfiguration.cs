using MappingSPO.Entities;

namespace MappingSPO
{
    public class EmmaAnaCode4EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmmaAnaCode4Entity>
    {
        public EmmaAnaCode4EntityConfiguration()
            : this("Settings")
        {
        }

        public EmmaAnaCode4EntityConfiguration(string schema)
        {
            ToTable("tEmmaAnaCode4", schema);
            HasKey(x => x.CodeId);

            Property(x => x.CodeId).HasColumnName(@"CodeID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CalcPct).HasColumnName(@"CalcPct").HasColumnType("float").IsOptional();
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
            Property(x => x.EmployeeId).HasColumnName(@"EmployeeID").HasColumnType("int").IsOptional();

            HasOptional(a => a.Employee).WithMany(b => b.EmmaAnaCode4).HasForeignKey(c => c.EmployeeId).WillCascadeOnDelete(false);
        }
    }
}
