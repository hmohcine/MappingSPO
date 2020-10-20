using MappingSPO.Entities;

namespace MappingSPO
{
    public class MaatTypeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MaatTypeEntity>
    {
        public MaatTypeEntityConfiguration()
            : this("Settings")
        {
        }

        public MaatTypeEntityConfiguration(string schema)
        {
            ToTable("tMaatTypes", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.DefaultUc).HasColumnName(@"DefaultUC").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
        }
    }
}
