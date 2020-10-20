using MappingSPO.Entities;

namespace MappingSPO
{
    public class EmmaVerzendwijzeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmmaVerzendwijzeEntity>
    {
        public EmmaVerzendwijzeEntityConfiguration()
            : this("Settings")
        {
        }

        public EmmaVerzendwijzeEntityConfiguration(string schema)
        {
            ToTable("tEmmaVerzendwijze", schema);
            HasKey(x => x.VerzendWijzeId);

            Property(x => x.VerzendWijzeId).HasColumnName(@"VerzendWijzeID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Verzendwijze).HasColumnName(@"Verzendwijze").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
        }
    }
}
