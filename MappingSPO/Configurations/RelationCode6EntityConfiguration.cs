using MappingSPO.Entities;

namespace MappingSPO
{
    public class RelationCode6EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RelationCode6Entity>
    {
        public RelationCode6EntityConfiguration()
            : this("Relations")
        {
        }

        public RelationCode6EntityConfiguration(string schema)
        {
            ToTable("tRelationCode6", schema);
            HasKey(x => x.RelationCodeId);

            Property(x => x.RelationCodeId).HasColumnName(@"RelationCodeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RelationCode).HasColumnName(@"RelationCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
        }
    }
}
