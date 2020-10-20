using MappingSPO.Entities;

namespace MappingSPO
{
    public class MobiliteitsCodeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MobiliteitsCodeEntity>
    {
        public MobiliteitsCodeEntityConfiguration()
            : this("Settings")
        {
        }

        public MobiliteitsCodeEntityConfiguration(string schema)
        {
            ToTable("tMobiliteitsCode", schema);
            HasKey(x => x.Code);

            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MasterType).HasColumnName(@"MasterType").HasColumnType("int").IsOptional();
        }
    }
}
