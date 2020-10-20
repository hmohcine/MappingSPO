using MappingSPO.Entities;

namespace MappingSPO
{
    public class HerzieningTemplateTermEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<HerzieningTemplateTermEntity>
    {
        public HerzieningTemplateTermEntityConfiguration()
            : this("Settings")
        {
        }

        public HerzieningTemplateTermEntityConfiguration(string schema)
        {
            ToTable("tHerzieningTemplateTerm", schema);
            HasKey(x => new { x.HerzieningTemplateId, x.TermId });

            Property(x => x.HerzieningTemplateId).HasColumnName(@"HerzieningTemplateID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TermId).HasColumnName(@"TermID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TermOrder).HasColumnName(@"TermOrder").HasColumnType("int").IsRequired();
            Property(x => x.TermType).HasColumnName(@"TermType").HasColumnType("int").IsRequired();
            Property(x => x.FractionLabel).HasColumnName(@"FractionLabel").HasColumnType("nvarchar").IsRequired().HasMaxLength(10);
            Property(x => x.FractionValue).HasColumnName(@"FractionValue").HasColumnType("decimal").IsRequired().HasPrecision(18,6);
            Property(x => x.IsRestFraction).HasColumnName(@"IsRestFraction").HasColumnType("bit").IsRequired();
            Property(x => x.IndexCode).HasColumnName(@"IndexCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.TermInText).HasColumnName(@"TermInText").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.DefaultDigits).HasColumnName(@"DefaultDigits").HasColumnType("int").IsRequired();

            HasOptional(a => a.HerzieningIndex).WithMany(b => b.HerzieningTemplateTerms).HasForeignKey(c => c.IndexCode).WillCascadeOnDelete(false);
            HasRequired(a => a.HerzieningTemplate).WithMany(b => b.HerzieningTemplateTerms).HasForeignKey(c => c.HerzieningTemplateId).WillCascadeOnDelete(false);
        }
    }
}
