using MappingSPO.Entities;

namespace MappingSPO
{
    public class InvoicePlanDefaultEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<InvoicePlanDefaultEntity>
    {
        public InvoicePlanDefaultEntityConfiguration()
            : this("Settings")
        {
        }

        public InvoicePlanDefaultEntityConfiguration(string schema)
        {
            ToTable("tInvoicePlanDefaults", schema);
            HasKey(x => x.InvPlanId);

            Property(x => x.InvPlanId).HasColumnName(@"InvPlanID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.InvPlanName).HasColumnName(@"InvPlanName").HasColumnType("nvarchar").IsRequired().HasMaxLength(75);
            Property(x => x.IsDefault).HasColumnName(@"IsDefault").HasColumnType("bit").IsRequired();
            Property(x => x.SchijfCount).HasColumnName(@"SchijfCount").HasColumnType("int").IsRequired();
            Property(x => x.NotesInternal).HasColumnName(@"NotesInternal").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.NotesExternal).HasColumnName(@"NotesExternal").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.DefaultVerkoopCatId).HasColumnName(@"DefaultVerkoopCatID").HasColumnType("bigint").IsOptional();
            Property(x => x.ActiviteitId).HasColumnName(@"ActiviteitID").HasColumnType("bigint").IsOptional();
        }
    }
}
