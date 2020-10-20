using MappingSPO.Entities;

namespace MappingSPO
{
    public class PayConditionEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PayConditionEntity>
    {
        public PayConditionEntityConfiguration()
            : this("Settings")
        {
        }

        public PayConditionEntityConfiguration(string schema)
        {
            ToTable("tPayConditions", schema);
            HasKey(x => x.PayConditionId);

            Property(x => x.PayConditionId).HasColumnName(@"PayConditionID").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mode).HasColumnName(@"Mode").HasColumnType("int").IsRequired();
            Property(x => x.Days).HasColumnName(@"Days").HasColumnType("int").IsOptional();
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
            Property(x => x.ExternalCode).HasColumnName(@"ExternalCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
        }
    }
}
