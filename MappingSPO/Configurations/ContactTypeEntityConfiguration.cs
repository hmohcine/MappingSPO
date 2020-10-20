using MappingSPO.Entities;

namespace MappingSPO
{
    public class ContactTypeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ContactTypeEntity>
    {
        public ContactTypeEntityConfiguration()
            : this("Relations")
        {
        }

        public ContactTypeEntityConfiguration(string schema)
        {
            ToTable("tContactType", schema);
            HasKey(x => x.ContactTypeId);

            Property(x => x.ContactTypeId).HasColumnName(@"ContactTypeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ContactType_).HasColumnName(@"ContactType").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.MasterType).HasColumnName(@"MasterType").HasColumnType("int").IsOptional();
        }
    }
}
