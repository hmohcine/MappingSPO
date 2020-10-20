using MappingSPO.Entities;

namespace MappingSPO
{
    public class EmmaAnaCode8EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmmaAnaCode8Entity>
    {
        public EmmaAnaCode8EntityConfiguration()
            : this("Settings")
        {
        }

        public EmmaAnaCode8EntityConfiguration(string schema)
        {
            ToTable("tEmmaAnaCode8", schema);
            HasKey(x => x.CodeId);

            Property(x => x.CodeId).HasColumnName(@"CodeID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CalcPct).HasColumnName(@"CalcPct").HasColumnType("float").IsOptional();
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
            Property(x => x.EmployeeId).HasColumnName(@"EmployeeID").HasColumnType("int").IsOptional();

            HasOptional(a => a.Employee).WithMany(b => b.EmmaAnaCode8).HasForeignKey(c => c.EmployeeId).WillCascadeOnDelete(false);
        }
    }
}
