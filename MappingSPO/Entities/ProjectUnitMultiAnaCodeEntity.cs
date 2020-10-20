
namespace MappingSPO.Entities
{
    public partial class ProjectUnitMultiAnaCodeEntity
    {
		public ProjectUnitMultiAnaCodeEntity()
        {
            Disable = false;
            InitializePartial();
		}

        public long MultiId { get; set; }
        public int MultiIndex { get; set; }
        public string MultiName { get; set; }
        public bool Disable { get; set; }
             
        partial void InitializePartial();
    }
}
