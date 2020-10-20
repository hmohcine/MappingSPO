
namespace MappingSPO.Project.DL.Entities
{
    public partial class WWerfRelationEntity
    {
		public WWerfRelationEntity()
        {
            InitializePartial();
		}

        public long WerfId { get; set; }
        public long RelationId { get; set; }
             
        partial void InitializePartial();
    }
}
