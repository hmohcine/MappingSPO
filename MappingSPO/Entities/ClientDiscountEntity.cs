
namespace MappingSPO.Entities
{
    public partial class ClientDiscountEntity
    {
		public ClientDiscountEntity()
        {
            Relations = new System.Collections.Generic.List<RelationEntity>();
            InitializePartial();
		}

        public int ClientDiscountId { get; set; }
        public double Discountpct { get; set; }
        public string Description { get; set; }
        public bool Disabled { get; set; }
        public System.Collections.Generic.ICollection<RelationEntity> Relations { get; set; }
             
        partial void InitializePartial();
    }
}
