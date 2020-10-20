using MappingSPO.Entities;

namespace MappingSPO
{
    public class AddinContractsSecurityEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AddinContractsSecurityEntity>
    {
        public AddinContractsSecurityEntityConfiguration()
            : this("Settings")
        {
        }

        public AddinContractsSecurityEntityConfiguration(string schema)
        {
            ToTable("tAddinContractsSecurity", schema);
            HasKey(x => new { x.ContractId, x.Number, x.UserGroupId });

            Property(x => x.ContractId).HasColumnName(@"ContractID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Number).HasColumnName(@"Number").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UserGroupId).HasColumnName(@"UserGroupID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            HasRequired(a => a.AddinContract).WithMany(b => b.AddinContractsSecurities).HasForeignKey(c => new { c.ContractId, c.Number }).WillCascadeOnDelete(false);
            HasRequired(a => a.UsersGroep).WithMany(b => b.AddinContractsSecurities).HasForeignKey(c => c.UserGroupId);
        }
    }
}
