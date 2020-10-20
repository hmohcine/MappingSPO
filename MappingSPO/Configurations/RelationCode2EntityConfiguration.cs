using MappingSPO.Entities;

namespace MappingSPO
{
    public class RelationCode2EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RelationCode2Entity>
    {
        public RelationCode2EntityConfiguration()
            : this("Relations")
        {
        }

        public RelationCode2EntityConfiguration(string schema)
        {
            ToTable("tRelationCode2", schema);
            HasKey(x => x.RelationCodeId);

            Property(x => x.RelationCodeId).HasColumnName(@"RelationCodeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RelationCode).HasColumnName(@"RelationCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
        }
    }
}
