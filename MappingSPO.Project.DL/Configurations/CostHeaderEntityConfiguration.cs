using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CostHeaderEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CostHeaderEntity>
    {
        public CostHeaderEntityConfiguration()
            : this("Project")
        {
        }

        public CostHeaderEntityConfiguration(string schema)
        {
            ToTable("tCostHeader", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CostHeaderType).HasColumnName(@"CostHeaderType").HasColumnType("nvarchar").IsRequired().HasMaxLength(10);
            Property(x => x.DefaultDocumentdatum).HasColumnName(@"DefaultDocumentdatum").HasColumnType("datetime").IsOptional();
            Property(x => x.IngaveDatum).HasColumnName(@"IngaveDatum").HasColumnType("datetime").IsOptional();
            Property(x => x.Documentnummer).HasColumnName(@"Documentnummer").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.RelationId).HasColumnName(@"RelationID").HasColumnType("bigint").IsOptional();
            Property(x => x.ContactId).HasColumnName(@"ContactID").HasColumnType("int").IsOptional();
            Property(x => x.DefaultReferentie).HasColumnName(@"DefaultReferentie").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.DefaultActiviteitId).HasColumnName(@"DefaultActiviteitID").HasColumnType("bigint").IsOptional();
            Property(x => x.DefaultWerfId).HasColumnName(@"DefaultWerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.DefaultKs).HasColumnName(@"DefaultKS").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Verantwoordelijke).HasColumnName(@"Verantwoordelijke").HasColumnType("int").IsOptional();
            Property(x => x.CreateDate).HasColumnName(@"CreateDate").HasColumnType("datetime").IsOptional();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("int").IsRequired();
            Property(x => x.LastChangedDate).HasColumnName(@"LastChangedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.LastChangedBy).HasColumnName(@"LastChangedBy").HasColumnType("int").IsRequired();
            Property(x => x.CostNrYear).HasColumnName(@"CostNrYear").HasColumnType("int").IsOptional();
            Property(x => x.CostNr).HasColumnName(@"CostNr").HasColumnType("bigint").IsOptional();
            Property(x => x.DefaultRegieYn).HasColumnName(@"DefaultRegieYn").HasColumnType("bit").IsOptional();
            Property(x => x.DefaultReferentieIntern).HasColumnName(@"DefaultReferentieIntern").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.SbLeveringId).HasColumnName(@"SBLeveringID").HasColumnType("bigint").IsOptional();
            Property(x => x.NotesExternal).HasColumnName(@"NotesExternal").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.NotesExternal2).HasColumnName(@"NotesExternal2").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.NotesInternal).HasColumnName(@"NotesInternal").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.DefaultLeveradresId).HasColumnName(@"DefaultLeveradresID").HasColumnType("bigint").IsOptional();
            Property(x => x.DefaultMagazijnId).HasColumnName(@"DefaultMagazijnID").HasColumnType("bigint").IsOptional();
            Property(x => x.RelationTypeId).HasColumnName(@"RelationTypeID").HasColumnType("int").IsOptional();
            Property(x => x.AnaCodeId).HasColumnName(@"AnaCodeID").HasColumnType("bigint").IsOptional();
            Property(x => x.DefaultInkoopCatId).HasColumnName(@"DefaultInkoopCatID").HasColumnType("bigint").IsOptional();
            Property(x => x.DefaultCompanyId).HasColumnName(@"DefaultCompanyID").HasColumnType("int").IsOptional();

            HasOptional(a => a.Contact).WithMany(b => b.CostHeaders).HasForeignKey(c => c.ContactId).WillCascadeOnDelete(false);
            HasOptional(a => a.Relation).WithMany(b => b.CostHeaders).HasForeignKey(c => c.RelationId).WillCascadeOnDelete(false);
            HasOptional(a => a.Werf).WithMany(b => b.CostHeaders).HasForeignKey(c => c.DefaultWerfId);
            HasRequired(a => a.CostHeaderType_CostHeaderType).WithMany(b => b.CostHeaders).HasForeignKey(c => c.CostHeaderType).WillCascadeOnDelete(false);
        }
    }
}
