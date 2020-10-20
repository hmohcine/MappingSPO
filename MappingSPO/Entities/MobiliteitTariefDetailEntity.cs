
namespace MappingSPO.Entities
{
    public partial class MobiliteitTariefDetailEntity
    {
		public MobiliteitTariefDetailEntity()
        {
            InitializePartial();
		}

        public string MobCode { get; set; }
        public int KmFrom { get; set; }
        public int? KmTo { get; set; }
        public decimal MobPrijsPerKm { get; set; }
        public MobiliteitsCodeEntity MobiliteitsCode { get; set; }
             
        partial void InitializePartial();
    }
}
