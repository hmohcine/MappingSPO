using MappingSPO.Entities;

namespace MappingSPO
{
    public class MobiliteitsCodeTarievenEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MobiliteitsCodeTarievenEntity>
    {
        public MobiliteitsCodeTarievenEntityConfiguration()
            : this("Settings")
        {
        }

        public MobiliteitsCodeTarievenEntityConfiguration(string schema)
        {
            ToTable("tMobiliteitsCodeTarieven", schema);
            HasKey(x => new { x.Code, x.StartDate });

            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("date").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Tarief).HasColumnName(@"Tarief").HasColumnType("decimal").IsRequired().HasPrecision(20,8);
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("date").IsOptional();
            Property(x => x.InUse).HasColumnName(@"InUse").HasColumnType("bit").IsRequired();

            HasRequired(a => a.MobiliteitsCode).WithMany(b => b.MobiliteitsCodeTarievens).HasForeignKey(c => c.Code).WillCascadeOnDelete(false);
        }
    }
}
