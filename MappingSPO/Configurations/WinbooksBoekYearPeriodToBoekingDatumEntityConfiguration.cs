using MappingSPO.Entities;

namespace MappingSPO
{
    public class WinbooksBoekYearPeriodToBoekingDatumEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WinbooksBoekYearPeriodToBoekingDatumEntity>
    {
        public WinbooksBoekYearPeriodToBoekingDatumEntityConfiguration()
            : this("Settings")
        {
        }

        public WinbooksBoekYearPeriodToBoekingDatumEntityConfiguration(string schema)
        {
            ToTable("tWinbooksBoekYearPeriodToBoekingDatum", schema);
            HasKey(x => new { x.CompanyId, x.Bookyear, x.Period });

            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Bookyear).HasColumnName(@"BOOKYEAR").HasColumnType("nvarchar").IsRequired().HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Period).HasColumnName(@"PERIOD").HasColumnType("nvarchar").IsRequired().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BoekDatum).HasColumnName(@"BoekDatum").HasColumnType("datetime").IsRequired();
        }
    }
}
