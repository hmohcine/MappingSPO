using MappingSPO.Entities;

namespace MappingSPO
{
    public class ParitairComiteEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ParitairComiteEntity>
    {
        public ParitairComiteEntityConfiguration()
            : this("BackOffice")
        {
        }

        public ParitairComiteEntityConfiguration(string schema)
        {
            ToTable("tParitairComite", schema);
            HasKey(x => x.ParitairComiteId);

            Property(x => x.ParitairComiteId).HasColumnName(@"ParitairComiteID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsRequired().HasMaxLength(10);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsRequired().HasMaxLength(250);
        }
    }
}
