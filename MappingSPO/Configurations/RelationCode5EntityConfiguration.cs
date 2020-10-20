using MappingSPO.Entities;

namespace MappingSPO
{
    public class RelationCode5EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RelationCode5Entity>
    {
        public RelationCode5EntityConfiguration()
            : this("Relations")
        {
        }

        public RelationCode5EntityConfiguration(string schema)
        {
            ToTable("tRelationCode5", schema);
            HasKey(x => x.RelationCodeId);

            Property(x => x.RelationCodeId).HasColumnName(@"RelationCodeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RelationCode).HasColumnName(@"RelationCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
        }
    }
}
