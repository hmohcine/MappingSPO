using MappingSPO.Entities;

namespace MappingSPO
{
    public class EmmaAnaCode5EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmmaAnaCode5Entity>
    {
        public EmmaAnaCode5EntityConfiguration()
            : this("Settings")
        {
        }

        public EmmaAnaCode5EntityConfiguration(string schema)
        {
            ToTable("tEmmaAnaCode5", schema);
            HasKey(x => x.CodeId);

            Property(x => x.CodeId).HasColumnName(@"CodeID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CalcPct).HasColumnName(@"CalcPct").HasColumnType("float").IsOptional();
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
            Property(x => x.EmployeeId).HasColumnName(@"EmployeeID").HasColumnType("int").IsOptional();

            HasOptional(a => a.Employee).WithMany(b => b.EmmaAnaCode5).HasForeignKey(c => c.EmployeeId).WillCascadeOnDelete(false);
        }
    }
}
