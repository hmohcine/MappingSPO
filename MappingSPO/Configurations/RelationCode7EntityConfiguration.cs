using MappingSPO.Entities;

namespace MappingSPO
{
    public class RelationCode7EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RelationCode7Entity>
    {
        public RelationCode7EntityConfiguration()
            : this("Relations")
        {
        }

        public RelationCode7EntityConfiguration(string schema)
        {
            ToTable("tRelationCode7", schema);
            HasKey(x => x.RelationCodeId);

            Property(x => x.RelationCodeId).HasColumnName(@"RelationCodeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RelationCode).HasColumnName(@"RelationCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
        }
    }
}
