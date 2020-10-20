using MappingSPO.Entities;

namespace MappingSPO
{
    public class EmmaAddinContractEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmmaAddinContractEntity>
    {
        public EmmaAddinContractEntityConfiguration()
            : this("Settings")
        {
        }

        public EmmaAddinContractEntityConfiguration(string schema)
        {
            ToTable("tEmmaAddinContracts", schema);
            HasKey(x => new { x.ContractId, x.Number });

            Property(x => x.AddinId).HasColumnName(@"AddinID").HasColumnType("bigint").IsRequired();
            Property(x => x.ContractId).HasColumnName(@"ContractID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Number).HasColumnName(@"Number").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SecurityMode).HasColumnName(@"SecurityMode").HasColumnType("int").IsRequired();
            Property(x => x.Enabled).HasColumnName(@"Enabled").HasColumnType("bit").IsRequired();

            HasRequired(a => a.EmmaAddin).WithMany(b => b.EmmaAddinContracts).HasForeignKey(c => c.AddinId);
        }
    }
}
