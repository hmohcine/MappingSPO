using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class RelationTypeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RelationTypeEntity>
    {
        public RelationTypeEntityConfiguration()
            : this("Relations")
        {
        }

        public RelationTypeEntityConfiguration(string schema)
        {
            ToTable("tRelationType", schema);
            HasKey(x => x.RelationTypeId);

            Property(x => x.RelationTypeId).HasColumnName(@"RelationTypeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RelationType_).HasColumnName(@"RelationType").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.MasterType).HasColumnName(@"MasterType").HasColumnType("int").IsOptional();
            Property(x => x.Timestamp).HasColumnName(@"Timestamp").HasColumnType("timestamp").IsOptional();
            Property(x => x.RequiredForWerf).HasColumnName(@"RequiredForWerf").HasColumnType("bit").IsOptional();
            Property(x => x.ShortName).HasColumnName(@"ShortName").HasColumnType("nvarchar").IsOptional().HasMaxLength(4);
            Property(x => x.UseInWorkerContract).HasColumnName(@"UseInWorkerContract").HasColumnType("bit").IsRequired();
            Property(x => x.UseForShareAtWork).HasColumnName(@"UseForShareAtWork").HasColumnType("bit").IsRequired();
        }
    }
}
