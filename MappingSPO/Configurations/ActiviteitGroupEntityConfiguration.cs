using MappingSPO.Entities;

namespace MappingSPO
{
    public class ActiviteitGroupEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ActiviteitGroupEntity>
    {
        public ActiviteitGroupEntityConfiguration()
            : this("Settings")
        {
        }

        public ActiviteitGroupEntityConfiguration(string schema)
        {
            ToTable("tActiviteitGroup", schema);
            HasKey(x => x.ActGroupId);

            Property(x => x.ActGroupId).HasColumnName(@"ActGroupID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ActGroup).HasColumnName(@"ActGroup").HasColumnType("nvarchar").IsRequired().HasMaxLength(150);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.ShowAsMode).HasColumnName(@"ShowASMode").HasColumnType("int").IsRequired();
            Property(x => x.ShowAs).HasColumnName(@"ShowAs").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
        }
    }
}
