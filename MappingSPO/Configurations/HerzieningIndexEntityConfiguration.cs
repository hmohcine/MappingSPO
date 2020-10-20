using MappingSPO.Entities;

namespace MappingSPO
{
    public class HerzieningIndexEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<HerzieningIndexEntity>
    {
        public HerzieningIndexEntityConfiguration()
            : this("Settings")
        {
        }

        public HerzieningIndexEntityConfiguration(string schema)
        {
            ToTable("tHerzieningIndex", schema);
            HasKey(x => x.IndexCode);

            Property(x => x.IndexCode).HasColumnName(@"IndexCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(15).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.DefaultDigits).HasColumnName(@"DefaultDigits").HasColumnType("int").IsRequired();
            Property(x => x.DateFormat).HasColumnName(@"DateFormat").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.IndexUpper).HasColumnName(@"IndexUpper").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.IndexLower).HasColumnName(@"IndexLower").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
        }
    }
}
