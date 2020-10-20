
namespace MappingSPO.Entities
{
    public partial class CalcCode6Entity
    {
		public CalcCode6Entity()
        {
            CalcDisabled = false;
            Domain = "C";
            InitializePartial();
		}

        public int CalcCodeId { get; set; }
        public string CalcCode { get; set; }
        public bool CalcDisabled { get; set; }
        public string Domain { get; set; }
             
        partial void InitializePartial();
    }
}
