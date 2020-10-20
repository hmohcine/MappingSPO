using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WerfActiviteitenLinkDataEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WerfActiviteitenLinkDataEntity>
    {
        public WerfActiviteitenLinkDataEntityConfiguration()
            : this("Project")
        {
        }

        public WerfActiviteitenLinkDataEntityConfiguration(string schema)
        {
            ToTable("tWerfActiviteiten_LinkData", schema);
            HasKey(x => new { x.Source, x.WerfId, x.ActiviteitId });

            Property(x => x.Source).HasColumnName(@"Source").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ActiviteitId).HasColumnName(@"ActiviteitID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ExternalId).HasColumnName(@"ExternalId").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
        }
    }
}
