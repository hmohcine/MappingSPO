using MappingSPO.Entities;

namespace MappingSPO
{
    public class ParitairComiteCounterEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ParitairComiteCounterEntity>
    {
        public ParitairComiteCounterEntityConfiguration()
            : this("BackOffice")
        {
        }

        public ParitairComiteCounterEntityConfiguration(string schema)
        {
            ToTable("tParitairComite_Counters", schema);
            HasKey(x => x.PcCounterId);

            Property(x => x.ParitairComiteId).HasColumnName(@"ParitairComiteID").HasColumnType("bigint").IsRequired();
            Property(x => x.CounterId).HasColumnName(@"CounterID").HasColumnType("bigint").IsRequired();
            Property(x => x.PcCounterId).HasColumnName(@"PCCounterID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            HasRequired(a => a.CounterDefinition).WithMany(b => b.ParitairComiteCounters).HasForeignKey(c => c.CounterId);
            HasRequired(a => a.ParitairComite).WithMany(b => b.ParitairComiteCounters).HasForeignKey(c => c.ParitairComiteId).WillCascadeOnDelete(false);
        }
    }
}
