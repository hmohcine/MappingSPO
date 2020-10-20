using MappingSPO.Entities;

namespace MappingSPO
{
    public class TeamsIntegrationEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TeamsIntegrationEntity>
    {
        public TeamsIntegrationEntityConfiguration()
            : this("Settings")
        {
        }

        public TeamsIntegrationEntityConfiguration(string schema)
        {
            ToTable("tTeamsIntegration", schema);
            HasKey(x => x.TeamIntegrateId);

            Property(x => x.TeamIntegrateId).HasColumnName(@"TeamIntegrateID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SharePointUrl).HasColumnName(@"SharePointUrl").HasColumnType("nvarchar").IsRequired().HasMaxLength(1000);
            Property(x => x.ClientId).HasColumnName(@"ClientId").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.ClientSecret).HasColumnName(@"ClientSecret").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.CreationDate).HasColumnName(@"CreationDate").HasColumnType("datetime").IsOptional();
            Property(x => x.ModificationDate).HasColumnName(@"ModificationDate").HasColumnType("datetime").IsOptional();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.ModifiedBy).HasColumnName(@"ModifiedBy").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.AffectedUsers).HasColumnName(@"AffectedUsers").HasColumnType("nvarchar").IsOptional().HasMaxLength(1000);
        }
    }
}
