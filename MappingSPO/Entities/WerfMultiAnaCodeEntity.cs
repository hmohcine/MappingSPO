
namespace MappingSPO.Entities
{
    public partial class WerfMultiAnaCodeEntity
    {
		public WerfMultiAnaCodeEntity()
        {
            Disable = false;
            Domain = "C";
            InitializePartial();
		}

        public long MultiId { get; set; }
        public int MultiIndex { get; set; }
        public string MultiName { get; set; }
        public bool Disable { get; set; }
        public string Domain { get; set; }
             
        partial void InitializePartial();
    }
}
