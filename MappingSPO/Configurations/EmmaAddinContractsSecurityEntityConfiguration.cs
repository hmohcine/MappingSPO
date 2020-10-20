using MappingSPO.Entities;

namespace MappingSPO
{
    public class EmmaAddinContractsSecurityEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmmaAddinContractsSecurityEntity>
    {
        public EmmaAddinContractsSecurityEntityConfiguration()
            : this("Settings")
        {
        }

        public EmmaAddinContractsSecurityEntityConfiguration(string schema)
        {
            ToTable("tEmmaAddinContractsSecurity", schema);
            HasKey(x => new { x.ContractId, x.Number, x.UserGroupId });

            Property(x => x.ContractId).HasColumnName(@"ContractID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Number).HasColumnName(@"Number").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UserGroupId).HasColumnName(@"UserGroupID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            HasRequired(a => a.EmmaAddinContract).WithMany(b => b.EmmaAddinContractsSecurities).HasForeignKey(c => new { c.ContractId, c.Number }).WillCascadeOnDelete(false);
            HasRequired(a => a.UsersGroep).WithMany(b => b.EmmaAddinContractsSecurities).HasForeignKey(c => c.UserGroupId);
        }
    }
}
