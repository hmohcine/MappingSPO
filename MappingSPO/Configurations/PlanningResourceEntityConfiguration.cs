using MappingSPO.Entities;

namespace MappingSPO
{
    public class PlanningResourceEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PlanningResourceEntity>
    {
        public PlanningResourceEntityConfiguration()
            : this("Settings")
        {
        }

        public PlanningResourceEntityConfiguration(string schema)
        {
            ToTable("tPlanningResources", schema);
            HasKey(x => x.ResourceId);

            Property(x => x.ResourceId).HasColumnName(@"ResourceID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Afkorting).HasColumnName(@"Afkorting").HasColumnType("nvarchar").IsRequired().HasMaxLength(10);
            Property(x => x.Resource).HasColumnName(@"Resource").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
            Property(x => x.LineOrder).HasColumnName(@"LineOrder").HasColumnType("int").IsRequired();
            Property(x => x.ShowTransportOnLeverbon).HasColumnName(@"ShowTransportOnLeverbon").HasColumnType("bit").IsRequired();
        }
    }
}
