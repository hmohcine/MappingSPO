using MappingSPO.Entities;

namespace MappingSPO
{
    public class EmmaAnaCode9EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmmaAnaCode9Entity>
    {
        public EmmaAnaCode9EntityConfiguration()
            : this("Settings")
        {
        }

        public EmmaAnaCode9EntityConfiguration(string schema)
        {
            ToTable("tEmmaAnaCode9", schema);
            HasKey(x => x.CodeId);

            Property(x => x.CodeId).HasColumnName(@"CodeID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
            Property(x => x.CalcPct).HasColumnName(@"CalcPct").HasColumnType("float").IsOptional();
            Property(x => x.EmployeeId).HasColumnName(@"EmployeeID").HasColumnType("int").IsOptional();
        }
    }
}
