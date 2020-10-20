using MappingSPO.Entities;

namespace MappingSPO
{
    public class HerzieningTemplateEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<HerzieningTemplateEntity>
    {
        public HerzieningTemplateEntityConfiguration()
            : this("Settings")
        {
        }

        public HerzieningTemplateEntityConfiguration(string schema)
        {
            ToTable("tHerzieningTemplate", schema);
            HasKey(x => x.HerzieningTemplateId);

            Property(x => x.HerzieningTemplateId).HasColumnName(@"HerzieningTemplateID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsRequired().HasMaxLength(10);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.DescriptionExtern).HasColumnName(@"DescriptionExtern").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.State).HasColumnName(@"State").HasColumnType("int").IsRequired();
            Property(x => x.CountOfTerms).HasColumnName(@"CountOfTerms").HasColumnType("int").IsRequired();
            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.FormuleInText).HasColumnName(@"FormuleInText").HasColumnType("nvarchar").IsOptional().HasMaxLength(4000);
            Property(x => x.FormuleValid).HasColumnName(@"FormuleValid").HasColumnType("bit").IsRequired();
            Property(x => x.FormuleInText2).HasColumnName(@"FormuleInText2").HasColumnType("nvarchar").IsOptional().HasMaxLength(4000);
        }
    }
}
