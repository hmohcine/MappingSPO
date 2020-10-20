
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcFilterEntity
    {
		public CalcFilterEntity()
        {
            Range = 0;
            InitializePartial();
		}

        public int CalcFilterId { get; set; }
        public int Range { get; set; }
        public string FilterName { get; set; }
        public string FilterNotes { get; set; }
        public System.DateTime? CreateDate { get; set; }
        public int? UserId { get; set; }
        public string SearchRecord { get; set; }
             
        partial void InitializePartial();
    }
}
