
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcTransIndirectPostEntity
    {
		public CalcTransIndirectPostEntity()
        {
            InitializePartial();
		}

        public long CalcId { get; set; }
        public int TransActionNr { get; set; }
        public long CalcDetailId { get; set; }
        public int? TransState { get; set; }
        public CalcDetailEntity CalcDetail { get; set; }
             
        partial void InitializePartial();
    }
}
