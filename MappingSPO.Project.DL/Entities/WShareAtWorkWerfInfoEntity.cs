
namespace MappingSPO.Project.DL.Entities
{
    public partial class WShareAtWorkWerfInfoEntity
    {
		public WShareAtWorkWerfInfoEntity()
        {
            InitializePartial();
		}

        public long WerfId { get; set; }
        public int WerfState { get; set; }
        public string FullWerfNumber { get; set; }
        public string DefaultCompany { get; set; }
        public string Code1 { get; set; }
        public string WerfName { get; set; }
        public string ProjectLeider { get; set; }
        public System.DateTime? StartDate { get; set; }
        public System.DateTime? EndDate { get; set; }
        public bool? CheckInAtWorkYn { get; set; }
        public string ExtNumber { get; set; }
        public string WerfAdres { get; set; }
        public string WerfAdresZip { get; set; }
        public string WerfAdresCountry { get; set; }
        public string WerfAdresCity { get; set; }
        public string CompanyOwner { get; set; }
        public string CompanyDepartment { get; set; }
        public string KlantAdresName { get; set; }
             
        partial void InitializePartial();
    }
}
