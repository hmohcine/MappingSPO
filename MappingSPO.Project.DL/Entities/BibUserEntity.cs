
namespace MappingSPO.Project.DL.Entities
{
    public partial class BibUserEntity
    {
		public BibUserEntity()
        {
            InitializePartial();
		}

        public long CalcId { get; set; }
        public int UserId { get; set; }
        public CalculationEntity Calculation { get; set; }
             
        partial void InitializePartial();
    }
}
