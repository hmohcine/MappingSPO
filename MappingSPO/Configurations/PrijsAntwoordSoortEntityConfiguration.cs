using MappingSPO.Entities;

namespace MappingSPO
{
    public class PrijsAntwoordSoortEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PrijsAntwoordSoortEntity>
    {
        public PrijsAntwoordSoortEntityConfiguration()
            : this("Settings")
        {
        }

        public PrijsAntwoordSoortEntityConfiguration(string schema)
        {
            ToTable("tPrijsAntwoordSoort", schema);
            HasKey(x => x.AntwoordSoortId);

            Property(x => x.AntwoordSoortId).HasColumnName(@"AntwoordSoortID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
        }
    }
}
