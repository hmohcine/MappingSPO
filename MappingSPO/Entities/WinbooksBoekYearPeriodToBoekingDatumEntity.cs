
namespace MappingSPO.Entities
{
    public partial class WinbooksBoekYearPeriodToBoekingDatumEntity
    {
		public WinbooksBoekYearPeriodToBoekingDatumEntity()
        {
            InitializePartial();
		}

        public long CompanyId { get; set; }
        public string Bookyear { get; set; }
        public string Period { get; set; }
        public System.DateTime BoekDatum { get; set; }
             
        partial void InitializePartial();
    }
}
