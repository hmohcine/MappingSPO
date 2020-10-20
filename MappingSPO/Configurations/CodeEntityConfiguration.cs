using MappingSPO.Entities;

namespace MappingSPO
{
    public class CodeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CodeEntity>
    {
        public CodeEntityConfiguration()
            : this("Settings")
        {
        }

        public CodeEntityConfiguration(string schema)
        {
            ToTable("tCodes", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Context).HasColumnName(@"Context").HasColumnType("int").IsRequired();
            Property(x => x.CodeIndex).HasColumnName(@"CodeIndex").HasColumnType("int").IsRequired();
            Property(x => x.Visible).HasColumnName(@"Visible").HasColumnType("bit").IsRequired();
            Property(x => x.Required).HasColumnName(@"Required").HasColumnType("bit").IsRequired();
        }
    }
}
