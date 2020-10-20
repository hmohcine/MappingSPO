
namespace MappingSPO.Entities
{
    public partial class SubCategoryEntity
    {
		public SubCategoryEntity()
        {
            Actief = false;
            InitializePartial();
		}

        public int SubCategoryId { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public bool Actief { get; set; }
        public CategoryEntity Category { get; set; }
             
        partial void InitializePartial();
    }
}
