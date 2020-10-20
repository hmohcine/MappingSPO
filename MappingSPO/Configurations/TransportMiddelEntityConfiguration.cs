using MappingSPO.Entities;

namespace MappingSPO
{
    public class TransportMiddelEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TransportMiddelEntity>
    {
        public TransportMiddelEntityConfiguration()
            : this("Settings")
        {
        }

        public TransportMiddelEntityConfiguration(string schema)
        {
            ToTable("tTransportMiddel", schema);
            HasKey(x => x.TransportMiddelId);

            Property(x => x.TransportMiddelId).HasColumnName(@"TransportMiddelID").HasColumnType("nvarchar").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TransportDescription).HasColumnName(@"TransportDescription").HasColumnType("nvarchar").IsRequired().HasMaxLength(250);
            Property(x => x.Bestuurder).HasColumnName(@"Bestuurder").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.BestuurderGsm).HasColumnName(@"BestuurderGSM").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Volgorde).HasColumnName(@"Volgorde").HasColumnType("int").IsRequired();
        }
    }
}
