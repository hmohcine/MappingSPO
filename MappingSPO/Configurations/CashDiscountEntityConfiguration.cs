using MappingSPO.Entities;

namespace MappingSPO
{
    public class CashDiscountEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CashDiscountEntity>
    {
        public CashDiscountEntityConfiguration()
            : this("Settings")
        {
        }

        public CashDiscountEntityConfiguration(string schema)
        {
            ToTable("tCashDiscount", schema);
            HasKey(x => x.CashDiscountId);

            Property(x => x.CashDiscountId).HasColumnName(@"CashDiscountID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Discountpct).HasColumnName(@"Discountpct").HasColumnType("float").IsRequired();
            Property(x => x.Days).HasColumnName(@"Days").HasColumnType("int").IsRequired();
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
            Property(x => x.WhereToUseMode).HasColumnName(@"WhereToUseMode").HasColumnType("int").IsRequired();
            Property(x => x.ExternalCode).HasColumnName(@"ExternalCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
        }
    }
}
