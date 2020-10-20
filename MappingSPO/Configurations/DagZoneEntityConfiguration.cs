using MappingSPO.Entities;

namespace MappingSPO
{
    public class DagZoneEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<DagZoneEntity>
    {
        public DagZoneEntityConfiguration()
            : this("Settings")
        {
        }

        public DagZoneEntityConfiguration(string schema)
        {
            ToTable("tDagZone", schema);
            HasKey(x => x.DagZone_);

            Property(x => x.DagZone_).HasColumnName(@"DagZone").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DagZoneDescription).HasColumnName(@"DagZoneDescription").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Volgorde).HasColumnName(@"Volgorde").HasColumnType("int").IsRequired();
        }
    }
}
