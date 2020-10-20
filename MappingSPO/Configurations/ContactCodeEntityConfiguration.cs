using MappingSPO.Entities;

namespace MappingSPO
{
    public class ContactCodeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ContactCodeEntity>
    {
        public ContactCodeEntityConfiguration()
            : this("Settings")
        {
        }

        public ContactCodeEntityConfiguration(string schema)
        {
            ToTable("tContactCodes", schema);
            HasKey(x => x.CodeId);

            Property(x => x.CodeId).HasColumnName(@"CodeID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CodeIndex).HasColumnName(@"CodeIndex").HasColumnType("int").IsRequired();
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
        }
    }
}
