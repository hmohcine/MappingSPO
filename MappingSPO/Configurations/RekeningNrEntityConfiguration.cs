using MappingSPO.Entities;

namespace MappingSPO
{
    public class RekeningNrEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RekeningNrEntity>
    {
        public RekeningNrEntityConfiguration()
            : this("Relations")
        {
        }

        public RekeningNrEntityConfiguration(string schema)
        {
            ToTable("tRekeningNr", schema);
            HasKey(x => x.RekeningId);

            Property(x => x.RekeningId).HasColumnName(@"RekeningID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BancName).HasColumnName(@"BancName").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.BancNr).HasColumnName(@"BancNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.IbanNr).HasColumnName(@"IbanNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.BicNr).HasColumnName(@"BicNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Priority).HasColumnName(@"Priority").HasColumnType("int").IsRequired();
        }
    }
}
