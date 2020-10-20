using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcRelationContactEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcRelationContactEntity>
    {
        public CalcRelationContactEntityConfiguration()
            : this("Project")
        {
        }

        public CalcRelationContactEntityConfiguration(string schema)
        {
            ToTable("tCalcRelationContacts", schema);
            HasKey(x => new { x.CalcId, x.RelationId, x.ContactId, x.RelationTypeId });

            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RelationId).HasColumnName(@"RelationID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ContactId).HasColumnName(@"ContactID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RelationTypeId).HasColumnName(@"RelationTypeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ContactTypeId).HasColumnName(@"ContactTypeID").HasColumnType("int").IsOptional();
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();

            HasRequired(a => a.CalcRelation).WithMany(b => b.CalcRelationContacts).HasForeignKey(c => new { c.CalcId, c.RelationId, c.RelationTypeId });
        }
    }
}
