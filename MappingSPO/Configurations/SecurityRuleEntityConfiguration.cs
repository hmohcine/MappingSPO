using MappingSPO.Entities;

namespace MappingSPO
{
    public class SecurityRuleEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SecurityRuleEntity>
    {
        public SecurityRuleEntityConfiguration()
            : this("Settings")
        {
        }

        public SecurityRuleEntityConfiguration(string schema)
        {
            ToTable("tSecurityRules", schema);
            HasKey(x => x.RuleId);

            Property(x => x.RuleId).HasColumnName(@"RuleID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RuleNr).HasColumnName(@"RuleNr").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.RuleDomain).HasColumnName(@"RuleDomain").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.RuleName).HasColumnName(@"RuleName").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
        }
    }
}
