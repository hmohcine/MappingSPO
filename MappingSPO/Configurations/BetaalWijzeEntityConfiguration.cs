using MappingSPO.Entities;

namespace MappingSPO
{
    public class BetaalWijzeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BetaalWijzeEntity>
    {
        public BetaalWijzeEntityConfiguration()
            : this("Settings")
        {
        }

        public BetaalWijzeEntityConfiguration(string schema)
        {
            ToTable("tBetaalWijze", schema);
            HasKey(x => x.BetaalwijzeId);

            Property(x => x.BetaalwijzeId).HasColumnName(@"BetaalwijzeID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BetaalwijzeDescription).HasColumnName(@"BetaalwijzeDescription").HasColumnType("nvarchar").IsRequired().HasMaxLength(150);
        }
    }
}
