using MappingSPO.Entities;

namespace MappingSPO
{
    public class ClientDiscountEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ClientDiscountEntity>
    {
        public ClientDiscountEntityConfiguration()
            : this("Settings")
        {
        }

        public ClientDiscountEntityConfiguration(string schema)
        {
            ToTable("tClientDiscount", schema);
            HasKey(x => x.ClientDiscountId);

            Property(x => x.ClientDiscountId).HasColumnName(@"ClientDiscountID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Discountpct).HasColumnName(@"Discountpct").HasColumnType("float").IsRequired();
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
        }
    }
}
