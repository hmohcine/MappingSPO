
namespace MappingSPO.Entities
{
    public partial class WholesalerEntity
    {
		public WholesalerEntity()
        {
            IsActive = false;
            WholesalerUnitcodes = new System.Collections.Generic.List<WholesalerUnitcodeEntity>();
            WholesalerUsers = new System.Collections.Generic.List<WholesalerUserEntity>();
            InitializePartial();
		}

        public string Wholesalerkey { get; set; }
        public string Environment { get; set; }
        public bool IsActive { get; set; }
        public string FullName { get; set; }
        public string WebsiteUrl { get; set; }
        public string StoreUrl { get; set; }
        public string DefaultStoreUserName { get; set; }
        public string DefaultStorePassword { get; set; }
        public string WebserviceUrl { get; set; }
        public string WebserviceUserName { get; set; }
        public string WebservicePassword { get; set; }
        public string CustomerId { get; set; }
        public int? NumFieldEcotax { get; set; }
        public int? NumFieldSabam { get; set; }
        public int? NumFieldRecupel { get; set; }
        public System.Collections.Generic.ICollection<WholesalerUnitcodeEntity> WholesalerUnitcodes { get; set; }
        public System.Collections.Generic.ICollection<WholesalerUserEntity> WholesalerUsers { get; set; }
             
        partial void InitializePartial();
    }
}
