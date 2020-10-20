using MappingSPO.Entities;

namespace MappingSPO
{
    public class AfmeldingsPuntenEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AfmeldingsPuntenEntity>
    {
        public AfmeldingsPuntenEntityConfiguration()
            : this("Settings")
        {
        }

        public AfmeldingsPuntenEntityConfiguration(string schema)
        {
            ToTable("tAfmeldingsPunten", schema);
            HasKey(x => x.AfmpuntId);

            Property(x => x.AfmpuntId).HasColumnName(@"AfmpuntID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(235);
            Property(x => x.ShowAsMode).HasColumnName(@"ShowASMode").HasColumnType("int").IsRequired();
            Property(x => x.ShowAs).HasColumnName(@"ShowAs").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.ActiviteitId).HasColumnName(@"ActiviteitID").HasColumnType("bigint").IsOptional();
            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.GpsRef).HasColumnName(@"GPSRef").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.AfmpuntType).HasColumnName(@"AfmpuntType").HasColumnType("int").IsRequired();
            Property(x => x.AutoAddToWerfMode).HasColumnName(@"AutoAddToWerfMode").HasColumnType("int").IsRequired();
            Property(x => x.AutoNumber).HasColumnName(@"AutoNumber").HasColumnType("int").IsOptional();

            HasRequired(a => a.AfmeldingPuntType).WithMany(b => b.AfmeldingsPuntens).HasForeignKey(c => c.AfmpuntType).WillCascadeOnDelete(false);
        }
    }
}
