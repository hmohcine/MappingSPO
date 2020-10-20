using MappingSPO.Entities;

namespace MappingSPO
{
    public class CounterWerkCodeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CounterWerkCodeEntity>
    {
        public CounterWerkCodeEntityConfiguration()
            : this("BackOffice")
        {
        }

        public CounterWerkCodeEntityConfiguration(string schema)
        {
            ToTable("tCounterWerkCodes", schema);
            HasKey(x => new { x.CounterId, x.WerkCode });

            Property(x => x.CounterId).HasColumnName(@"CounterID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.WerkCode).HasColumnName(@"WerkCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mode).HasColumnName(@"Mode").HasColumnType("int").IsRequired();

            HasRequired(a => a.CounterDefinition).WithMany(b => b.CounterWerkCodes).HasForeignKey(c => c.CounterId);
            HasRequired(a => a.WerkCode_WerkCode).WithMany(b => b.CounterWerkCodes).HasForeignKey(c => c.WerkCode).WillCascadeOnDelete(false);
        }
    }
}
