using MappingSPO.Entities;

namespace MappingSPO
{
    public class CategoryEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CategoryEntity>
    {
        public CategoryEntityConfiguration()
            : this("Settings")
        {
        }

        public CategoryEntityConfiguration(string schema)
        {
            ToTable("tCategory", schema);
            HasKey(x => x.CategoryId);

            Property(x => x.CategoryId).HasColumnName(@"CategoryId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
        }
    }
}
