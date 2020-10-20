using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcRelationEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcRelationEntity>
    {
        public CalcRelationEntityConfiguration()
            : this("Project")
        {
        }

        public CalcRelationEntityConfiguration(string schema)
        {
            ToTable("tCalcRelation", schema);
            HasKey(x => new { x.CalcId, x.RelationId, x.RelationTypeId });

            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RelationId).HasColumnName(@"RelationID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RelationTypeId).HasColumnName(@"RelationTypeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.DefaultContactId).HasColumnName(@"DefaultContactID").HasColumnType("int").IsOptional();
            Property(x => x.LastOfferPreview).HasColumnName(@"LastOfferPreview").HasColumnType("datetime").IsOptional();
            Property(x => x.LastOfferPrint).HasColumnName(@"LastOfferPrint").HasColumnType("datetime").IsOptional();
            Property(x => x.LanguageCode).HasColumnName(@"LanguageCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);

            HasRequired(a => a.Calculation).WithMany(b => b.CalcRelations).HasForeignKey(c => c.CalcId);
            HasRequired(a => a.Relation).WithMany(b => b.CalcRelations).HasForeignKey(c => c.RelationId).WillCascadeOnDelete(false);
            HasRequired(a => a.RelationType).WithMany(b => b.CalcRelations).HasForeignKey(c => c.RelationTypeId).WillCascadeOnDelete(false);
            HasRequired(a => a.WCalculationExplorerDx).WithMany(b => b.CalcRelations).HasForeignKey(c => c.CalcId).WillCascadeOnDelete(false);
        }
    }
}
