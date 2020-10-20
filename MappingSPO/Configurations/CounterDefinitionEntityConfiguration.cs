using MappingSPO.Entities;

namespace MappingSPO
{
    public class CounterDefinitionEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CounterDefinitionEntity>
    {
        public CounterDefinitionEntityConfiguration()
            : this("BackOffice")
        {
        }

        public CounterDefinitionEntityConfiguration(string schema)
        {
            ToTable("tCounterDefinition", schema);
            HasKey(x => x.CounterId);

            Property(x => x.CounterId).HasColumnName(@"CounterID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CounterName).HasColumnName(@"CounterName").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.RestartDate).HasColumnName(@"RestartDate").HasColumnType("date").IsOptional();
            Property(x => x.MaxOverTimeYear).HasColumnName(@"MaxOverTimeYear").HasColumnType("int").IsOptional();
            Property(x => x.MasterType).HasColumnName(@"MasterType").HasColumnType("int").IsRequired();
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
            Property(x => x.ValidDays).HasColumnName(@"ValidDays").HasColumnType("int").IsOptional();
            Property(x => x.MaxPlusTimeOnDay).HasColumnName(@"MaxPlusTimeOnDay").HasColumnType("decimal").IsOptional().HasPrecision(18,2);
        }
    }
}
