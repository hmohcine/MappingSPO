using MappingSPO.Entities;

namespace MappingSPO
{
    public class RelOpportunityEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RelOpportunityEntity>
    {
        public RelOpportunityEntityConfiguration()
            : this("Settings")
        {
        }

        public RelOpportunityEntityConfiguration(string schema)
        {
            ToTable("tRelOpportunity", schema);
            HasKey(x => x.OpportunityId);

            Property(x => x.OpportunityId).HasColumnName(@"OpportunityID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsRequired().HasMaxLength(150);
            Property(x => x.OppGroupId).HasColumnName(@"OppGroupID").HasColumnType("bigint").IsOptional();
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();

            HasOptional(a => a.RelOpportunityGroup).WithMany(b => b.RelOpportunities).HasForeignKey(c => c.OppGroupId).WillCascadeOnDelete(false);
        }
    }
}
