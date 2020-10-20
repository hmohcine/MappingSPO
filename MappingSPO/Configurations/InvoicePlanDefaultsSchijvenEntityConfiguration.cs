using MappingSPO.Entities;

namespace MappingSPO
{
    public class InvoicePlanDefaultsSchijvenEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<InvoicePlanDefaultsSchijvenEntity>
    {
        public InvoicePlanDefaultsSchijvenEntityConfiguration()
            : this("Settings")
        {
        }

        public InvoicePlanDefaultsSchijvenEntityConfiguration(string schema)
        {
            ToTable("tInvoicePlanDefaultsSchijven", schema);
            HasKey(x => new { x.InvPlanId, x.SchijfNr });

            Property(x => x.InvPlanId).HasColumnName(@"InvPlanID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SchijfNr).HasColumnName(@"SchijfNr").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Pct).HasColumnName(@"Pct").HasColumnType("float").IsRequired();
            Property(x => x.IsSaldoSchijf).HasColumnName(@"IsSaldoSchijf").HasColumnType("bit").IsRequired();
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.VerkoopCatId).HasColumnName(@"VerkoopCatID").HasColumnType("bigint").IsOptional();

            HasRequired(a => a.InvoicePlanDefault).WithMany(b => b.InvoicePlanDefaultsSchijvens).HasForeignKey(c => c.InvPlanId);
        }
    }
}
