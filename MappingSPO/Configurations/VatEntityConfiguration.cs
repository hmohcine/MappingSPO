using MappingSPO.Entities;

namespace MappingSPO
{
    public class VatEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VatEntity>
    {
        public VatEntityConfiguration()
            : this("Settings")
        {
        }

        public VatEntityConfiguration(string schema)
        {
            ToTable("tVAT", schema);
            HasKey(x => x.VatCode);

            Property(x => x.VatCode).HasColumnName(@"VatCode").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.VatPct).HasColumnName(@"VatPct").HasColumnType("float").IsOptional();
            Property(x => x.ExternalCode).HasColumnName(@"ExternalCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
        }
    }
}
