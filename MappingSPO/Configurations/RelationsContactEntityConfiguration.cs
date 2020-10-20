using MappingSPO.Entities;

namespace MappingSPO
{
    public class RelationsContactEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RelationsContactEntity>
    {
        public RelationsContactEntityConfiguration()
            : this("Relations")
        {
        }

        public RelationsContactEntityConfiguration(string schema)
        {
            ToTable("tRelationsContacts", schema);
            HasKey(x => new { x.RelationId, x.ContactId });

            Property(x => x.RelationId).HasColumnName(@"RelationID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ContactId).HasColumnName(@"ContactID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Gsm).HasColumnName(@"GSM").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Phone).HasColumnName(@"Phone").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Fax).HasColumnName(@"Fax").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Email).HasColumnName(@"Email").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsOptional();
            Property(x => x.SGsm).HasColumnName(@"sGSM").HasColumnType("nvarchar").IsOptional().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.SPhone).HasColumnName(@"sPhone").HasColumnType("nvarchar").IsOptional().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.SFax).HasColumnName(@"sFax").HasColumnType("nvarchar").IsOptional().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.AccId).HasColumnName(@"AccID").HasColumnType("bigint").IsOptional();
            Property(x => x.AccType).HasColumnName(@"AccType").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(2);

            HasRequired(a => a.Contact).WithMany(b => b.RelationsContacts).HasForeignKey(c => c.ContactId);
            HasRequired(a => a.Relation).WithMany(b => b.RelationsContacts).HasForeignKey(c => c.RelationId);
        }
    }
}
