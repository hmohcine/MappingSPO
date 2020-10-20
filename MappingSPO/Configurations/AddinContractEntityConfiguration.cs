using MappingSPO.Entities;

namespace MappingSPO
{
    public class AddinContractEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AddinContractEntity>
    {
        public AddinContractEntityConfiguration()
            : this("Settings")
        {
        }

        public AddinContractEntityConfiguration(string schema)
        {
            ToTable("tAddinContracts", schema);
            HasKey(x => new { x.ContractId, x.Number });

            Property(x => x.AddinId).HasColumnName(@"AddinID").HasColumnType("bigint").IsRequired();
            Property(x => x.ContractId).HasColumnName(@"ContractID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Number).HasColumnName(@"Number").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SecurityMode).HasColumnName(@"SecurityMode").HasColumnType("int").IsRequired();
            Property(x => x.Enabled).HasColumnName(@"Enabled").HasColumnType("bit").IsRequired();

            HasRequired(a => a.Addin).WithMany(b => b.AddinContracts).HasForeignKey(c => c.AddinId);
        }
    }
}
