using MappingSPO.Entities;

namespace MappingSPO
{
    public class MobiliteitTariefDetailEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MobiliteitTariefDetailEntity>
    {
        public MobiliteitTariefDetailEntityConfiguration()
            : this("BackOffice")
        {
        }

        public MobiliteitTariefDetailEntityConfiguration(string schema)
        {
            ToTable("tmobiliteitTariefDetail", schema);
            HasKey(x => new { x.MobCode, x.KmFrom });

            Property(x => x.MobCode).HasColumnName(@"MobCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.KmFrom).HasColumnName(@"KmFrom").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.KmTo).HasColumnName(@"KmTo").HasColumnType("int").IsOptional();
            Property(x => x.MobPrijsPerKm).HasColumnName(@"MobPrijsPerKm").HasColumnType("decimal").IsRequired().HasPrecision(20,6);

            HasRequired(a => a.MobiliteitsCode).WithMany(b => b.MobiliteitTariefDetails).HasForeignKey(c => c.MobCode).WillCascadeOnDelete(false);
        }
    }
}
