
namespace MappingSPO.Entities
{
    public partial class CategoryEntity
    {
		public CategoryEntity()
        {
            SubCategories = new System.Collections.Generic.List<SubCategoryEntity>();
            InitializePartial();
		}

        public int CategoryId { get; set; }
        public string Description { get; set; }
        public System.Collections.Generic.ICollection<SubCategoryEntity> SubCategories { get; set; }
             
        partial void InitializePartial();
    }
}
