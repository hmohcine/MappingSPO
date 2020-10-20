using MappingSPO.Entities;

namespace MappingSPO
{
    public class SubCategoryEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SubCategoryEntity>
    {
        public SubCategoryEntityConfiguration()
            : this("Settings")
        {
        }

        public SubCategoryEntityConfiguration(string schema)
        {
            ToTable("tSubCategory", schema);
            HasKey(x => x.SubCategoryId);

            Property(x => x.SubCategoryId).HasColumnName(@"SubCategoryId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CategoryId).HasColumnName(@"CategoryId").HasColumnType("int").IsRequired();
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.Actief).HasColumnName(@"Actief").HasColumnType("bit").IsRequired();

            HasRequired(a => a.Category).WithMany(b => b.SubCategories).HasForeignKey(c => c.CategoryId).WillCascadeOnDelete(false);
        }
    }
}
