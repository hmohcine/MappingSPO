using MappingSPO.Entities;

namespace MappingSPO
{
    public class CurrencyEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CurrencyEntity>
    {
        public CurrencyEntityConfiguration()
            : this("Settings")
        {
        }

        public CurrencyEntityConfiguration(string schema)
        {
            ToTable("tCurrency", schema);
            HasKey(x => x.CurrencyCode);

            Property(x => x.CurrencyCode).HasColumnName(@"CurrencyCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.IsoCode).HasColumnName(@"ISOCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(3);
            Property(x => x.Symbol).HasColumnName(@"Symbol").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(3);
            Property(x => x.ExchangeRate).HasColumnName(@"ExchangeRate").HasColumnType("float").IsRequired();
            Property(x => x.RoundPosition).HasColumnName(@"RoundPosition").HasColumnType("int").IsRequired();
            Property(x => x.CreateDate).HasColumnName(@"CreateDate").HasColumnType("datetime").IsRequired();
            Property(x => x.UpdateDate).HasColumnName(@"UpdateDate").HasColumnType("datetime").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("int").IsRequired();
            Property(x => x.UpdatedBy).HasColumnName(@"UpdatedBy").HasColumnType("int").IsRequired();
            Property(x => x.ExchangeRateDate).HasColumnName(@"ExchangeRateDate").HasColumnType("datetime").IsRequired();

            HasRequired(a => a.User_CreatedBy).WithMany(b => b.Currencies_CreatedBy).HasForeignKey(c => c.CreatedBy).WillCascadeOnDelete(false);
            HasRequired(a => a.User_UpdatedBy).WithMany(b => b.Currencies_UpdatedBy).HasForeignKey(c => c.UpdatedBy).WillCascadeOnDelete(false);
        }
    }
}
