using MappingSPO.Entities;

namespace MappingSPO
{
    public class RelOpportunityGroupEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RelOpportunityGroupEntity>
    {
        public RelOpportunityGroupEntityConfiguration()
            : this("Settings")
        {
        }

        public RelOpportunityGroupEntityConfiguration(string schema)
        {
            ToTable("tRelOpportunityGroup", schema);
            HasKey(x => x.OppGroupId);

            Property(x => x.OppGroupId).HasColumnName(@"OppGroupID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.OppGroup).HasColumnName(@"OppGroup").HasColumnType("nvarchar").IsRequired().HasMaxLength(150);
        }
    }
}
