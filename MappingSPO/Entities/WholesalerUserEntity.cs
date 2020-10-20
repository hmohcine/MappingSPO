
namespace MappingSPO.Entities
{
    public partial class WholesalerUserEntity
    {
		public WholesalerUserEntity()
        {
            Allowed = true;
            InitializePartial();
		}

        public string Wholesalerkey { get; set; }
        public string Environment { get; set; }
        public int UserId { get; set; }
        public string StoreUserName { get; set; }
        public string StorePassword { get; set; }
        public bool? Allowed { get; set; }
        public WholesalerEntity Wholesaler { get; set; }
             
        partial void InitializePartial();
    }
}
