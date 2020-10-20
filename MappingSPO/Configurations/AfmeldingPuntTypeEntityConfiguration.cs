using MappingSPO.Entities;

namespace MappingSPO
{
    public class AfmeldingPuntTypeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AfmeldingPuntTypeEntity>
    {
        public AfmeldingPuntTypeEntityConfiguration()
            : this("Settings")
        {
        }

        public AfmeldingPuntTypeEntityConfiguration(string schema)
        {
            ToTable("tAfmeldingPuntType", schema);
            HasKey(x => x.AfmpuntType);

            Property(x => x.AfmpuntType).HasColumnName(@"AfmpuntType").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.PrefixCode).HasColumnName(@"PrefixCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.AutoNumberYn).HasColumnName(@"AutoNumberYn").HasColumnType("bit").IsRequired();
            Property(x => x.NumberOfDigits).HasColumnName(@"NumberOfDigits").HasColumnType("int").IsOptional();
            Property(x => x.ActivityId).HasColumnName(@"ActivityId").HasColumnType("bigint").IsOptional();

            HasOptional(a => a.Activiteiten).WithMany(b => b.AfmeldingPuntTypes).HasForeignKey(c => c.ActivityId).WillCascadeOnDelete(false);
        }
    }
}
