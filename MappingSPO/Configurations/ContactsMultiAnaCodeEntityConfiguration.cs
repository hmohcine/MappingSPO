using MappingSPO.Entities;

namespace MappingSPO
{
    public class ContactsMultiAnaCodeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ContactsMultiAnaCodeEntity>
    {
        public ContactsMultiAnaCodeEntityConfiguration()
            : this("Settings")
        {
        }

        public ContactsMultiAnaCodeEntityConfiguration(string schema)
        {
            ToTable("tContactsMultiAnaCodes", schema);
            HasKey(x => x.MultiId);

            Property(x => x.MultiId).HasColumnName(@"MultiID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.MultiIndex).HasColumnName(@"MultiIndex").HasColumnType("int").IsRequired();
            Property(x => x.Disable).HasColumnName(@"Disable").HasColumnType("bit").IsRequired();
        }
    }
}
