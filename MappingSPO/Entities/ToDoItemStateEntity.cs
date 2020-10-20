
namespace MappingSPO.Entities
{
    public partial class ToDoItemStateEntity
    {
		public ToDoItemStateEntity()
        {
            Disabled = false;
            TodoTypeItemStates = new System.Collections.Generic.List<TodoTypeItemStateEntity>();
            InitializePartial();
		}

        public int ItemStateId { get; set; }
        public int StateOrder { get; set; }
        public string Description { get; set; }
        public bool Disabled { get; set; }
        public System.Collections.Generic.ICollection<TodoTypeItemStateEntity> TodoTypeItemStates { get; set; }
             
        partial void InitializePartial();
    }
}
