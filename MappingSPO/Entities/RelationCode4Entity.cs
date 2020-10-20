
namespace MappingSPO.Entities
{
    public partial class RelationCode4Entity
    {
		public RelationCode4Entity()
        {
            Disabled = false;
            Relations = new System.Collections.Generic.List<RelationEntity>();
            InitializePartial();
		}

        public int RelationCodeId { get; set; }
        public string RelationCode { get; set; }
        public bool Disabled { get; set; }
        public System.Collections.Generic.ICollection<RelationEntity> Relations { get; set; }
             
        partial void InitializePartial();
    }
}
