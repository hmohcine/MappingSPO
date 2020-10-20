
namespace MappingSPO.Entities
{
    public partial class CalcErrorEntity
    {
		public CalcErrorEntity()
        {
            InitializePartial();
		}

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Severity { get; set; }
        public string Column { get; set; }
             
        partial void InitializePartial();
    }
}
