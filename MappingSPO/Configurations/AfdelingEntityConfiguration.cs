using MappingSPO.Entities;

namespace MappingSPO
{
    public class AfdelingEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AfdelingEntity>
    {
        public AfdelingEntityConfiguration()
            : this("Settings")
        {
        }

        public AfdelingEntityConfiguration(string schema)
        {
            ToTable("tAfdeling", schema);
            HasKey(x => x.AfdelingId);

            Property(x => x.AfdelingId).HasColumnName(@"AfdelingID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AfdelingName).HasColumnName(@"AfdelingName").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.RefTonenYn).HasColumnName(@"RefTonenYn").HasColumnType("bit").IsRequired();
            Property(x => x.DefaultRefLabel).HasColumnName(@"DefaultRefLabel").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.TimesheetType).HasColumnName(@"TimesheetType").HasColumnType("int").IsRequired();
            HasMany(t => t.AfmeldingsPuntens).WithMany(t => t.Afdelings).Map(m =>
            {
                m.ToTable("tAfmeldingsPunt_Afdelingen", "Settings");
                m.MapLeftKey("AfdelingID");
                m.MapRightKey("AfmpuntID");
            });
        }
    }
}
