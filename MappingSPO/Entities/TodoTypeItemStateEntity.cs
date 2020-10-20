
namespace MappingSPO.Entities
{
    public partial class TodoTypeItemStateEntity
    {
		public TodoTypeItemStateEntity()
        {
            InitializePartial();
		}

        public long TodoTypeItemStateId { get; set; }
        public long TodoTypeId { get; set; }
        public int ItemStateId { get; set; }
        public int TypeStateOrder { get; set; }
        public ToDoItemStateEntity ToDoItemState { get; set; }
        public TodoTypeEntity TodoType { get; set; }
             
        partial void InitializePartial();
    }
}
