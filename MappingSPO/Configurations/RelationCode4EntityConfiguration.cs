using MappingSPO.Entities;

namespace MappingSPO
{
    public class RelationCode4EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RelationCode4Entity>
    {
        public RelationCode4EntityConfiguration()
            : this("Relations")
        {
        }

        public RelationCode4EntityConfiguration(string schema)
        {
            ToTable("tRelationCode4", schema);
            HasKey(x => x.RelationCodeId);

            Property(x => x.RelationCodeId).HasColumnName(@"RelationCodeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RelationCode).HasColumnName(@"RelationCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
        }
    }
}
